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

public unsafe class CTlkTable : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CTlkTable(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CTlkTable obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CTlkTable() {
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
          NWNXLibPINVOKE.delete_CTlkTable(swigCPtr);
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

  public static unsafe implicit operator void*(CTlkTable self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CTlkTable FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CTlkTable((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CTlkTable FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CTlkTable(pointer, memoryOwn) : null;
  }

  public bool Equals(CTlkTable other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CTlkTable other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CTlkTable left, CTlkTable right) {
    return Equals(left, right);
  }

  public static bool operator !=(CTlkTable left, CTlkTable right) {
    return !Equals(left, right);
  }

  public CTlkFilePtrArray m_pTlkFile {
    set {
      NWNXLibPINVOKE.CTlkTable_m_pTlkFile_set(swigCPtr, CTlkFilePtrArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkTable_m_pTlkFile_get(swigCPtr);;
        CTlkFilePtrArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CTlkFilePtrArray(cPtr, false);
        return ret;
    }

  }

  public CTlkFilePtrArray m_pTlkFileAlternate {
    set {
      NWNXLibPINVOKE.CTlkTable_m_pTlkFileAlternate_set(swigCPtr, CTlkFilePtrArray.getCPtr(value));
    } 
    get {
        global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkTable_m_pTlkFileAlternate_get(swigCPtr);;
        CTlkFilePtrArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CTlkFilePtrArray(cPtr, false);
        return ret;
    }

  }

  public byte m_currentGender {
    set {
      NWNXLibPINVOKE.CTlkTable_m_currentGender_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CTlkTable_m_currentGender_get(swigCPtr);
      return retVal;
    }

  }

  public CTlkTableToken m_pTokens {
    set {
      NWNXLibPINVOKE.CTlkTable_m_pTokens_set(swigCPtr, CTlkTableToken.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkTable_m_pTokens_get(swigCPtr);
      CTlkTableToken ret = (cPtr == global::System.IntPtr.Zero) ? null : new CTlkTableToken(cPtr, false);
      return ret;
    } 
  }

  public uint m_nTokens {
    set {
      NWNXLibPINVOKE.CTlkTable_m_nTokens_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CTlkTable_m_nTokens_get(swigCPtr);
      return retVal;
    }

  }

  public CTlkTableTokenCustom m_pTokensCustom {
    set {
      NWNXLibPINVOKE.CTlkTable_m_pTokensCustom_set(swigCPtr, CTlkTableTokenCustom.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkTable_m_pTokensCustom_get(swigCPtr);
      CTlkTableTokenCustom ret = (cPtr == global::System.IntPtr.Zero) ? null : new CTlkTableTokenCustom(cPtr, false);
      return ret;
    } 
  }

  public uint m_nTokensCustom {
    set {
      NWNXLibPINVOKE.CTlkTable_m_nTokensCustom_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CTlkTable_m_nTokensCustom_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bRemove {
    set {
      NWNXLibPINVOKE.CTlkTable_m_bRemove_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CTlkTable_m_bRemove_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString m_sTlkFilePath {
    set {
      NWNXLibPINVOKE.CTlkTable_m_sTlkFilePath_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkTable_m_sTlkFilePath_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sTlkFileAlternatePath {
    set {
      NWNXLibPINVOKE.CTlkTable_m_sTlkFileAlternatePath_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkTable_m_sTlkFileAlternatePath_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public UnorderedMapUInt32CExoString m_overrides {
    set {
      NWNXLibPINVOKE.CTlkTable_m_overrides_set(swigCPtr, UnorderedMapUInt32CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CTlkTable_m_overrides_get(swigCPtr);
      UnorderedMapUInt32CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new UnorderedMapUInt32CExoString(cPtr, false);
      return ret;
    } 
  }

  public CTlkTable() : this(NWNXLibPINVOKE.new_CTlkTable(), true) {
  }

  public int OpenFile(CExoString sFilename) {
    int retVal = NWNXLibPINVOKE.CTlkTable_OpenFile__SWIG_0(swigCPtr, CExoString.getCPtr(sFilename));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public int OpenFileAlternate(CExoString sFileName) {
    int retVal = NWNXLibPINVOKE.CTlkTable_OpenFileAlternate(swigCPtr, CExoString.getCPtr(sFileName));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public void CloseFileAlternate() {
    NWNXLibPINVOKE.CTlkTable_CloseFileAlternate(swigCPtr);
  }

  public void SetCustomToken(int nCustomTokenNumber, CExoString sValue) {
    NWNXLibPINVOKE.CTlkTable_SetCustomToken(swigCPtr, nCustomTokenNumber, CExoString.getCPtr(sValue));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ClearCustomTokens() {
    NWNXLibPINVOKE.CTlkTable_ClearCustomTokens(swigCPtr);
  }

  public void ClearOverrides() {
    NWNXLibPINVOKE.CTlkTable_ClearOverrides(swigCPtr);
  }

  public void SetOverride(uint strId, CExoString ovr) {
    NWNXLibPINVOKE.CTlkTable_SetOverride(swigCPtr, strId, CExoString.getCPtr(ovr));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public byte* RemapFontName(byte* pFontName) {
    byte* retVal = NWNXLibPINVOKE.CTlkTable_RemapFontName(swigCPtr, pFontName);
    return retVal;
  }

  public void ParseStr(CExoString sText) {
    NWNXLibPINVOKE.CTlkTable_ParseStr(swigCPtr, CExoString.getCPtr(sText));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public CExoString GetSimpleString(uint strId) {
    CExoString ret = new CExoString(NWNXLibPINVOKE.CTlkTable_GetSimpleString(swigCPtr, strId), true);
    return ret;
  }

  public uint GetLanguageVersion() {
    uint retVal = NWNXLibPINVOKE.CTlkTable_GetLanguageVersion(swigCPtr);
    return retVal;
  }

  public int SetUseLargeDialogFont(int bUseIt) {
    int retVal = NWNXLibPINVOKE.CTlkTable_SetUseLargeDialogFont(swigCPtr, bUseIt);
    return retVal;
  }

  public int Reload() {
    int retVal = NWNXLibPINVOKE.CTlkTable_Reload(swigCPtr);
    return retVal;
  }

  public virtual void GetTokenValue(CTlkTableToken cTlkTableToken, CExoString sToken) {
    NWNXLibPINVOKE.CTlkTable_GetTokenValue(swigCPtr, CTlkTableToken.getCPtr(cTlkTableToken), CExoString.getCPtr(sToken));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
  }

  public int FetchInternal(uint strId, STR_RES strRes, int bParse) {
    int retVal = NWNXLibPINVOKE.CTlkTable_FetchInternal(swigCPtr, strId, STR_RES.getCPtr(strRes), bParse);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public void CloseFile(CTlkFilePtrArray pTlkFile) {
    NWNXLibPINVOKE.CTlkTable_CloseFile(swigCPtr, CTlkFilePtrArray.getCPtr(pTlkFile));
  }

  public int OpenFile(CExoString sFileName, CTlkFilePtrArray pTlkFile) {
    int retVal = NWNXLibPINVOKE.CTlkTable_OpenFile__SWIG_1(swigCPtr, CExoString.getCPtr(sFileName), CTlkFilePtrArray.getCPtr(pTlkFile));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return retVal;
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CTlkTable__Destructor(swigCPtr);
  }

}

}