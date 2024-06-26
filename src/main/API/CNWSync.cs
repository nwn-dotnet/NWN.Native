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

public unsafe class CNWSync : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSync(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSync obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSync() {
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
          NWNXLibPINVOKE.delete_CNWSync(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSync self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSync FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSync((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSync FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSync(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSync other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSync other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSync left, CNWSync right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSync left, CNWSync right) {
    return !Equals(left, right);
  }

  public void* m_internal {
    set {
      NWNXLibPINVOKE.CNWSync_m_internal_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.CNWSync_m_internal_get(swigCPtr);
        return (void*)retVal;
    }

  }

  public byte* m_tmp1 {
    set {
      NWNXLibPINVOKE.CNWSync_m_tmp1_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CNWSync_m_tmp1_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_tmp2 {
    set {
      NWNXLibPINVOKE.CNWSync_m_tmp2_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSync_m_tmp2_get(swigCPtr);
      return retVal;
    }

  }

  public unsafe class ManifestMetaData : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal ManifestMetaData(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ManifestMetaData obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~ManifestMetaData() {
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
            NWNXLibPINVOKE.delete_CNWSync_ManifestMetaData(swigCPtr);
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
  
    public static unsafe implicit operator void*(ManifestMetaData self) {
      return (void*)self.swigCPtr.Handle;
    }
  
    public static unsafe ManifestMetaData FromPointer(void* pointer, bool memoryOwn = false) {
      return pointer != null ? new ManifestMetaData((global::System.IntPtr)pointer, memoryOwn) : null;
    }
  
    public static ManifestMetaData FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
      return pointer != global::System.IntPtr.Zero ? new ManifestMetaData(pointer, memoryOwn) : null;
    }
  
    public bool Equals(ManifestMetaData other) {
      if (ReferenceEquals(null, other)) {
        return false;
      }
  
      if (ReferenceEquals(this, other)) {
        return true;
      }
  
      return Pointer.Equals(other.Pointer);
    }
  
    public override bool Equals(object obj) {
      return ReferenceEquals(this, obj) || obj is ManifestMetaData other && Equals(other);
    }
  
    public override int GetHashCode() {
      return swigCPtr.Handle.GetHashCode();
    }
  
    public static bool operator ==(ManifestMetaData left, ManifestMetaData right) {
      return Equals(left, right);
    }
  
    public static bool operator !=(ManifestMetaData left, ManifestMetaData right) {
      return !Equals(left, right);
    }
  
    public SHA1 m_sha1 {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_sha1_set(swigCPtr, SHA1.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_sha1_get(swigCPtr);
        SHA1 ret = (cPtr == global::System.IntPtr.Zero) ? null : new SHA1(cPtr, false);
        return ret;
      } 
    }
  
    public uint m_hashTreeDepth {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_hashTreeDepth_set(swigCPtr, value);
      } 
      get {
        uint retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_hashTreeDepth_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public CExoString m_moduleName {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_moduleName_set(swigCPtr, CExoString.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_moduleName_get(swigCPtr);
        CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
        return ret;
      } 
    }
  
    public CExoString m_description {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_description_set(swigCPtr, CExoString.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_description_get(swigCPtr);
        CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
        return ret;
      } 
    }
  
    public CUUID m_uuid {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_uuid_set(swigCPtr, CUUID.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_uuid_get(swigCPtr);
        CUUID ret = (cPtr == global::System.IntPtr.Zero) ? null : new CUUID(cPtr, false);
        return ret;
      } 
    }
  
    public uint m_groupId {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_groupId_set(swigCPtr, value);
      } 
      get {
        uint retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_groupId_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public bool m_includesModuleContents {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_includesModuleContents_set(swigCPtr, value);
      } 
      get {
        bool ret = NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_includesModuleContents_get(swigCPtr);
        return ret;
      } 
    }
  
    public bool m_includesClientContents {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_includesClientContents_set(swigCPtr, value);
      } 
      get {
        bool ret = NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_includesClientContents_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint m_totalBytes {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_totalBytes_set(swigCPtr, value);
      } 
      get {
        uint retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_totalBytes_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public uint m_totalFiles {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_totalFiles_set(swigCPtr, value);
      } 
      get {
        uint retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_totalFiles_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public uint m_createdAt {
      set {
        NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_createdAt_set(swigCPtr, value);
      } 
      get {
        uint retVal = NWNXLibPINVOKE.CNWSync_ManifestMetaData_m_createdAt_get(swigCPtr);
        return retVal;
      }
  
    }
  
    public ManifestMetaData() : this(NWNXLibPINVOKE.new_CNWSync_ManifestMetaData(), true) {
    }
  
  }

  public CNWSync() : this(NWNXLibPINVOKE.new_CNWSync(), true) {
  }

}

}
