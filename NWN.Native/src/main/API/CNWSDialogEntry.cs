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

public unsafe class CNWSDialogEntry : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSDialogEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSDialogEntry obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSDialogEntry() {
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
          NWNXLibPINVOKE.delete_CNWSDialogEntry(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSDialogEntry self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSDialogEntry FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSDialogEntry((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSDialogEntry FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSDialogEntry(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSDialogEntry other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSDialogEntry other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSDialogEntry left, CNWSDialogEntry right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSDialogEntry left, CNWSDialogEntry right) {
    return !Equals(left, right);
  }

  public CExoString m_sSpeaker {
    set {
      NWNXLibPINVOKE.CNWSDialogEntry_m_sSpeaker_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogEntry_m_sSpeaker_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint m_nAnimation {
    set {
      NWNXLibPINVOKE.CNWSDialogEntry_m_nAnimation_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDialogEntry_m_nAnimation_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_bAnimationLoop {
    set {
      NWNXLibPINVOKE.CNWSDialogEntry_m_bAnimationLoop_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CNWSDialogEntry_m_bAnimationLoop_get(swigCPtr);
      return retVal;
    }

  }

  public CExoLocString m_sText {
    set {
      NWNXLibPINVOKE.CNWSDialogEntry_m_sText_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogEntry_m_sText_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public CNWSDialogLinkReply m_pReplies {
    set {
      NWNXLibPINVOKE.CNWSDialogEntry_m_pReplies_set(swigCPtr, CNWSDialogLinkReply.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogEntry_m_pReplies_get(swigCPtr);
      CNWSDialogLinkReply ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogLinkReply(cPtr, false);
      return ret;
    } 
  }

  public uint m_nReplies {
    set {
      NWNXLibPINVOKE.CNWSDialogEntry_m_nReplies_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDialogEntry_m_nReplies_get(swigCPtr);
      return retVal;
    }

  }

  public CResRef m_sScript {
    set {
      NWNXLibPINVOKE.CNWSDialogEntry_m_sScript_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogEntry_m_sScript_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CExoArrayListScriptParam m_lActionParams {
    set {
      NWNXLibPINVOKE.CNWSDialogEntry_m_lActionParams_set(swigCPtr, CExoArrayListScriptParam.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogEntry_m_lActionParams_get(swigCPtr);
      CExoArrayListScriptParam ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoArrayListScriptParam(cPtr, false);
      return ret;
    } 
  }

  public uint m_nDelay {
    set {
      NWNXLibPINVOKE.CNWSDialogEntry_m_nDelay_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDialogEntry_m_nDelay_get(swigCPtr);
      return retVal;
    }

  }

  public CResRef m_sSound {
    set {
      NWNXLibPINVOKE.CNWSDialogEntry_m_sSound_set(swigCPtr, CResRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogEntry_m_sSound_get(swigCPtr);
      CResRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new CResRef(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sQuestTag {
    set {
      NWNXLibPINVOKE.CNWSDialogEntry_m_sQuestTag_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogEntry_m_sQuestTag_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public uint m_nQuestId {
    set {
      NWNXLibPINVOKE.CNWSDialogEntry_m_nQuestId_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CNWSDialogEntry_m_nQuestId_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSDialogEntry() : this(NWNXLibPINVOKE.new_CNWSDialogEntry(), true) {
  }

}

}