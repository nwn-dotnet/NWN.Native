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

public unsafe class CNWSDialogLinkReply : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSDialogLinkReply(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSDialogLinkReply obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSDialogLinkReply() {
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
          NWNXLibPINVOKE.delete_CNWSDialogLinkReply(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSDialogLinkReply self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSDialogLinkReply FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSDialogLinkReply((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSDialogLinkReply FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSDialogLinkReply(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSDialogLinkReply other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSDialogLinkReply other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSDialogLinkReply left, CNWSDialogLinkReply right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSDialogLinkReply left, CNWSDialogLinkReply right) {
    return !Equals(left, right);
  }

  public CResRef m_sActive {
    set {
      NWNXLibPINVOKE.CNWSDialogLinkReply_m_sActive_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogLinkReply_m_sActive_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListScriptParam m_lConditionParams {
    set {
      NWNXLibPINVOKE.CNWSDialogLinkReply_m_lConditionParams_set(swigCPtr, CExoArrayListScriptParam.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogLinkReply_m_lConditionParams_get(swigCPtr);
      CExoArrayListScriptParam ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListScriptParam(cPtr, false);
      return ret;
    } 
  }

  public uint m_nIndex {
    set {
      NWNXLibPINVOKE.CNWSDialogLinkReply_m_nIndex_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDialogLinkReply_m_nIndex_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bDisplayInactive {
    set {
      NWNXLibPINVOKE.CNWSDialogLinkReply_m_bDisplayInactive_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSDialogLinkReply_m_bDisplayInactive_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSDialogLinkReply() : this(NWNXLibPINVOKE.new_CNWSDialogLinkReply(), true) {
  }

}

}