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

public unsafe class CExoLinkedListCLastUpdateObject : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoLinkedListCLastUpdateObject(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoLinkedListCLastUpdateObject obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoLinkedListCLastUpdateObject() {
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
          NWNXLibPINVOKE.delete_CExoLinkedListCLastUpdateObject(swigCPtr);
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

  public static unsafe implicit operator void*(CExoLinkedListCLastUpdateObject self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoLinkedListCLastUpdateObject FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoLinkedListCLastUpdateObject((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoLinkedListCLastUpdateObject FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoLinkedListCLastUpdateObject(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoLinkedListCLastUpdateObject other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoLinkedListCLastUpdateObject other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoLinkedListCLastUpdateObject left, CExoLinkedListCLastUpdateObject right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoLinkedListCLastUpdateObject left, CExoLinkedListCLastUpdateObject right) {
    return !Equals(left, right);
  }

  public CExoLinkedListInternal m_pcExoLinkedListInternal {
    set {
      NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_m_pcExoLinkedListInternal_set(swigCPtr, CExoLinkedListInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_m_pcExoLinkedListInternal_get(swigCPtr);
      CExoLinkedListInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoLinkedListCLastUpdateObject() : this(NWNXLibPINVOKE.new_CExoLinkedListCLastUpdateObject(), true) {
  }

  public CExoLinkedListNode AddHead(CLastUpdateObject Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_AddHead(swigCPtr, CLastUpdateObject.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddTail(CLastUpdateObject Object) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_AddTail(swigCPtr, CLastUpdateObject.getCPtr(Object));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddAfter(CLastUpdateObject Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_AddAfter(swigCPtr, CLastUpdateObject.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode AddBefore(CLastUpdateObject Object, CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_AddBefore(swigCPtr, CLastUpdateObject.getCPtr(Object), CExoLinkedListNode.getCPtr(Position));
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public uint Count() {
    uint retVal = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_Count(swigCPtr);
    return retVal;
  }

  public CLastUpdateObject GetAtPos(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_GetAtPos(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CLastUpdateObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdateObject(cPtr, false);
    return ret;
  }

  public CLastUpdateObject GetHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_GetHead(swigCPtr);
    CLastUpdateObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdateObject(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetHeadPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_GetHeadPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public CLastUpdateObject GetNext(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_GetNext(swigCPtr, (global::System.IntPtr)Position);
    CLastUpdateObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdateObject(cPtr, false);
    return ret;
  }

  public CLastUpdateObject GetPrev(void** Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_GetPrev(swigCPtr, (global::System.IntPtr)Position);
    CLastUpdateObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdateObject(cPtr, false);
    return ret;
  }

  public CLastUpdateObject GetTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_GetTail(swigCPtr);
    CLastUpdateObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdateObject(cPtr, false);
    return ret;
  }

  public CExoLinkedListNode GetTailPos() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_GetTailPos(swigCPtr);
    CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
    return ret;
  }

  public int IsEmpty() {
    int retVal = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_IsEmpty(swigCPtr);
    return retVal;
  }

  public CLastUpdateObject RemoveHead() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_RemoveHead(swigCPtr);
    CLastUpdateObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdateObject(cPtr, false);
    return ret;
  }

  public CLastUpdateObject RemoveTail() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_RemoveTail(swigCPtr);
    CLastUpdateObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdateObject(cPtr, false);
    return ret;
  }

  public CLastUpdateObject Remove(CExoLinkedListNode Position) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoLinkedListCLastUpdateObject_Remove(swigCPtr, CExoLinkedListNode.getCPtr(Position));
    CLastUpdateObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new CLastUpdateObject(cPtr, false);
    return ret;
  }

}

}