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

public unsafe class CExoDebug : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoDebug(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoDebug obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoDebug() {
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
          NWNXLibPINVOKE.delete_CExoDebug(swigCPtr);
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

  public static unsafe implicit operator void*(CExoDebug self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CExoDebug FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CExoDebug((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CExoDebug FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CExoDebug(pointer, memoryOwn) : null;
  }

  public bool Equals(CExoDebug other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CExoDebug other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CExoDebug left, CExoDebug right) {
    return Equals(left, right);
  }

  public static bool operator !=(CExoDebug left, CExoDebug right) {
    return !Equals(left, right);
  }

  public CExoString m_sLogString {
    set {
      NWNXLibPINVOKE.CExoDebug_m_sLogString_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoDebug_m_sLogString_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoDebugInternal m_pcExoDebugInternal {
    set {
      NWNXLibPINVOKE.CExoDebug_m_pcExoDebugInternal_set(swigCPtr, CExoDebugInternal.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CExoDebug_m_pcExoDebugInternal_get(swigCPtr);
      CExoDebugInternal ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoDebugInternal(cPtr, false);
      return ret;
    } 
  }

  public CExoDebug() : this(NWNXLibPINVOKE.new_CExoDebug(), true) {
  }

  public void Assert(int nLineNumber, byte* sFileName, byte* sComment) {
    NWNXLibPINVOKE.CExoDebug_Assert__SWIG_0(swigCPtr, nLineNumber, sFileName, sComment);
  }

  public void Assert(int nLineNumber, byte* sFileName) {
    NWNXLibPINVOKE.CExoDebug_Assert__SWIG_1(swigCPtr, nLineNumber, sFileName);
  }

  public void CloseLogFiles() {
    NWNXLibPINVOKE.CExoDebug_CloseLogFiles(swigCPtr);
  }

  public void FlushLogFile() {
    NWNXLibPINVOKE.CExoDebug_FlushLogFile(swigCPtr);
  }

  public void OpenLogFiles(CExoString sExecutableName, int nMaxLogSize) {
    NWNXLibPINVOKE.CExoDebug_OpenLogFiles__SWIG_0(swigCPtr, CExoString.getCPtr(sExecutableName), nMaxLogSize);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void OpenLogFiles(CExoString sExecutableName) {
    NWNXLibPINVOKE.CExoDebug_OpenLogFiles__SWIG_1(swigCPtr, CExoString.getCPtr(sExecutableName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Warning(int nLineNumber, byte* sFileName, byte* sComment, byte* sCond, byte* sAction) {
    NWNXLibPINVOKE.CExoDebug_Warning__SWIG_0(swigCPtr, nLineNumber, sFileName, sComment, sCond, sAction);
  }

  public void Warning(int nLineNumber, byte* sFileName, byte* sComment, byte* sCond) {
    NWNXLibPINVOKE.CExoDebug_Warning__SWIG_1(swigCPtr, nLineNumber, sFileName, sComment, sCond);
  }

  public void Warning(int nLineNumber, byte* sFileName, byte* sComment) {
    NWNXLibPINVOKE.CExoDebug_Warning__SWIG_2(swigCPtr, nLineNumber, sFileName, sComment);
  }

  public void Warning(int nLineNumber, byte* sFileName) {
    NWNXLibPINVOKE.CExoDebug_Warning__SWIG_3(swigCPtr, nLineNumber, sFileName);
  }

  public void WriteToLogFile(CExoString sLogString) {
    NWNXLibPINVOKE.CExoDebug_WriteToLogFile(swigCPtr, CExoString.getCPtr(sLogString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetCurrentTimestamp(CExoString sTimestamp) {
    NWNXLibPINVOKE.CExoDebug_GetCurrentTimestamp(swigCPtr, CExoString.getCPtr(sTimestamp));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRotateLogFile(int bEnable) {
    NWNXLibPINVOKE.CExoDebug_SetRotateLogFile(swigCPtr, bEnable);
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CExoDebug__Destructor(swigCPtr);
  }

}

}
