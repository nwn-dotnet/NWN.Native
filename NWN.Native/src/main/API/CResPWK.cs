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

public unsafe class CResPWK : CRes {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CResPWK(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResPWK_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResPWK obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CResPWK(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CResPWK self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CResPWK FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CResPWK((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CResPWK FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CResPWK(pointer, memoryOwn) : null;
  }

  public bool Equals(CResPWK other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResPWK other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResPWK left, CResPWK right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResPWK left, CResPWK right) {
    return !Equals(left, right);
  }

  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CResPWK_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CResPWK_m_bLoaded_get(swigCPtr);
      return retVal;
    }

  }

  public uint m_nPWKNormalSize {
    set {
      NWNXLibPINVOKE.CResPWK_m_nPWKNormalSize_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CResPWK_m_nPWKNormalSize_get(swigCPtr);
      return retVal;
    }

  }

  public byte* m_pPWKData {
    set {
      NWNXLibPINVOKE.CResPWK_m_pPWKData_set(swigCPtr, value);
    } 
    get {
      byte* retVal = NWNXLibPINVOKE.CResPWK_m_pPWKData_get(swigCPtr);
      return retVal;
    }

  }

  public CResPWK() : this(NWNXLibPINVOKE.new_CResPWK(), true) {
  }

  public byte* GetPWKDataPtr() {
    byte* retVal = NWNXLibPINVOKE.CResPWK_GetPWKDataPtr(swigCPtr);
    return retVal;
  }

  public uint GetPWKSize() {
    uint retVal = NWNXLibPINVOKE.CResPWK_GetPWKSize(swigCPtr);
    return retVal;
  }

  public int IsLoaded() {
    int retVal = NWNXLibPINVOKE.CResPWK_IsLoaded(swigCPtr);
    return retVal;
  }

  public override int OnResourceFreed() {
    int retVal = NWNXLibPINVOKE.CResPWK_OnResourceFreed(swigCPtr);
    return retVal;
  }

  public override int OnResourceServiced() {
    int retVal = NWNXLibPINVOKE.CResPWK_OnResourceServiced(swigCPtr);
    return retVal;
  }

  public new void _Destructor() {
    NWNXLibPINVOKE.CResPWK__Destructor(swigCPtr);
  }

}

}