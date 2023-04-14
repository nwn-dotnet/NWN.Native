# NWN.Native
NWN.Native is a package containing the C# proxy classes for interacting with the native NWNX interop library using the [Simplified Wrapper and Interface Generator](http://www.swig.org/).

It is an advanced tool that is meant to be used by those with well-versed knowledge of C#, C++ and the NWN game engine. It should only be used as a last resort if you require very specific or complex behaviours that are not supported by [NWN.Anvil](https://github.com/nwn-dotnet/Anvil), [NWN.Core](https://github.com/nwn-dotnet/NWN.Core) or [NWNX](https://github.com/nwnxee).

Classes and class members are named to match the C++ structure/member names, and global members can be accessed via `NWNXLib` & `FunctionsLinux`.  All classes are part of the `NWN.Native.API` namespace.

Here is an example on how to implement the Get/SetSoundset functions from the NWNX Creature plugin:

### Using NWNX
```c++
NWNX_EXPORT ArgumentStack GetSoundset(ArgumentStack&& args)
{
    const auto objectId = args.extract<ObjectID>();
    if (auto *pCreature = API::Globals::AppManager()->m_pServerExoApp->GetGameObject(objectId)->AsNWSCreature())
        return pCreature->m_nSoundSet;

    return -1;
}

NWNX_EXPORT ArgumentStack SetSoundset(ArgumentStack&& args)
{
    const auto objectId = args.extract<ObjectID>();
    if (auto *pCreature = API::Globals::AppManager()->m_pServerExoApp->GetGameObject(objectId)->AsNWSCreature())
    {
        const auto soundset = args.extract<int32_t>();
          ASSERT_OR_THROW(soundset >= 0);

        pCreature->m_nSoundSet = static_cast<uint16_t>(soundset);
    }
    return {};
}
```

### Using NWN.Native
```c#
public static ushort GetSoundset(uint objectId)
{
  CNWSCreature creature = NWNXLib.AppManager().m_pServerExoApp.GetGameObject(objectId)?.AsNWSCreature();
  if (creature != null)
  {
    return creature.m_nSoundSet;
  }
  
  return -1;
}

public static void SetSoundset(uint objectId, ushort newValue)
{
  CNWSCreature creature = NWNXLib.AppManager().m_pServerExoApp.GetGameObject(objectId)?.AsNWSCreature();
  if (creature != null)
  {
    creature.m_nSoundSet = newValue;
  }
}
```

## StringHelper
Encoding can become an issue when you cross the native <--> managed boundary, as C# strings are UTF16 encoded while the game expects single-byte cp1252 encoded strings for the majority of functions.

NWN.Native includes a StringHelper class to help with the conversion and encoding of strings. 

Here is an example on how you would get the contents of a .nss file:

### Using NWNX
```c++
NWNX_EXPORT ArgumentStack GetNSSContents(ArgumentStack&& args)
{
    std::string retVal;

    const auto scriptName = args.extract<std::string>();
      ASSERT_OR_THROW(!scriptName.empty());
      ASSERT_OR_THROW(scriptName.size() <= 16);
    const auto maxLength = args.extract<int32_t>();

    if (Globals::ExoResMan()->Exists(scriptName.c_str(), Constants::ResRefType::NSS, nullptr))
    {
        CScriptSourceFile scriptSourceFile;
        char *data;
        uint32_t size = 0;

        if (scriptSourceFile.LoadScript(scriptName, &data, &size) == 0)
        {
            retVal.assign(data, maxLength < 0 ? size : (uint32_t)maxLength > size ? size : maxLength);
            scriptSourceFile.UnloadScript();
        }
    }

    return retVal;
}
```

### Using NWN.Native
```c#
public static unsafe string GetNSSContents(string scriptName)
{
  if (string.IsNullOrEmpty(scriptName) || scriptName.Length > 16)
  {
    throw new ArgumentOutOfRangeException(nameof(scriptName), "Script name must not be null/empty and must be less than 16 characters.");
  }

  CExoString exoScriptName = new CExoString(StringHelper.GetNullTerminatedString(scriptName));
  CResRef resRef = new CResRef(StringHelper.GetNullTerminatedString(scriptName));

  if (NWNXLib.ExoResMan().Exists(resRef, (ushort)ResRefType.NSS) == 1)
  {
    CScriptSourceFile scriptSourceFile = new CScriptSourceFile();
    byte* data;
    uint size = 0;

    if (scriptSourceFile.LoadScript(exoScriptName, &data, &size) == 0)
    {
      string retVal = StringHelper.ReadFixedLengthString(data, (int)size);
      scriptSourceFile.UnloadScript();
      return retVal;
    }
  }

  return null;
}
```

`StringHelper.GetNullTerminatedString` may also be invoked as an extension method:

```c#
      CExoString exoScriptName = new CExoString(scriptName.GetNullTerminatedString());
      CResRef resRef = new CResRef(scriptName.GetNullTerminatedString());
```

## Function Hooking
Function hooks require access to the `RequestHook` and `ReturnHook` delegates bootstrapped by the NWNX_DotNET plugin.

