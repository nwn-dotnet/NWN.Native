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

public unsafe class CNWSExpressionNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSExpressionNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSExpressionNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSExpressionNode() {
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
          NWNXLibPINVOKE.delete_CNWSExpressionNode(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSExpressionNode self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSExpressionNode FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSExpressionNode((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSExpressionNode FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSExpressionNode(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSExpressionNode other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSExpressionNode other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSExpressionNode left, CNWSExpressionNode right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSExpressionNode left, CNWSExpressionNode right) {
    return !Equals(left, right);
  }

  public int nTimesVisited {
    set {
      NWNXLibPINVOKE.CNWSExpressionNode_nTimesVisited_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSExpressionNode_nTimesVisited_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nType {
    set {
      NWNXLibPINVOKE.CNWSExpressionNode_m_nType_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSExpressionNode_m_nType_get(swigCPtr);
      return retVal;
    }

  }

  public int m_nPosition {
    set {
      NWNXLibPINVOKE.CNWSExpressionNode_m_nPosition_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.CNWSExpressionNode_m_nPosition_get(swigCPtr);
      return retVal;
    }

  }

  public CNWSExpressionNode m_pNext {
    set {
      NWNXLibPINVOKE.CNWSExpressionNode_m_pNext_set(swigCPtr, CNWSExpressionNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSExpressionNode_m_pNext_get(swigCPtr);
      CNWSExpressionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSExpressionNode(cPtr, false);
      return ret;
    } 
  }

  public CExoString m_sMatch {
    set {
      NWNXLibPINVOKE.CNWSExpressionNode_m_sMatch_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSExpressionNode_m_sMatch_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CNWSExpressionNode m_pAlternate {
    set {
      NWNXLibPINVOKE.CNWSExpressionNode_m_pAlternate_set(swigCPtr, CNWSExpressionNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSExpressionNode_m_pAlternate_get(swigCPtr);
      CNWSExpressionNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSExpressionNode(cPtr, false);
      return ret;
    } 
  }

  public CNWSExpressionNode() : this(NWNXLibPINVOKE.new_CNWSExpressionNode(), true) {
  }

  public void _Destructor() {
    NWNXLibPINVOKE.CNWSExpressionNode__Destructor(swigCPtr);
  }

}

}