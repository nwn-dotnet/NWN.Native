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

public unsafe class CNWTileSurfaceMeshNodeFace : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWTileSurfaceMeshNodeFace(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWTileSurfaceMeshNodeFace obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWTileSurfaceMeshNodeFace() {
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
          NWNXLibPINVOKE.delete_CNWTileSurfaceMeshNodeFace(swigCPtr);
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

  public static unsafe implicit operator void*(CNWTileSurfaceMeshNodeFace self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWTileSurfaceMeshNodeFace FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWTileSurfaceMeshNodeFace((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWTileSurfaceMeshNodeFace FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWTileSurfaceMeshNodeFace(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWTileSurfaceMeshNodeFace other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWTileSurfaceMeshNodeFace other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWTileSurfaceMeshNodeFace left, CNWTileSurfaceMeshNodeFace right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWTileSurfaceMeshNodeFace left, CNWTileSurfaceMeshNodeFace right) {
    return !Equals(left, right);
  }

  public int* pnUselessPointer1 {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer1_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer1_get(swigCPtr);
      return retVal;
    }

  }

  public int* pnUselessPointer2 {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer2_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer2_get(swigCPtr);
      return retVal;
    }

  }

  public int* pnUselessPointer3 {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer3_set(swigCPtr, value);
    } 
    get {
      int* retVal = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_pnUselessPointer3_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<int> vertexindices {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_vertexindices_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_vertexindices_get(swigCPtr);
      NativeArray<int> retVal = new NativeArray<int>(arrayPtr, 3);

      return retVal; // int[3]
    }

  }

  public int s {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_s_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_s_get(swigCPtr);
      return retVal;
    }

  }

  public int matid {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_matid_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_matid_get(swigCPtr);
      return retVal;
    }

  }

  public NativeArray<int> neighbors {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_neighbors_set(swigCPtr, value);
    } 
    get {
      global::System.IntPtr arrayPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_neighbors_get(swigCPtr);
      NativeArray<int> retVal = new NativeArray<int>(arrayPtr, 3);

      return retVal; // int[3]
    }

  }

  public Vector normal {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_normal_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_normal_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public float dist {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_dist_set(swigCPtr, value);
    } 
    get {
      float retVal = NWNXLibPINVOKE.CNWTileSurfaceMeshNodeFace_dist_get(swigCPtr);
      return retVal;
    }

  }

  public CNWTileSurfaceMeshNodeFace() : this(NWNXLibPINVOKE.new_CNWTileSurfaceMeshNodeFace(), true) {
  }

}

}