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

public class CRes : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CRes(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CRes obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CRes() {
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
          NWNXLibPINVOKE.delete_CRes(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ushort m_nDemands {
    set {
      NWNXLibPINVOKE.CRes_m_nDemands_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CRes_m_nDemands_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nRequests {
    set {
      NWNXLibPINVOKE.CRes_m_nRequests_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CRes_m_nRequests_get(swigCPtr);
      return ret;
    } 
  }

  public RESID m_nID {
    set {
      NWNXLibPINVOKE.CRes_m_nID_set(swigCPtr, RESID.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CRes_m_nID_get(swigCPtr);
      RESID ret = (cPtr == global::System.IntPtr.Zero) ? null : new RESID(cPtr, false);
      return ret;
    } 
  }

  public uint m_status {
    set {
      NWNXLibPINVOKE.CRes_m_status_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CRes_m_status_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void m_pResource {
    set {
      NWNXLibPINVOKE.CRes_m_pResource_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CRes_m_pResource_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public CKeyTableEntry m_pKeyEntry {
    set {
      NWNXLibPINVOKE.CRes_m_pKeyEntry_set(swigCPtr, CKeyTableEntry.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CRes_m_pKeyEntry_get(swigCPtr);
      CKeyTableEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CKeyTableEntry(cPtr, false);
      return ret;
    } 
  }

  public uint m_nSize {
    set {
      NWNXLibPINVOKE.CRes_m_nSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CRes_m_nSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nRefs {
    set {
      NWNXLibPINVOKE.CRes_m_nRefs_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CRes_m_nRefs_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bAllocHeaderData {
    set {
      NWNXLibPINVOKE.CRes_m_bAllocHeaderData_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CRes_m_bAllocHeaderData_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bAllocTrailingData {
    set {
      NWNXLibPINVOKE.CRes_m_bAllocTrailingData_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CRes_m_bAllocTrailingData_get(swigCPtr);
      return ret;
    } 
  }

  public CExoLinkedListNode m_pos {
    set {
      NWNXLibPINVOKE.CRes_m_pos_set(swigCPtr, CExoLinkedListNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CRes_m_pos_get(swigCPtr);
      CExoLinkedListNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLinkedListNode(cPtr, false);
      return ret;
    } 
  }

  public int m_bAllowCaching {
    set {
      NWNXLibPINVOKE.CRes_m_bAllowCaching_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CRes_m_bAllowCaching_get(swigCPtr);
      return ret;
    } 
  }

  public CRes() : this(NWNXLibPINVOKE.new_CRes__SWIG_0(), true) {
  }

  public CRes(RESID nNewID) : this(NWNXLibPINVOKE.new_CRes__SWIG_1(RESID.getCPtr(nNewID)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int CancelRequest() {
    int ret = NWNXLibPINVOKE.CRes_CancelRequest(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_void Demand() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CRes_Demand(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public int ReadRaw(int nSize, string pBuffer) {
    int ret = NWNXLibPINVOKE.CRes_ReadRaw(swigCPtr, nSize, pBuffer);
    return ret;
  }

  public void Dump(int bRemove) {
    NWNXLibPINVOKE.CRes_Dump__SWIG_0(swigCPtr, bRemove);
  }

  public void Dump() {
    NWNXLibPINVOKE.CRes_Dump__SWIG_1(swigCPtr);
  }

  public SWIGTYPE_p_void GetData() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CRes_GetData(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public int GetDemands() {
    int ret = NWNXLibPINVOKE.CRes_GetDemands(swigCPtr);
    return ret;
  }

  public virtual int GetFixedResourceSize() {
    int ret = NWNXLibPINVOKE.CRes_GetFixedResourceSize(swigCPtr);
    return ret;
  }

  public virtual int GetFixedResourceDataOffset() {
    int ret = NWNXLibPINVOKE.CRes_GetFixedResourceDataOffset(swigCPtr);
    return ret;
  }

  public int GetRequests() {
    int ret = NWNXLibPINVOKE.CRes_GetRequests(swigCPtr);
    return ret;
  }

  public RESID GetID() {
    RESID ret = new RESID(NWNXLibPINVOKE.CRes_GetID(swigCPtr), true);
    return ret;
  }

  public int GetSize() {
    int ret = NWNXLibPINVOKE.CRes_GetSize(swigCPtr);
    return ret;
  }

  public virtual int OnResourceFreed() {
    int ret = NWNXLibPINVOKE.CRes_OnResourceFreed(swigCPtr);
    return ret;
  }

  public virtual int OnResourceServiced() {
    int ret = NWNXLibPINVOKE.CRes_OnResourceServiced(swigCPtr);
    return ret;
  }

  public int Release() {
    int ret = NWNXLibPINVOKE.CRes_Release(swigCPtr);
    return ret;
  }

  public int Request() {
    int ret = NWNXLibPINVOKE.CRes_Request(swigCPtr);
    return ret;
  }

  public void SetID(RESID nNewID) {
    NWNXLibPINVOKE.CRes_SetID(swigCPtr, RESID.getCPtr(nNewID));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}