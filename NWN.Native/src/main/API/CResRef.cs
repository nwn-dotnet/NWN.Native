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

public unsafe class CResRef : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CResRef(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResRef obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CResRef() {
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
          NWNXLibPINVOKE.delete_CResRef(swigCPtr);
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

  public static unsafe implicit operator void*(CResRef self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CResRef FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CResRef((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CResRef FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CResRef(pointer, memoryOwn) : null;
  }

  public bool Equals(CResRef other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResRef other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResRef left, CResRef right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResRef left, CResRef right) {
    return !Equals(left, right);
  }


  public CResRef(string source) : this(NWNX.NET.Native.StringUtils.GetNullTerminatedString(source)) {
  }

  /// <summary>
  /// Gets a C# string representing this ResRef (GetResRefStr())
  /// </summary>
  /// <returns>A C# string representing this ResRef.</returns>
  public override string ToString() {
    return NWNX.NET.Native.StringUtils.ReadNullTerminatedString(GetResRefStr());
  }
  public NativeArray<byte> m_resRef {
    set {
      NWNXLibPINVOKE.CResRef_m_resRef_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CResRef_m_resRef_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 16+1);

      return retVal; // byte[16+1]
    }

  }

  public CResRef() : this(NWNXLibPINVOKE.new_CResRef__SWIG_0(), true) {
  }

  public CResRef(NativeArray<byte> resRef) : this(NWNXLibPINVOKE.new_CResRef__SWIG_1(resRef), true) {
  }

  public CResRef(CExoString sName) : this(NWNXLibPINVOKE.new_CResRef__SWIG_2(CExoString.getCPtr(sName)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CResRef(byte* pName) : this(NWNXLibPINVOKE.new_CResRef__SWIG_3(pName), true) {
  }

  public CResRef(byte* pName, byte nLength) : this(NWNXLibPINVOKE.new_CResRef__SWIG_4(pName, nLength), true) {
  }

  public void CopyToString(CExoString str) {
    NWNXLibPINVOKE.CResRef_CopyToString__SWIG_0(swigCPtr, CExoString.getCPtr(str));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void CopyToString(byte* pStr) {
    NWNXLibPINVOKE.CResRef_CopyToString__SWIG_1(swigCPtr, pStr);
  }

  public int _OpNotEquals(CResRef cResRef) {
    int retVal = NWNXLibPINVOKE.CResRef__OpNotEquals__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int _OpNotEquals(CExoString sName) {
    int retVal = NWNXLibPINVOKE.CResRef__OpNotEquals__SWIG_1(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int _OpNotEquals(byte* pName) {
    int retVal = NWNXLibPINVOKE.CResRef__OpNotEquals__SWIG_2(swigCPtr, pName);
    return retVal;
  }

  public int _OpEquals(CResRef cResRef) {
    int retVal = NWNXLibPINVOKE.CResRef__OpEquals__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int _OpEquals(CExoString sName) {
    int retVal = NWNXLibPINVOKE.CResRef__OpEquals__SWIG_1(swigCPtr, CExoString.getCPtr(sName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int _OpEquals(byte* name) {
    int retVal = NWNXLibPINVOKE.CResRef__OpEquals__SWIG_2(swigCPtr, name);
    return retVal;
  }

  public CResRef _OpAssign(CResRef cResRef) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResRef__OpAssign__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CResRef _OpAssign(NativeArray<byte> resRef) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResRef__OpAssign__SWIG_1(swigCPtr, resRef), false);
    return ret;
  }

  public CResRef _OpAssign(CExoString sName) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResRef__OpAssign__SWIG_2(swigCPtr, CExoString.getCPtr(sName)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CResRef _OpAssign(byte* pName) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResRef__OpAssign__SWIG_3(swigCPtr, pName), false);
    return ret;
  }

  public CResRef _OpIncrement(CExoString sName) {
    CResRef ret = new CResRef(NWNXLibPINVOKE.CResRef__OpIncrement(swigCPtr, CExoString.getCPtr(sName)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public byte* GetResRef() {
    byte* retVal = NWNXLibPINVOKE.CResRef_GetResRef(swigCPtr);
    return retVal;
  }

  public byte* GetResRefStr() {
    byte* retVal = NWNXLibPINVOKE.CResRef_GetResRefStr(swigCPtr);
    return retVal;
  }

  public int IsValid() {
    int retVal = NWNXLibPINVOKE.CResRef_IsValid(swigCPtr);
    return retVal;
  }

  public byte GetLength() {
    byte retVal = NWNXLibPINVOKE.CResRef_GetLength(swigCPtr);
    return retVal;
  }

  public void InitFromCharArray(byte* str, int size) {
    NWNXLibPINVOKE.CResRef_InitFromCharArray__SWIG_0(swigCPtr, str, size);
  }

  public void InitFromCharArray(byte* str) {
    NWNXLibPINVOKE.CResRef_InitFromCharArray__SWIG_1(swigCPtr, str);
  }

  public CResRef(CResRef other) : this(NWNXLibPINVOKE.new_CResRef__SWIG_5(CResRef.getCPtr(other)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

}

}