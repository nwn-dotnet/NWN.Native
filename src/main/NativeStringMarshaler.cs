using System;
using System.Runtime.InteropServices;

namespace NWN.Native.API
{
  /// <summary>
  /// String marshaler for usages of distinct string types (std::string).
  /// </summary>
  public sealed unsafe class NativeStringMarshaler : ICustomMarshaler
  {
    private static NativeStringMarshaler instance;

    public IntPtr MarshalManagedToNative(object managedObj)
    {
      if (managedObj == null)
      {
        return IntPtr.Zero;
      }

      if (managedObj is string data)
      {
        return (IntPtr)data.GetNullTerminatedString();
      }

      throw new MarshalDirectiveException($"{nameof(NativeStringMarshaler)} must be used on a string.");
    }

    public object MarshalNativeToManaged(IntPtr pNativeData)
    {
      return pNativeData.ReadNullTerminatedString();
    }

    public void CleanUpNativeData(IntPtr pNativeData)
    {
      Marshal.FreeHGlobal(pNativeData);
    }

    public void CleanUpManagedData(object managedObj) {}

    public int GetNativeDataSize()
    {
      return -1;
    }

    public static ICustomMarshaler GetInstance(string pstrCookie)
    {
      if (instance == null)
      {
        return instance = new NativeStringMarshaler();
      }

      return instance;
    }
  }
}
