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

public unsafe class CPathfindInfoIntraTileSuccessors : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CPathfindInfoIntraTileSuccessors(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CPathfindInfoIntraTileSuccessors obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CPathfindInfoIntraTileSuccessors() {
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
          NWNXLibPINVOKE.delete_CPathfindInfoIntraTileSuccessors(swigCPtr);
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

  public static unsafe implicit operator void*(CPathfindInfoIntraTileSuccessors self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CPathfindInfoIntraTileSuccessors FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CPathfindInfoIntraTileSuccessors((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CPathfindInfoIntraTileSuccessors FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CPathfindInfoIntraTileSuccessors(pointer, memoryOwn) : null;
  }

  public bool Equals(CPathfindInfoIntraTileSuccessors other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CPathfindInfoIntraTileSuccessors other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CPathfindInfoIntraTileSuccessors left, CPathfindInfoIntraTileSuccessors right) {
    return Equals(left, right);
  }

  public static bool operator !=(CPathfindInfoIntraTileSuccessors left, CPathfindInfoIntraTileSuccessors right) {
    return !Equals(left, right);
  }

  public float fXTransit {
    set {
      NWNXLibPINVOKE.CPathfindInfoIntraTileSuccessors_fXTransit_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CPathfindInfoIntraTileSuccessors_fXTransit_get(swigCPtr);
      return retVal;
    }

  }

  public float fYTransit {
    set {
      NWNXLibPINVOKE.CPathfindInfoIntraTileSuccessors_fYTransit_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CPathfindInfoIntraTileSuccessors_fYTransit_get(swigCPtr);
      return retVal;
    }

  }

  public float fNewX {
    set {
      NWNXLibPINVOKE.CPathfindInfoIntraTileSuccessors_fNewX_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CPathfindInfoIntraTileSuccessors_fNewX_get(swigCPtr);
      return retVal;
    }

  }

  public float fNewY {
    set {
      NWNXLibPINVOKE.CPathfindInfoIntraTileSuccessors_fNewY_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CPathfindInfoIntraTileSuccessors_fNewY_get(swigCPtr);
      return retVal;
    }

  }

  public float fNewDistance {
    set {
      NWNXLibPINVOKE.CPathfindInfoIntraTileSuccessors_fNewDistance_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CPathfindInfoIntraTileSuccessors_fNewDistance_get(swigCPtr);
      return retVal;
    }

  }

  public int nNewTriangle {
    set {
      NWNXLibPINVOKE.CPathfindInfoIntraTileSuccessors_nNewTriangle_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CPathfindInfoIntraTileSuccessors_nNewTriangle_get(swigCPtr);
      return retVal;
    }

  }

  public CPathfindInfoIntraTileSuccessors() : this(NWNXLibPINVOKE.new_CPathfindInfoIntraTileSuccessors(), true) {
  }

}

}