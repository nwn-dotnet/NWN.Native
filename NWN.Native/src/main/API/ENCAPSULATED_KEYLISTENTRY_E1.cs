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

public unsafe class ENCAPSULATED_KEYLISTENTRY_E1 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ENCAPSULATED_KEYLISTENTRY_E1(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ENCAPSULATED_KEYLISTENTRY_E1 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ENCAPSULATED_KEYLISTENTRY_E1() {
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
          NWNXLibPINVOKE.delete_ENCAPSULATED_KEYLISTENTRY_E1(swigCPtr);
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

  public static unsafe implicit operator void*(ENCAPSULATED_KEYLISTENTRY_E1 self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe ENCAPSULATED_KEYLISTENTRY_E1 FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new ENCAPSULATED_KEYLISTENTRY_E1((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static ENCAPSULATED_KEYLISTENTRY_E1 FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new ENCAPSULATED_KEYLISTENTRY_E1(pointer, memoryOwn) : null;
  }

  public bool Equals(ENCAPSULATED_KEYLISTENTRY_E1 other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is ENCAPSULATED_KEYLISTENTRY_E1 other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(ENCAPSULATED_KEYLISTENTRY_E1 left, ENCAPSULATED_KEYLISTENTRY_E1 right) {
    return Equals(left, right);
  }

  public static bool operator !=(ENCAPSULATED_KEYLISTENTRY_E1 left, ENCAPSULATED_KEYLISTENTRY_E1 right) {
    return !Equals(left, right);
  }

  public NativeArray<byte> resRef {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_E1_resRef_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_E1_resRef_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 16);

      return retVal; // byte[16]
    }

  }

  public uint nID {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_E1_nID_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_E1_nID_get(swigCPtr);
      return retVal;
    }

  }

  public ushort nType {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_E1_nType_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_E1_nType_get(swigCPtr);
      return retVal;
    }

  }

  public ushort unused {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_E1_unused_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_E1_unused_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<byte> sSha1 {
    set {
      NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_E1_sSha1_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.ENCAPSULATED_KEYLISTENTRY_E1_sSha1_get(swigCPtr);
      NativeArray<byte> retVal = new NativeArray<byte>(arrayPtr, 20);

      return retVal; // byte[20]
    }

  }

  public ENCAPSULATED_KEYLISTENTRY_E1() : this(NWNXLibPINVOKE.new_ENCAPSULATED_KEYLISTENTRY_E1(), true) {
  }

}

}