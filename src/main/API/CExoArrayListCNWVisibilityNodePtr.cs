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

public class CExoArrayListCNWVisibilityNodePtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListCNWVisibilityNodePtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListCNWVisibilityNodePtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListCNWVisibilityNodePtr() {
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
          NWNXLibPINVOKE.delete_CExoArrayListCNWVisibilityNodePtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_p_CNWVisibilityNode element {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr_element_set(swigCPtr, SWIGTYPE_p_p_CNWVisibilityNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr_element_get(swigCPtr);
      SWIGTYPE_p_p_CNWVisibilityNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CNWVisibilityNode(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListCNWVisibilityNodePtr(int s) : this(NWNXLibPINVOKE.new_CExoArrayListCNWVisibilityNodePtr__SWIG_0(s), true) {
  }

  public CExoArrayListCNWVisibilityNodePtr() : this(NWNXLibPINVOKE.new_CExoArrayListCNWVisibilityNodePtr__SWIG_1(), true) {
  }

  public CExoArrayListCNWVisibilityNodePtr(CExoArrayListCNWVisibilityNodePtr list) : this(NWNXLibPINVOKE.new_CExoArrayListCNWVisibilityNodePtr__SWIG_2(CExoArrayListCNWVisibilityNodePtr.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListCNWVisibilityNodePtr __Assign(CExoArrayListCNWVisibilityNodePtr list) {
    CExoArrayListCNWVisibilityNodePtr ret = new CExoArrayListCNWVisibilityNodePtr(NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr___Assign(swigCPtr, CExoArrayListCNWVisibilityNodePtr.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_p_CNWVisibilityNode __Index(int i) {
    SWIGTYPE_p_p_CNWVisibilityNode ret = new SWIGTYPE_p_p_CNWVisibilityNode(NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr___Index(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr_Pack(swigCPtr);
  }

  public void Add(CNWVisibilityNode t) {
    NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr_Add(swigCPtr, CNWVisibilityNode.getCPtr(t));
  }

  public void Insert(CNWVisibilityNode t, int k) {
    NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr_Insert(swigCPtr, CNWVisibilityNode.getCPtr(t), k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr_DelIndex(swigCPtr, i);
  }

  public SWIGTYPE_p_p_CNWVisibilityNode begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr_begin__SWIG_0(swigCPtr);
    SWIGTYPE_p_p_CNWVisibilityNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CNWVisibilityNode(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_p_CNWVisibilityNode end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListCNWVisibilityNodePtr_end__SWIG_0(swigCPtr);
    SWIGTYPE_p_p_CNWVisibilityNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_CNWVisibilityNode(cPtr, false);
    return ret;
  }

}

}