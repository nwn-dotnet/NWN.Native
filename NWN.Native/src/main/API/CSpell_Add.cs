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

public unsafe class CSpell_Add : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CSpell_Add(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CSpell_Add obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CSpell_Add() {
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
          NWNXLibPINVOKE.delete_CSpell_Add(swigCPtr);
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

  public static unsafe implicit operator void*(CSpell_Add self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CSpell_Add FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CSpell_Add((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CSpell_Add FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CSpell_Add(pointer, memoryOwn) : null;
  }

  public bool Equals(CSpell_Add other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CSpell_Add other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CSpell_Add left, CSpell_Add right) {
    return Equals(left, right);
  }

  public static bool operator !=(CSpell_Add left, CSpell_Add right) {
    return !Equals(left, right);
  }

  public uint m_nSpellID {
    set {
      NWNXLibPINVOKE.CSpell_Add_m_nSpellID_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.CSpell_Add_m_nSpellID_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bReadied {
    set {
      NWNXLibPINVOKE.CSpell_Add_m_bReadied_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CSpell_Add_m_bReadied_get(swigCPtr);
      return retVal;
    }

  }

  public int m_bDomainSpell {
    set {
      NWNXLibPINVOKE.CSpell_Add_m_bDomainSpell_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CSpell_Add_m_bDomainSpell_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nMetaType {
    set {
      NWNXLibPINVOKE.CSpell_Add_m_nMetaType_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CSpell_Add_m_nMetaType_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nSpellSlot {
    set {
      NWNXLibPINVOKE.CSpell_Add_m_nSpellSlot_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CSpell_Add_m_nSpellSlot_get(swigCPtr);
      return retVal;
    }

  }

  public byte m_nSpellLevel {
    set {
      NWNXLibPINVOKE.CSpell_Add_m_nSpellLevel_set(swigCPtr, value);
    } 
    get {
      byte retVal = NWNXLibPINVOKE.CSpell_Add_m_nSpellLevel_get(swigCPtr);
      return retVal;
    }

  }

  public CSpell_Add() : this(NWNXLibPINVOKE.new_CSpell_Add(), true) {
  }

}

}