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

public unsafe class C2DA : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal C2DA(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(C2DA obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~C2DA() {
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
          NWNXLibPINVOKE.delete_C2DA(swigCPtr);
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

  public static unsafe implicit operator void*(C2DA self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe C2DA FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new C2DA((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static C2DA FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new C2DA(pointer, memoryOwn) : null;
  }

  public bool Equals(C2DA other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is C2DA other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(C2DA left, C2DA right) {
    return Equals(left, right);
  }

  public static bool operator !=(C2DA left, C2DA right) {
    return !Equals(left, right);
  }

  public CExoString m_sDefaultValue {
    set {
      NWNXLibPINVOKE.C2DA_m_sDefaultValue_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.C2DA_m_sDefaultValue_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_pRowLabel {
    set {
      NWNXLibPINVOKE.C2DA_m_pRowLabel_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.C2DA_m_pRowLabel_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_pColumnLabel {
    set {
      NWNXLibPINVOKE.C2DA_m_pColumnLabel_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.C2DA_m_pColumnLabel_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public void** m_pArrayData {
    set {
      NWNXLibPINVOKE.C2DA_m_pArrayData_set(swigCPtr, (global::System.IntPtr)value);
    } 
    get {
        global::System.IntPtr retVal = NWNXLibPINVOKE.C2DA_m_pArrayData_get(swigCPtr);
        return (void**)retVal;
    }

  }

  public int m_nNumRows {
    set {
      NWNXLibPINVOKE.C2DA_m_nNumRows_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.C2DA_m_nNumRows_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nNumColumns {
    set {
      NWNXLibPINVOKE.C2DA_m_nNumColumns_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.C2DA_m_nNumColumns_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.C2DA_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.C2DA_m_bLoaded_get(swigCPtr);
      return retVal;
    }

  }

  public C2DA(CResRef cResRef, int bSetAutoRequest) : this(NWNXLibPINVOKE.new_C2DA__SWIG_0(CResRef.getCPtr(cResRef), bSetAutoRequest), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public C2DA() : this(NWNXLibPINVOKE.new_C2DA__SWIG_1(), true) {
  }

  public int GetCExoStringEntry(int nRow, int nColumn, CExoString pString) {
    int retVal = NWNXLibPINVOKE.C2DA_GetCExoStringEntry__SWIG_0(swigCPtr, nRow, nColumn, CExoString.getCPtr(pString));
    return retVal;
  }

  public int GetCExoStringEntry(CExoString sRowLabel, CExoString sColumnLabel, CExoString pString) {
    int retVal = NWNXLibPINVOKE.C2DA_GetCExoStringEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sRowLabel), CExoString.getCPtr(sColumnLabel), CExoString.getCPtr(pString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetCExoStringEntry(int nRow, CExoString sColumnLabel, CExoString pString) {
    int retVal = NWNXLibPINVOKE.C2DA_GetCExoStringEntry__SWIG_2(swigCPtr, nRow, CExoString.getCPtr(sColumnLabel), CExoString.getCPtr(pString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetCExoStringEntry(CExoString sRowLabel, int nColumn, CExoString pString) {
    int retVal = NWNXLibPINVOKE.C2DA_GetCExoStringEntry__SWIG_3(swigCPtr, CExoString.getCPtr(sRowLabel), nColumn, CExoString.getCPtr(pString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SetCExoStringEntry(int nRow, int nColumn, CExoString sString) {
    int retVal = NWNXLibPINVOKE.C2DA_SetCExoStringEntry__SWIG_0(swigCPtr, nRow, nColumn, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SetCExoStringEntry(CExoString sRowLabel, CExoString sColumnLabel, CExoString sString) {
    int retVal = NWNXLibPINVOKE.C2DA_SetCExoStringEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sRowLabel), CExoString.getCPtr(sColumnLabel), CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SetCExoStringEntry(int nRow, CExoString sColumnLabel, CExoString sString) {
    int retVal = NWNXLibPINVOKE.C2DA_SetCExoStringEntry__SWIG_2(swigCPtr, nRow, CExoString.getCPtr(sColumnLabel), CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SetCExoStringEntry(CExoString sRowLabel, int nColumn, CExoString sString) {
    int retVal = NWNXLibPINVOKE.C2DA_SetCExoStringEntry__SWIG_3(swigCPtr, CExoString.getCPtr(sRowLabel), nColumn, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetFLOATEntry(int nRow, int nColumn, float* pFloat) {
    int retVal = NWNXLibPINVOKE.C2DA_GetFLOATEntry__SWIG_0(swigCPtr, nRow, nColumn, pFloat);
    return retVal;
  }

  public int GetFLOATEntry(CExoString sRowLabel, CExoString sColumnLabel, float* pFloat) {
    int retVal = NWNXLibPINVOKE.C2DA_GetFLOATEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sRowLabel), CExoString.getCPtr(sColumnLabel), pFloat);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetFLOATEntry(int nRow, CExoString sColumnLabel, float* pFloat) {
    int retVal = NWNXLibPINVOKE.C2DA_GetFLOATEntry__SWIG_2(swigCPtr, nRow, CExoString.getCPtr(sColumnLabel), pFloat);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetFLOATEntry(CExoString sRowLabel, int nColumn, float* pFloat) {
    int retVal = NWNXLibPINVOKE.C2DA_GetFLOATEntry__SWIG_3(swigCPtr, CExoString.getCPtr(sRowLabel), nColumn, pFloat);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SetFLOATEntry(int nRow, int nColumn, float fFloat) {
    int retVal = NWNXLibPINVOKE.C2DA_SetFLOATEntry__SWIG_0(swigCPtr, nRow, nColumn, fFloat);
    return retVal;
  }

  public int SetFLOATEntry(CExoString sRowLabel, CExoString sColumnLabel, float fFloat) {
    int retVal = NWNXLibPINVOKE.C2DA_SetFLOATEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sRowLabel), CExoString.getCPtr(sColumnLabel), fFloat);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SetFLOATEntry(int nRow, CExoString sColumnLabel, float fFloat) {
    int retVal = NWNXLibPINVOKE.C2DA_SetFLOATEntry__SWIG_2(swigCPtr, nRow, CExoString.getCPtr(sColumnLabel), fFloat);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SetFLOATEntry(CExoString sRowLabel, int nColumn, float fFloat) {
    int retVal = NWNXLibPINVOKE.C2DA_SetFLOATEntry__SWIG_3(swigCPtr, CExoString.getCPtr(sRowLabel), nColumn, fFloat);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetINTEntry(int nRow, int nColumn, int* pInt) {
    int retVal = NWNXLibPINVOKE.C2DA_GetINTEntry__SWIG_0(swigCPtr, nRow, nColumn, pInt);
    return retVal;
  }

  public int GetINTEntry(CExoString sRowLabel, CExoString sColumnLabel, int* pInt) {
    int retVal = NWNXLibPINVOKE.C2DA_GetINTEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sRowLabel), CExoString.getCPtr(sColumnLabel), pInt);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetINTEntry(int nRow, CExoString sColumnLabel, int* pInt) {
    int retVal = NWNXLibPINVOKE.C2DA_GetINTEntry__SWIG_2(swigCPtr, nRow, CExoString.getCPtr(sColumnLabel), pInt);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int GetINTEntry(CExoString sRowLabel, int nColumn, int* pInt) {
    int retVal = NWNXLibPINVOKE.C2DA_GetINTEntry__SWIG_3(swigCPtr, CExoString.getCPtr(sRowLabel), nColumn, pInt);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SetINTEntry(int nRow, int nColumn, int nInt) {
    int retVal = NWNXLibPINVOKE.C2DA_SetINTEntry__SWIG_0(swigCPtr, nRow, nColumn, nInt);
    return retVal;
  }

  public int SetINTEntry(CExoString sRowLabel, CExoString sColumnLabel, int nInt) {
    int retVal = NWNXLibPINVOKE.C2DA_SetINTEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sRowLabel), CExoString.getCPtr(sColumnLabel), nInt);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SetINTEntry(int nRow, CExoString sColumnLabel, int nInt) {
    int retVal = NWNXLibPINVOKE.C2DA_SetINTEntry__SWIG_2(swigCPtr, nRow, CExoString.getCPtr(sColumnLabel), nInt);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SetINTEntry(CExoString sRowLabel, int nColumn, int nInt) {
    int retVal = NWNXLibPINVOKE.C2DA_SetINTEntry__SWIG_3(swigCPtr, CExoString.getCPtr(sRowLabel), nColumn, nInt);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SetBlankEntry(int nRow, int nColumn) {
    int retVal = NWNXLibPINVOKE.C2DA_SetBlankEntry__SWIG_0(swigCPtr, nRow, nColumn);
    return retVal;
  }

  public int SetBlankEntry(CExoString sRowLabel, CExoString sColumnLabel) {
    int retVal = NWNXLibPINVOKE.C2DA_SetBlankEntry__SWIG_1(swigCPtr, CExoString.getCPtr(sRowLabel), CExoString.getCPtr(sColumnLabel));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SetBlankEntry(int nRow, CExoString sColumnLabel) {
    int retVal = NWNXLibPINVOKE.C2DA_SetBlankEntry__SWIG_2(swigCPtr, nRow, CExoString.getCPtr(sColumnLabel));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SetBlankEntry(CExoString sRowLabel, int nColumn) {
    int retVal = NWNXLibPINVOKE.C2DA_SetBlankEntry__SWIG_3(swigCPtr, CExoString.getCPtr(sRowLabel), nColumn);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int Load2DArray(int optional) {
    int retVal = NWNXLibPINVOKE.C2DA_Load2DArray__SWIG_0(swigCPtr, optional);
    return retVal;
  }

  public int Load2DArray() {
    int retVal = NWNXLibPINVOKE.C2DA_Load2DArray__SWIG_1(swigCPtr);
    return retVal;
  }

  public void Unload2DArray() {
    NWNXLibPINVOKE.C2DA_Unload2DArray(swigCPtr);
  }

  public int GetColumnIndex(CExoString sColumn) {
    int retVal = NWNXLibPINVOKE.C2DA_GetColumnIndex(swigCPtr, CExoString.getCPtr(sColumn));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public uint GetNextLineLength(byte* pBuffer, uint nBufferSize) {
    uint retVal = NWNXLibPINVOKE.C2DA_GetNextLineLength(swigCPtr, pBuffer, nBufferSize);
    return retVal;
  }

  public int GetNextToken(byte** pBuffer, uint* pBufferSize, byte* pToken, uint nMaxTokenSize, uint* pLeadingWhiteSpaceSize) {
    int retVal = NWNXLibPINVOKE.C2DA_GetNextToken(swigCPtr, (global::System.IntPtr)pBuffer, pBufferSize, pToken, nMaxTokenSize, pLeadingWhiteSpaceSize);
    return retVal;
  }

  public int GetRowIndex(CExoString sRow) {
    int retVal = NWNXLibPINVOKE.C2DA_GetRowIndex(swigCPtr, CExoString.getCPtr(sRow));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int SkipNewLines(byte** pBuffer, uint* pBufferSize) {
    int retVal = NWNXLibPINVOKE.C2DA_SkipNewLines(swigCPtr, (global::System.IntPtr)pBuffer, pBufferSize);
    return retVal;
  }

  public void _Destructor() {
    NWNXLibPINVOKE.C2DA__Destructor(swigCPtr);
  }

}

}