They are available in [NWN.Anvil](https://github.com/nwn-dotnet/Anvil) as a part of the `HookService`. For [NWN.Core](https://github.com/nwn-dotnet/NWN.Core) users, they can be found in `VM.RequestHook()` and `VM.ReturnHook()`.

To hook a function, you need to create a matching delegate in C# that matches the function stack EXACTLY. For any parameter type that is [non-blittable](https://docs.microsoft.com/en-us/dotnet/framework/interop/blittable-and-non-blittable-types), you must use System.IntPtr, or void* as the delegate parameter and resolve the proxy class by using `ClassName.FromPointer(ptr);`

Here is an example on how to hook the `SaveServerCharacterHook` method to create a event for when a player character is saved.

### Using NWNX
```c++
namespace Events {

using namespace NWNXLib;
using namespace NWNXLib::API;
using namespace NWNXLib::Services;

static Hooks::Hook s_ServerCharacterSaveHook;

static int32_t SaveServerCharacterHook(CNWSPlayer*, int32_t);

void ClientEvents() __attribute__((constructor));
void ClientEvents()
{
    InitOnFirstSubscribe("NWNX_ON_SERVER_CHARACTER_SAVE_.*", []() {
        s_ServerCharacterSaveHook = Hooks::HookFunction(API::Functions::_ZN10CNWSPlayer19SaveServerCharacterEi,
                                                 (void*)&SaveServerCharacterHook, Hooks::Order::Early);
    });
}

int32_t SaveServerCharacterHook(CNWSPlayer *pPlayer, int32_t bBackupPlayer)
{
    int32_t retVal;

    auto PushAndSignal = [&](const std::string& ev) -> bool {
        return SignalEvent(ev, pPlayer->m_oidNWSObject);
    };

    if (PushAndSignal("NWNX_ON_SERVER_CHARACTER_SAVE_BEFORE"))
    {
        retVal = s_ServerCharacterSaveHook->CallOriginal<int32_t>(pPlayer, bBackupPlayer);
    }
    else
    {
        retVal = false;
    }

    PushAndSignal("NWNX_ON_SERVER_CHARACTER_SAVE_AFTER");

    return retVal;
}
```

### Using NWN.Native/NWN.Anvil
```c#
public sealed class OnServerCharacterSave : IEvent
{
  /// <summary>
  /// Gets the player that is being saved.
  /// </summary>
  public NwPlayer Player { get; private init; }

  /// <summary>
  /// Gets or sets a value indicating whether the character should be prevented from being saved.
  /// </summary>
  public bool PreventSave { get; set; }

  NwObject IEvent.Context
  {
    get => Player.ControlledCreature;
  }

  internal sealed unsafe class Factory : SingleHookEventFactory<Factory.SaveServerCharacterHook>
  {
    [NativeFunction("_ZN10CNWSPlayer19SaveServerCharacterEi", "?SaveServerCharacter@CNWSPlayer@@QEAAHH@Z")]
    private delegate int SaveServerCharacterHook(void* pPlayer, int bBackupPlayer);

    protected override FunctionHook<SaveServerCharacterHook> RequestHook()
    {
      delegate* unmanaged<void*, int, int> pHook = &OnSaveServerCharacter;
      return HookService.RequestHook<SaveServerCharacterHook>(pHook, HookOrder.Early);
    }

    [UnmanagedCallersOnly]
    private static int OnSaveServerCharacter(void* pPlayer, int bBackupPlayer)
    {
      OnServerCharacterSave eventData = ProcessEvent(new OnServerCharacterSave
      {
        Player = CNWSPlayer.FromPointer(pPlayer).ToNwPlayer(),
      });

      return !eventData.PreventSave ? Hook.CallOriginal(pPlayer, bBackupPlayer) : 0;
    }
  }
}
```

### Using NWN.Native/NWN.Core
```c#
public sealed class OnServerCharacterSave
{
  public CNWSPlayer Player { get; init; }

  public bool PreventSave { get; set; }
}

public static unsafe class OnServerCharacterSaveEventFactory
{
  public static event Action<OnServerCharacterSave> OnCharacterSave;

  private static readonly SaveServerCharacterHook CallOriginal;

  static OnServerCharacterSaveEventFactory()
  {
    delegate* unmanaged<void*, int, int> pHook = &OnSaveServerCharacter;
    IntPtr hookPtr = VM.RequestHook(NativeLibrary.GetExport(NativeLibrary.GetMainProgramHandle(), "_ZN10CNWSPlayer19SaveServerCharacterEi"), (IntPtr)pHook, -1000000);
    CallOriginal = Marshal.GetDelegateForFunctionPointer<SaveServerCharacterHook>(hookPtr);
  }

  internal delegate int SaveServerCharacterHook(void* pPlayer, int bBackupPlayer);

  [UnmanagedCallersOnly]
  private static int OnSaveServerCharacter(void* pPlayer, int bBackupPlayer)
  {
    OnServerCharacterSave eventData = new OnServerCharacterSave
    {
      Player = CNWSPlayer.FromPointer(pPlayer)
    };

    OnCharacterSave?.Invoke(eventData);
    return !eventData.PreventSave ? CallOriginal(pPlayer, bBackupPlayer) : 0;
  }
}
```
