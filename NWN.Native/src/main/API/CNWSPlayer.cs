//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public unsafe class CNWSPlayer : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSPlayer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlayer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSPlayer() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSPlayer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWSPlayer self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSPlayer FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSPlayer((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSPlayer FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSPlayer(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSPlayer other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSPlayer other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSPlayer left, CNWSPlayer right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSPlayer left, CNWSPlayer right) {
    return !Equals(left, right);
  }

  public unsafe class NuiState : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal NuiState(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NuiState obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~NuiState() {
      Dispose(false);
    }
  
    public void Dispose() {
      Dispose(true);
      global::System.GC.SuppressFinalize(this);
    }
  
    protected virtual void Dispose(bool disposing) {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NWNXLibPINVOKE.delete_CNWSPlayer_NuiState(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
      }
    }
  
    public global::System.IntPtr Pointer {
      get {
        return swigCPtr.Handle;
      }
    }
  
    public static unsafe implicit operator void*(NuiState self) {
      return (void*)self.swigCPtr.Handle;
    }
  
    public static unsafe NuiState FromPointer(void* pointer, bool memoryOwn = false) {
      return pointer != null ? new NuiState((global::System.IntPtr)pointer, memoryOwn) : null;
    }
  
    public static NuiState FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
      return pointer != global::System.IntPtr.Zero ? new NuiState(pointer, memoryOwn) : null;
    }
  
    public bool Equals(NuiState other) {
      if (ReferenceEquals(null, other)) {
        return false;
      }
  
      if (ReferenceEquals(this, other)) {
        return true;
      }
  
      return Pointer.Equals(other.Pointer);
    }
  
    public override bool Equals(object obj) {
      return ReferenceEquals(this, obj) || obj is NuiState other && Equals(other);
    }
  
    public override int GetHashCode() {
      return swigCPtr.Handle.GetHashCode();
    }
  
    public static bool operator ==(NuiState left, NuiState right) {
      return Equals(left, right);
    }
  
    public static bool operator !=(NuiState left, NuiState right) {
      return !Equals(left, right);
    }
  
      public unsafe class WindowState : global::System.IDisposable {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;
      
        internal WindowState(global::System.IntPtr cPtr, bool cMemoryOwn) {
          swigCMemOwn = cMemoryOwn;
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }
      
        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(WindowState obj) {
          return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }
      
        ~WindowState() {
          Dispose(false);
        }
      
        public void Dispose() {
          Dispose(true);
          global::System.GC.SuppressFinalize(this);
        }
      
        protected virtual void Dispose(bool disposing) {
          lock(this) {
            if (swigCPtr.Handle != global::System.IntPtr.Zero) {
              if (swigCMemOwn) {
                swigCMemOwn = false;
                NWNXLibPINVOKE.delete_CNWSPlayer_NuiState_WindowState(swigCPtr);
              }
              swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }
          }
        }
      
        public global::System.IntPtr Pointer {
          get {
            return swigCPtr.Handle;
          }
        }
      
        public static unsafe implicit operator void*(WindowState self) {
          return (void*)self.swigCPtr.Handle;
        }
      
        public static unsafe WindowState FromPointer(void* pointer, bool memoryOwn = false) {
          return pointer != null ? new WindowState((global::System.IntPtr)pointer, memoryOwn) : null;
        }
      
        public static WindowState FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
          return pointer != global::System.IntPtr.Zero ? new WindowState(pointer, memoryOwn) : null;
        }
      
        public bool Equals(WindowState other) {
          if (ReferenceEquals(null, other)) {
            return false;
          }
      
          if (ReferenceEquals(this, other)) {
            return true;
          }
      
          return Pointer.Equals(other.Pointer);
        }
      
        public override bool Equals(object obj) {
          return ReferenceEquals(this, obj) || obj is WindowState other && Equals(other);
        }
      
        public override int GetHashCode() {
          return swigCPtr.Handle.GetHashCode();
        }
      
        public static bool operator ==(WindowState left, WindowState right) {
          return Equals(left, right);
        }
      
        public static bool operator !=(WindowState left, WindowState right) {
          return !Equals(left, right);
        }
      
        public int m_token {
          set {
            NWNXLibPINVOKE.CNWSPlayer_NuiState_WindowState_m_token_set(swigCPtr, value);
          } 
          get {
            int retVal = NWNXLibPINVOKE.CNWSPlayer_NuiState_WindowState_m_token_get(swigCPtr);
            return retVal;
          }
      
        }
      
        public string m_id {
          set {
            NWNXLibPINVOKE.CNWSPlayer_NuiState_WindowState_m_id_set(swigCPtr, value);
            if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
          } 
          get {
            string ret = NWNXLibPINVOKE.CNWSPlayer_NuiState_WindowState_m_id_get(swigCPtr);
            if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
            return ret;
          } 
        }
      
        public SWIGTYPE_p_std__vectorT_std__string_t m_bind_list {
          set {
            NWNXLibPINVOKE.CNWSPlayer_NuiState_WindowState_m_bind_list_set(swigCPtr, SWIGTYPE_p_std__vectorT_std__string_t.getCPtr(value));
          } 
          get {
            global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_NuiState_WindowState_m_bind_list_get(swigCPtr);
            SWIGTYPE_p_std__vectorT_std__string_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_std__string_t(cPtr, false);
            return ret;
          } 
        }
      
        public SWIGTYPE_p_std__unordered_mapT_std__string_nlohmann__json_t m_binds {
          set {
            NWNXLibPINVOKE.CNWSPlayer_NuiState_WindowState_m_binds_set(swigCPtr, SWIGTYPE_p_std__unordered_mapT_std__string_nlohmann__json_t.getCPtr(value));
          } 
          get {
            global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_NuiState_WindowState_m_binds_get(swigCPtr);
            SWIGTYPE_p_std__unordered_mapT_std__string_nlohmann__json_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__unordered_mapT_std__string_nlohmann__json_t(cPtr, false);
            return ret;
          } 
        }
      
        public SWIGTYPE_p_std__unordered_setT_std__string_t m_watch {
          set {
            NWNXLibPINVOKE.CNWSPlayer_NuiState_WindowState_m_watch_set(swigCPtr, SWIGTYPE_p_std__unordered_setT_std__string_t.getCPtr(value));
          } 
          get {
            global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_NuiState_WindowState_m_watch_get(swigCPtr);
            SWIGTYPE_p_std__unordered_setT_std__string_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__unordered_setT_std__string_t(cPtr, false);
            return ret;
          } 
        }
      
        public SWIGTYPE_p_nlohmann__json m_userdata {
          set {
            NWNXLibPINVOKE.CNWSPlayer_NuiState_WindowState_m_userdata_set(swigCPtr, SWIGTYPE_p_nlohmann__json.getCPtr(value));
            if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
          } 
          get {
            SWIGTYPE_p_nlohmann__json ret = new SWIGTYPE_p_nlohmann__json(NWNXLibPINVOKE.CNWSPlayer_NuiState_WindowState_m_userdata_get(swigCPtr), true);
            if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
            return ret;
          } 
        }
      
        public WindowState() : this(NWNXLibPINVOKE.new_CNWSPlayer_NuiState_WindowState(), true) {
        }
      
      }
  
    public int m_next_token {
      set {
        NWNXLibPINVOKE.CNWSPlayer_NuiState_m_next_token_set(swigCPtr, value);
      } 
      get {
        int retVal = NWNXLibPINVOKE.CNWSPlayer_NuiState_m_next_token_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public SWIGTYPE_p_std__vectorT_int_t m_window_list {
      set {
        NWNXLibPINVOKE.CNWSPlayer_NuiState_m_window_list_set(swigCPtr, SWIGTYPE_p_std__vectorT_int_t.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_NuiState_m_window_list_get(swigCPtr);
        SWIGTYPE_p_std__vectorT_int_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_int_t(cPtr, false);
        return ret;
      } 
    }
  
    public SWIGTYPE_p_std__unordered_mapT_int_CNWSPlayer__NuiState__WindowState_t m_windows {
      set {
        NWNXLibPINVOKE.CNWSPlayer_NuiState_m_windows_set(swigCPtr, SWIGTYPE_p_std__unordered_mapT_int_CNWSPlayer__NuiState__WindowState_t.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_NuiState_m_windows_get(swigCPtr);
        SWIGTYPE_p_std__unordered_mapT_int_CNWSPlayer__NuiState__WindowState_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__unordered_mapT_int_CNWSPlayer__NuiState__WindowState_t(cPtr, false);
        return ret;
      } 
    }
  
    public SWIGTYPE_p_std__mapT_std__string_CNWSPlayer__NuiState__WindowState_p_t m_by_id {
      set {
        NWNXLibPINVOKE.CNWSPlayer_NuiState_m_by_id_set(swigCPtr, SWIGTYPE_p_std__mapT_std__string_CNWSPlayer__NuiState__WindowState_p_t.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_NuiState_m_by_id_get(swigCPtr);
        SWIGTYPE_p_std__mapT_std__string_CNWSPlayer__NuiState__WindowState_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__mapT_std__string_CNWSPlayer__NuiState__WindowState_p_t(cPtr, false);
        return ret;
      } 
    }
  
    public NuiState() : this(NWNXLibPINVOKE.new_CNWSPlayer_NuiState(), true) {
    }
  
  }

  public CExoArrayListCLastUpdateObjectPtr m_lstActiveObjectsLastUpdate {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_lstActiveObjectsLastUpdate_set(swigCPtr, CExoArrayListCLastUpdateObjectPtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_lstActiveObjectsLastUpdate_get(swigCPtr);
      CExoArrayListCLastUpdateObjectPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCLastUpdateObjectPtr(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListCLastUpdatePartyObjectPtr m_lstActivePartyObjectsLastUpdate {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_lstActivePartyObjectsLastUpdate_set(swigCPtr, CExoArrayListCLastUpdatePartyObjectPtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_lstActivePartyObjectsLastUpdate_get(swigCPtr);
      CExoArrayListCLastUpdatePartyObjectPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListCLastUpdatePartyObjectPtr(cPtr, false);
      return ret;
    } 
  }

  public int m_nAreaTransitionBMP {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nAreaTransitionBMP_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayer_m_nAreaTransitionBMP_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_sAreaTransitionName {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_sAreaTransitionName_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_sAreaTransitionName_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public int m_bFloatyEffects {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bFloatyEffects_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayer_m_bFloatyEffects_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nAreas {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nAreas_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayer_m_nAreas_get(swigCPtr);
      return retVal;
    }

  }

  public uint* m_pAreas {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pAreas_set(swigCPtr, value);
    } 
    get {
      uint* retVal = NWNXLibPINVOKE.CNWSPlayer_m_pAreas_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nPlayerID {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nPlayerID_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayer_m_nPlayerID_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nLanguage {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nLanguage_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayer_m_nLanguage_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nLoginState {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nLoginState_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSPlayer_m_nLoginState_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidNWSObject {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_oidNWSObject_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayer_m_oidNWSObject_get(swigCPtr);
      return retVal;
    }

  }

  public ulong m_nLastUpdatedTime {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nLastUpdatedTime_set(swigCPtr, value);
    } 
    get {
      ulong retVal = NWNXLibPINVOKE.CNWSPlayer_m_nLastUpdatedTime_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidLastObjectControlled {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_oidLastObjectControlled_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayer_m_oidLastObjectControlled_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidPCObject {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_oidPCObject_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayer_m_oidPCObject_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bIsPrimaryPlayer {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bIsPrimaryPlayer_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayer_m_bIsPrimaryPlayer_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bFromSaveGame {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bFromSaveGame_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayer_m_bFromSaveGame_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bFromTURD {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bFromTURD_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayer_m_bFromTURD_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nPlayerListIndex {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nPlayerListIndex_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayer_m_nPlayerListIndex_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bPlayModuleListingCharacters {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bPlayModuleListingCharacters_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayer_m_bPlayModuleListingCharacters_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSPlayerJournalQuest m_pJournalQuest {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pJournalQuest_set(swigCPtr, CNWSPlayerJournalQuest.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pJournalQuest_get(swigCPtr);
      CNWSPlayerJournalQuest ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerJournalQuest(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerStoreGUI m_pStoreGUI {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pStoreGUI_set(swigCPtr, CNWSPlayerStoreGUI.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pStoreGUI_get(swigCPtr);
      CNWSPlayerStoreGUI ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerStoreGUI(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerCharSheetGUI m_pCharSheetGUI {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pCharSheetGUI_set(swigCPtr, CNWSPlayerCharSheetGUI.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pCharSheetGUI_get(swigCPtr);
      CNWSPlayerCharSheetGUI ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerCharSheetGUI(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerInventoryGUI m_pInventoryGUI {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pInventoryGUI_set(swigCPtr, CNWSPlayerInventoryGUI.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pInventoryGUI_get(swigCPtr);
      CNWSPlayerInventoryGUI ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerInventoryGUI(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerInventoryGUI m_pOtherInventoryGUI {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pOtherInventoryGUI_set(swigCPtr, CNWSPlayerInventoryGUI.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pOtherInventoryGUI_get(swigCPtr);
      CNWSPlayerInventoryGUI ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerInventoryGUI(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerLastUpdateObject m_pPlayerLUO {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_pPlayerLUO_set(swigCPtr, CNWSPlayerLastUpdateObject.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_pPlayerLUO_get(swigCPtr);
      CNWSPlayerLastUpdateObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLastUpdateObject(cPtr, false);
      return ret;
    } 
  }

  public int m_bAlwaysRun {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bAlwaysRun_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayer_m_bAlwaysRun_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nCharacterType {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nCharacterType_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSPlayer_m_nCharacterType_get(swigCPtr);
      return retVal;
    }

  }

  public CResRef m_resFileName {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_resFileName_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_resFileName_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public int m_bCommunityNameAuthorized {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bCommunityNameAuthorized_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayer_m_bCommunityNameAuthorized_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bModuleInfoSucceeded {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bModuleInfoSucceeded_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayer_m_bModuleInfoSucceeded_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nIFOCharacterIndex {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nIFOCharacterIndex_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayer_m_nIFOCharacterIndex_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bCutsceneState {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bCutsceneState_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayer_m_bCutsceneState_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bTargetMode {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bTargetMode_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayer_m_bTargetMode_get(swigCPtr);
      return retVal;
    }

  }

  public SWIGTYPE_p_std__unordered_mapT_std__string_int_t m_device_properties {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_device_properties_set(swigCPtr, SWIGTYPE_p_std__unordered_mapT_std__string_int_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_device_properties_get(swigCPtr);
      SWIGTYPE_p_std__unordered_mapT_std__string_int_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__unordered_mapT_std__string_int_t(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayer.NuiState m_cNuiState {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_cNuiState_set(swigCPtr, CNWSPlayer.NuiState.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_cNuiState_get(swigCPtr);
      CNWSPlayer.NuiState ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayer.NuiState(cPtr, false);
      return ret;
    } 
  }

  public uint m_oidCameraTarget {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_oidCameraTarget_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayer_m_oidCameraTarget_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_oidDungeonMasterAvatar {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_oidDungeonMasterAvatar_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayer_m_oidDungeonMasterAvatar_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nPossessState {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nPossessState_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSPlayer_m_nPossessState_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bWasSentITP {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_bWasSentITP_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSPlayer_m_bWasSentITP_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nLatencyLastPingRequest {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nLatencyLastPingRequest_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayer_m_nLatencyLastPingRequest_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nLatencyLastPingResponse {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nLatencyLastPingResponse_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayer_m_nLatencyLastPingResponse_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nLatestLatency {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nLatestLatency_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayer_m_nLatestLatency_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nSmoothedLatency {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_nSmoothedLatency_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSPlayer_m_nSmoothedLatency_get(swigCPtr);
      return retVal;
    }

  }

  public ExponentialSmoother m_cSmoothedLatency {
    set {
      NWNXLibPINVOKE.CNWSPlayer_m_cSmoothedLatency_set(swigCPtr, ExponentialSmoother.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_m_cSmoothedLatency_get(swigCPtr);
      ExponentialSmoother ret = (cPtr == global::System.IntPtr.Zero) ? null : new ExponentialSmoother(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayer(uint nPlayerID) : this(NWNXLibPINVOKE.new_CNWSPlayer(nPlayerID), true) {
  }

  public void ClearPlayerOnDestroyGame() {
    NWNXLibPINVOKE.CNWSPlayer_ClearPlayerOnDestroyGame(swigCPtr);
  }

  public void Update() {
    NWNXLibPINVOKE.CNWSPlayer_Update(swigCPtr);
  }

  public uint LoadLocalCharacter() {
    uint retVal = NWNXLibPINVOKE.CNWSPlayer_LoadLocalCharacter(swigCPtr);
    return retVal;
  }

  public uint LoadDMCharacter() {
    uint retVal = NWNXLibPINVOKE.CNWSPlayer_LoadDMCharacter(swigCPtr);
    return retVal;
  }

  public uint LoadServerCharacter(CResRef cResRef, int bSubDirChar) {
    uint retVal = NWNXLibPINVOKE.CNWSPlayer_LoadServerCharacter__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef), bSubDirChar);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public uint LoadServerCharacter(CResRef cResRef) {
    uint retVal = NWNXLibPINVOKE.CNWSPlayer_LoadServerCharacter__SWIG_1(swigCPtr, CResRef.getCPtr(cResRef));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public CNWSCreature LoadCharacterFromIFO(uint nIndex, int bAreaLoaded, int bRunPostProcess, int bAddObjectToArray, int bDoingCharacterCopy) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_LoadCharacterFromIFO__SWIG_0(swigCPtr, nIndex, bAreaLoaded, bRunPostProcess, bAddObjectToArray, bDoingCharacterCopy);
    CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
    return ret;
  }

  public CNWSCreature LoadCharacterFromIFO(uint nIndex, int bAreaLoaded, int bRunPostProcess, int bAddObjectToArray) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_LoadCharacterFromIFO__SWIG_1(swigCPtr, nIndex, bAreaLoaded, bRunPostProcess, bAddObjectToArray);
    CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
    return ret;
  }

  public CNWSCreature LoadCharacterFromIFO(uint nIndex, int bAreaLoaded, int bRunPostProcess) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_LoadCharacterFromIFO__SWIG_2(swigCPtr, nIndex, bAreaLoaded, bRunPostProcess);
    CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
    return ret;
  }

  public CNWSCreature LoadCharacterFromIFO(uint nIndex, int bAreaLoaded) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_LoadCharacterFromIFO__SWIG_3(swigCPtr, nIndex, bAreaLoaded);
    CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
    return ret;
  }

  public CNWSCreature LoadCharacterFromIFO(uint nIndex) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_LoadCharacterFromIFO__SWIG_4(swigCPtr, nIndex);
    CNWSCreature ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSCreature(cPtr, false);
    return ret;
  }

  public void LoadTURDInfoFromIFO(uint nIndex) {
    NWNXLibPINVOKE.CNWSPlayer_LoadTURDInfoFromIFO(swigCPtr, nIndex);
  }

  public int GetCharacterInfoFromIFO(byte* nNumClasses, int* pClasses, byte* pLevels, uint* nXP) {
    int retVal = NWNXLibPINVOKE.CNWSPlayer_GetCharacterInfoFromIFO(swigCPtr, (global::System.IntPtr)nNumClasses, pClasses, pLevels, (global::System.IntPtr)nXP);
    return retVal;
  }

  public uint LoadCreatureData(CResRef cResRef, CNWSCreature pCreature) {
    uint retVal = NWNXLibPINVOKE.CNWSPlayer_LoadCreatureData(swigCPtr, CResRef.getCPtr(cResRef), CNWSCreature.getCPtr(pCreature));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SaveServerCharacter(int bBackupPlayer) {
    int retVal = NWNXLibPINVOKE.CNWSPlayer_SaveServerCharacter__SWIG_0(swigCPtr, bBackupPlayer);
    return retVal;
  }

  public int SaveServerCharacter() {
    int retVal = NWNXLibPINVOKE.CNWSPlayer_SaveServerCharacter__SWIG_1(swigCPtr);
    return retVal;
  }

  public int BackupServerCharacter(CExoString sFilename) {
    int retVal = NWNXLibPINVOKE.CNWSPlayer_BackupServerCharacter(swigCPtr, CExoString.getCPtr(sFilename));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public uint ValidateCharacter(int* bFailedServerRestriction) {
    uint retVal = NWNXLibPINVOKE.CNWSPlayer_ValidateCharacter(swigCPtr, bFailedServerRestriction);
    return retVal;
  }

  public void ValidateCharacter_SetNormalBonusFlags(ushort nFeatID, int* bNormalListFeat, int* bBonusListFeat, byte nClass) {
    NWNXLibPINVOKE.CNWSPlayer_ValidateCharacter_SetNormalBonusFlags(swigCPtr, nFeatID, (global::System.IntPtr)bNormalListFeat, (global::System.IntPtr)bBonusListFeat, nClass);
  }

  public void StripAllInvalidItemPropertiesInInventory(CNWSCreature pCreature) {
    NWNXLibPINVOKE.CNWSPlayer_StripAllInvalidItemPropertiesInInventory(swigCPtr, CNWSCreature.getCPtr(pCreature));
  }

  public void StripAllInvalidItemPropertiesOnItem(CNWSItem pItem) {
    NWNXLibPINVOKE.CNWSPlayer_StripAllInvalidItemPropertiesOnItem(swigCPtr, CNWSItem.getCPtr(pItem));
  }

  public void AddDMAbilities(CNWSCreature pCreature) {
    NWNXLibPINVOKE.CNWSPlayer_AddDMAbilities(swigCPtr, CNWSCreature.getCPtr(pCreature));
  }

  public int PackCreatureIntoMessage() {
    int retVal = NWNXLibPINVOKE.CNWSPlayer_PackCreatureIntoMessage(swigCPtr);
    return retVal;
  }

  public CNWSObject GetGameObject() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_GetGameObject(swigCPtr);
    CNWSObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSObject(cPtr, false);
    return ret;
  }

  public void SetGameObject(CNWSObject pObject) {
    NWNXLibPINVOKE.CNWSPlayer_SetGameObject(swigCPtr, CNWSObject.getCPtr(pObject));
  }

  public CLastUpdateObject GetLastUpdateObject(uint oidLastUpdateObject) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_GetLastUpdateObject(swigCPtr, oidLastUpdateObject);
    CLastUpdateObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdateObject(cPtr, false);
    return ret;
  }

  public void SetAreaTransitionBMP(int nIndex, CExoString sString) {
    NWNXLibPINVOKE.CNWSPlayer_SetAreaTransitionBMP(swigCPtr, nIndex, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoString GetPlayerName() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CNWSPlayer_GetPlayerName(swigCPtr), true);
    return ret;
  }

  public void AllocateAreas(int nAreas) {
    NWNXLibPINVOKE.CNWSPlayer_AllocateAreas(swigCPtr, nAreas);
  }

  public int AddArea(uint oidArea) {
    int retVal = NWNXLibPINVOKE.CNWSPlayer_AddArea(swigCPtr, oidArea);
    return retVal;
  }

  public int GetIsAllowedToSave() {
    int retVal = NWNXLibPINVOKE.CNWSPlayer_GetIsAllowedToSave(swigCPtr);
    return retVal;
  }

  public void DropTURD() {
    NWNXLibPINVOKE.CNWSPlayer_DropTURD(swigCPtr);
  }

  public void EatTURD(CNWSPlayerTURD pTURD) {
    NWNXLibPINVOKE.CNWSPlayer_EatTURD(swigCPtr, CNWSPlayerTURD.getCPtr(pTURD));
  }

  public void CleanMyTURDs() {
    NWNXLibPINVOKE.CNWSPlayer_CleanMyTURDs(swigCPtr);
  }

  public CNWSPlayerLastUpdateObject CreateNewPlayerLastUpdateObject() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayer_CreateNewPlayerLastUpdateObject(swigCPtr);
    CNWSPlayerLastUpdateObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSPlayerLastUpdateObject(cPtr, false);
    return ret;
  }

  public void ClearPlayerLastUpdateObject() {
    NWNXLibPINVOKE.CNWSPlayer_ClearPlayerLastUpdateObject(swigCPtr);
  }

  public int PermittedToDisplayCharacterSheet(uint oidCreature) {
    int retVal = NWNXLibPINVOKE.CNWSPlayer_PermittedToDisplayCharacterSheet(swigCPtr, oidCreature);
    return retVal;
  }

  public void StoreCameraSettings() {
    NWNXLibPINVOKE.CNWSPlayer_StoreCameraSettings(swigCPtr);
  }

  public void RestoreCameraSettings() {
    NWNXLibPINVOKE.CNWSPlayer_RestoreCameraSettings(swigCPtr);
  }

  public int SatisfiesBuild(int nBuild, int nRevision, int nPostfix) {
    int retVal = NWNXLibPINVOKE.CNWSPlayer_SatisfiesBuild(swigCPtr, nBuild, nRevision, nPostfix);
    return retVal;
  }

  public int GetIsDM() {
    int retVal = NWNXLibPINVOKE.CNWSPlayer_GetIsDM(swigCPtr);
    return retVal;
  }

  public int GetIsPlayerDM() {
    int retVal = NWNXLibPINVOKE.CNWSPlayer_GetIsPlayerDM(swigCPtr);
    return retVal;
  }

  public void PossessCreature(uint oidTarget, byte possessType) {
    NWNXLibPINVOKE.CNWSPlayer_PossessCreature(swigCPtr, oidTarget, possessType);
  }

  public void HandleEchoResponse(void* pPayload, uint nSize) {
    NWNXLibPINVOKE.CNWSPlayer_HandleEchoResponse(swigCPtr, (global::System.IntPtr)pPayload, nSize);
  }

  public uint GetNetworkLatency(bool bSmoothed) {
    uint retVal = NWNXLibPINVOKE.CNWSPlayer_GetNetworkLatency__SWIG_0(swigCPtr, bSmoothed);
    return retVal;
  }

  public uint GetNetworkLatency() {
    uint retVal = NWNXLibPINVOKE.CNWSPlayer_GetNetworkLatency__SWIG_1(swigCPtr);
    return retVal;
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CNWSPlayer__Destructor(swigCPtr);
  }

}

}