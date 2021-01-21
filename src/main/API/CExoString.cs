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

public class CExoString : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CExoString(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CExoString obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CExoString() {
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
          NWNXLibPINVOKE.delete_CExoString(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public override string ToString() {
    return CStr();
  }

  public string m_sString {
    set {
      NWNXLibPINVOKE.CExoString_m_sString_set(swigCPtr, value);
    } 
    get {
      string ret = NWNXLibPINVOKE.CExoString_m_sString_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nBufferLength {
    set {
      NWNXLibPINVOKE.CExoString_m_nBufferLength_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CExoString_m_nBufferLength_get(swigCPtr);
      return ret;
    } 
  }

  public CExoString() : this(NWNXLibPINVOKE.new_CExoString__SWIG_0(), true) {
  }

  public CExoString(CResRef source) : this(NWNXLibPINVOKE.new_CExoString__SWIG_1(CResRef.getCPtr(source)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoString(string source) : this(NWNXLibPINVOKE.new_CExoString__SWIG_2(source), true) {
  }

  public CExoString(CExoString source) : this(NWNXLibPINVOKE.new_CExoString__SWIG_3(CExoString.getCPtr(source)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoString(string source, int length) : this(NWNXLibPINVOKE.new_CExoString__SWIG_4(source, length), true) {
  }

  public CExoString(int value) : this(NWNXLibPINVOKE.new_CExoString__SWIG_5(value), true) {
  }

  public CExoString(SWIGTYPE_p_std__string other) : this(NWNXLibPINVOKE.new_CExoString__SWIG_6(SWIGTYPE_p_std__string.getCPtr(other)), true) {
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoString __Assign(SWIGTYPE_p_std__string other) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString___Assign__SWIG_0(swigCPtr, SWIGTYPE_p_std__string.getCPtr(other)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoString __Assign(CExoString string_) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString___Assign__SWIG_1(swigCPtr, CExoString.getCPtr(string_)), false);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CExoString __Assign(string string_) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString___Assign__SWIG_2(swigCPtr, string_), false);
    return ret;
  }

  public int __Equals(CExoString string_) {
    int ret = NWNXLibPINVOKE.CExoString___Equals__SWIG_0(swigCPtr, CExoString.getCPtr(string_));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int __Equals(string string_) {
    int ret = NWNXLibPINVOKE.CExoString___Equals__SWIG_1(swigCPtr, string_);
    return ret;
  }

  public int __NotEquals(CExoString string_) {
    int ret = NWNXLibPINVOKE.CExoString___NotEquals__SWIG_0(swigCPtr, CExoString.getCPtr(string_));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int __NotEquals(string string_) {
    int ret = NWNXLibPINVOKE.CExoString___NotEquals__SWIG_1(swigCPtr, string_);
    return ret;
  }

  public int __LessThan(CExoString string_) {
    int ret = NWNXLibPINVOKE.CExoString___LessThan__SWIG_0(swigCPtr, CExoString.getCPtr(string_));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int __LessThan(string string_) {
    int ret = NWNXLibPINVOKE.CExoString___LessThan__SWIG_1(swigCPtr, string_);
    return ret;
  }

  public int __GreaterThan(CExoString string_) {
    int ret = NWNXLibPINVOKE.CExoString___GreaterThan__SWIG_0(swigCPtr, CExoString.getCPtr(string_));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int __GreaterThan(string string_) {
    int ret = NWNXLibPINVOKE.CExoString___GreaterThan__SWIG_1(swigCPtr, string_);
    return ret;
  }

  public int __LessThanOrEqual(CExoString string_) {
    int ret = NWNXLibPINVOKE.CExoString___LessThanOrEqual__SWIG_0(swigCPtr, CExoString.getCPtr(string_));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int __LessThanOrEqual(string string_) {
    int ret = NWNXLibPINVOKE.CExoString___LessThanOrEqual__SWIG_1(swigCPtr, string_);
    return ret;
  }

  public int __GreaterThanOrEqual(CExoString string_) {
    int ret = NWNXLibPINVOKE.CExoString___GreaterThanOrEqual__SWIG_0(swigCPtr, CExoString.getCPtr(string_));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int __GreaterThanOrEqual(string string_) {
    int ret = NWNXLibPINVOKE.CExoString___GreaterThanOrEqual__SWIG_1(swigCPtr, string_);
    return ret;
  }

  public char __Index(int position) {
    char ret = NWNXLibPINVOKE.CExoString___Index(swigCPtr, position);
    return ret;
  }

  public CExoString __Add(CExoString string_) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString___Add(swigCPtr, CExoString.getCPtr(string_)), true);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AsINT() {
    int ret = NWNXLibPINVOKE.CExoString_AsINT(swigCPtr);
    return ret;
  }

  public float AsFLOAT() {
    float ret = NWNXLibPINVOKE.CExoString_AsFLOAT(swigCPtr);
    return ret;
  }

  public string CStr() {
    string ret = NWNXLibPINVOKE.CExoString_CStr(swigCPtr);
    return ret;
  }

  public int Find(CExoString string_, int position) {
    int ret = NWNXLibPINVOKE.CExoString_Find__SWIG_0(swigCPtr, CExoString.getCPtr(string_), position);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Find(CExoString string_) {
    int ret = NWNXLibPINVOKE.CExoString_Find__SWIG_1(swigCPtr, CExoString.getCPtr(string_));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Find(char ch, int position) {
    int ret = NWNXLibPINVOKE.CExoString_Find__SWIG_2(swigCPtr, ch, position);
    return ret;
  }

  public int Find(char ch) {
    int ret = NWNXLibPINVOKE.CExoString_Find__SWIG_3(swigCPtr, ch);
    return ret;
  }

  public int FindNot(char ch, int position) {
    int ret = NWNXLibPINVOKE.CExoString_FindNot__SWIG_0(swigCPtr, ch, position);
    return ret;
  }

  public int FindNot(char ch) {
    int ret = NWNXLibPINVOKE.CExoString_FindNot__SWIG_1(swigCPtr, ch);
    return ret;
  }

  public void Format(string format) {
    NWNXLibPINVOKE.CExoString_Format(swigCPtr, format);
  }

  public int GetLength() {
    int ret = NWNXLibPINVOKE.CExoString_GetLength(swigCPtr);
    return ret;
  }

  public void Insert(CExoString string_, int position) {
    NWNXLibPINVOKE.CExoString_Insert(swigCPtr, CExoString.getCPtr(string_), position);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int IsEmpty() {
    int ret = NWNXLibPINVOKE.CExoString_IsEmpty(swigCPtr);
    return ret;
  }

  public CExoString Left(int count) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString_Left(swigCPtr, count), true);
    return ret;
  }

  public CExoString LowerCase() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString_LowerCase(swigCPtr), true);
    return ret;
  }

  public CExoString Right(int count) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString_Right(swigCPtr, count), true);
    return ret;
  }

  public CExoString SubString(int start, int count) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString_SubString__SWIG_0(swigCPtr, start, count), true);
    return ret;
  }

  public CExoString SubString(int start) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString_SubString__SWIG_1(swigCPtr, start), true);
    return ret;
  }

  public CExoString UpperCase() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString_UpperCase(swigCPtr), true);
    return ret;
  }

  public int CompareNoCase(CExoString sString) {
    int ret = NWNXLibPINVOKE.CExoString_CompareNoCase(swigCPtr, CExoString.getCPtr(sString));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int ComparePrefixNoCase(CExoString sString, int nSize) {
    int ret = NWNXLibPINVOKE.CExoString_ComparePrefixNoCase(swigCPtr, CExoString.getCPtr(sString), nSize);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int StripNonAlphaNumeric(int bFileName, int bEmail, int bMasterServer) {
    int ret = NWNXLibPINVOKE.CExoString_StripNonAlphaNumeric__SWIG_0(swigCPtr, bFileName, bEmail, bMasterServer);
    return ret;
  }

  public int StripNonAlphaNumeric(int bFileName, int bEmail) {
    int ret = NWNXLibPINVOKE.CExoString_StripNonAlphaNumeric__SWIG_1(swigCPtr, bFileName, bEmail);
    return ret;
  }

  public int StripNonAlphaNumeric(int bFileName) {
    int ret = NWNXLibPINVOKE.CExoString_StripNonAlphaNumeric__SWIG_2(swigCPtr, bFileName);
    return ret;
  }

  public int StripNonAlphaNumeric() {
    int ret = NWNXLibPINVOKE.CExoString_StripNonAlphaNumeric__SWIG_3(swigCPtr);
    return ret;
  }

  public CExoString Strip(bool leading, bool trailing, string set) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString_Strip__SWIG_0(swigCPtr, leading, trailing, set), true);
    return ret;
  }

  public CExoString Strip(bool leading, bool trailing) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString_Strip__SWIG_1(swigCPtr, leading, trailing), true);
    return ret;
  }

  public CExoString Strip(bool leading) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString_Strip__SWIG_2(swigCPtr, leading), true);
    return ret;
  }

  public CExoString Strip() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString_Strip__SWIG_3(swigCPtr), true);
    return ret;
  }

  public CExoString AsTAG() {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CExoString_AsTAG(swigCPtr), true);
    return ret;
  }

}

}