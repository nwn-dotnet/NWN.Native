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

public unsafe class CERFKey : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CERFKey(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CERFKey obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CERFKey() {
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
          NWNXLibPINVOKE.delete_CERFKey(swigCPtr);
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

  public static unsafe implicit operator void*(CERFKey self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CERFKey FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CERFKey((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CERFKey FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CERFKey(pointer, memoryOwn) : null;
  }

  public bool Equals(CERFKey other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CERFKey other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CERFKey left, CERFKey right) {
    return Equals(left, right);
  }

  public static bool operator !=(CERFKey left, CERFKey right) {
    return !Equals(left, right);
  }

  public NativeArray<byte> m_sName {
    set {
      NWNXLibPINVOKE.CERFKey_m_sName_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CERFKey_m_sName_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 16);

      return retVal; // byte[16]
    }

  }

  public uint m_nID {
    set {
      NWNXLibPINVOKE.CERFKey_m_nID_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CERFKey_m_nID_get(swigCPtr);
      return retVal;
    }

  }

  public ushort m_nType {
    set {
      NWNXLibPINVOKE.CERFKey_m_nType_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CERFKey_m_nType_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<byte> m_nUnused {
    set {
      NWNXLibPINVOKE.CERFKey_m_nUnused_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CERFKey_m_nUnused_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 2);

      return retVal; // byte[2]
    }

  }

  public CERFKey() : this(NWNXLibPINVOKE.new_CERFKey(), true) {
  }

  public void SetName(CExoString sData) {
    NWNXLibPINVOKE.CERFKey_SetName(swigCPtr, CExoString.getCPtr(sData));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int Read() {
    int retVal = NWNXLibPINVOKE.CERFKey_Read(swigCPtr);
    return retVal;
  }

  public int Reset() {
    int retVal = NWNXLibPINVOKE.CERFKey_Reset(swigCPtr);
    return retVal;
  }

  public int Write(CExoFile cOutFile) {
    int retVal = NWNXLibPINVOKE.CERFKey_Write(swigCPtr, CExoFile.getCPtr(cOutFile));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CERFKey__Destructor(swigCPtr);
  }

}

}