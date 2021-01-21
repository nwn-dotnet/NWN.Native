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

public class CExoArrayListObjectId : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoArrayListObjectId(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoArrayListObjectId obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoArrayListObjectId() {
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
          NWNXLibPINVOKE.delete_CExoArrayListObjectId(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_unsigned_int element {
    set {
      NWNXLibPINVOKE.CExoArrayListObjectId_element_set(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListObjectId_element_get(swigCPtr);
      SWIGTYPE_p_unsigned_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(cPtr, false);
      return ret;
    } 
  }

  public int num {
    set {
      NWNXLibPINVOKE.CExoArrayListObjectId_num_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListObjectId_num_get(swigCPtr);
      return ret;
    } 
  }

  public int array_size {
    set {
      NWNXLibPINVOKE.CExoArrayListObjectId_array_size_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CExoArrayListObjectId_array_size_get(swigCPtr);
      return ret;
    } 
  }

  public CExoArrayListObjectId(int s) : this(NWNXLibPINVOKE.new_CExoArrayListObjectId__SWIG_0(s), true) {
  }

  public CExoArrayListObjectId() : this(NWNXLibPINVOKE.new_CExoArrayListObjectId__SWIG_1(), true) {
  }

  public CExoArrayListObjectId(CExoArrayListObjectId list) : this(NWNXLibPINVOKE.new_CExoArrayListObjectId__SWIG_2(CExoArrayListObjectId.getCPtr(list)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoArrayListObjectId __Assign(CExoArrayListObjectId list) {
    CExoArrayListObjectId ret = new CExoArrayListObjectId(NWNXLibPINVOKE.CExoArrayListObjectId___Assign(swigCPtr, CExoArrayListObjectId.getCPtr(list)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_unsigned_int __Index(int i) {
    SWIGTYPE_p_unsigned_int ret = new SWIGTYPE_p_unsigned_int(NWNXLibPINVOKE.CExoArrayListObjectId___Index(swigCPtr, i), false);
    return ret;
  }

  public void Allocate(int s) {
    NWNXLibPINVOKE.CExoArrayListObjectId_Allocate(swigCPtr, s);
  }

  public void SetSize(int s) {
    NWNXLibPINVOKE.CExoArrayListObjectId_SetSize(swigCPtr, s);
  }

  public void Pack() {
    NWNXLibPINVOKE.CExoArrayListObjectId_Pack(swigCPtr);
  }

  public void Add(uint t) {
    NWNXLibPINVOKE.CExoArrayListObjectId_Add(swigCPtr, t);
  }

  public void Insert(uint t, int k) {
    NWNXLibPINVOKE.CExoArrayListObjectId_Insert(swigCPtr, t, k);
  }

  public void DelIndex(int i) {
    NWNXLibPINVOKE.CExoArrayListObjectId_DelIndex(swigCPtr, i);
  }

  public SWIGTYPE_p_unsigned_int begin() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListObjectId_begin__SWIG_0(swigCPtr);
    SWIGTYPE_p_unsigned_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_unsigned_int end() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoArrayListObjectId_end__SWIG_0(swigCPtr);
    SWIGTYPE_p_unsigned_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(cPtr, false);
    return ret;
  }

}

}