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

public unsafe class Event : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Event(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Event obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Event() {
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
          NWNXLibPINVOKE.delete_Event(swigCPtr);
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

  public static unsafe implicit operator void*(Event self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe Event FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new Event((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static Event FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new Event(pointer, memoryOwn) : null;
  }

  public bool Equals(Event other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is Event other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(Event left, Event right) {
    return Equals(left, right);
  }

  public static bool operator !=(Event left, Event right) {
    return !Equals(left, right);
  }

  public uint m_player {
    set {
      NWNXLibPINVOKE.Event_m_player_set(swigCPtr, value);
    } 
    get {
      uint retVal = NWNXLibPINVOKE.Event_m_player_get(swigCPtr);
      return retVal;
    }

  }

  public int m_token {
    set {
      NWNXLibPINVOKE.Event_m_token_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.Event_m_token_get(swigCPtr);
      return retVal;
    }

  }

  public string m_event {
    set {
      NWNXLibPINVOKE.Event_m_event_set(swigCPtr, value);
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = NWNXLibPINVOKE.Event_m_event_get(swigCPtr);
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string m_element {
    set {
      NWNXLibPINVOKE.Event_m_element_set(swigCPtr, value);
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = NWNXLibPINVOKE.Event_m_element_get(swigCPtr);
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int m_array_index {
    set {
      NWNXLibPINVOKE.Event_m_array_index_set(swigCPtr, value);
    } 
    get {
      int retVal = NWNXLibPINVOKE.Event_m_array_index_get(swigCPtr);
      return retVal;
    }

  }

  public SWIGTYPE_p_nlohmann__json m_payload {
    set {
      NWNXLibPINVOKE.Event_m_payload_set(swigCPtr, SWIGTYPE_p_nlohmann__json.getCPtr(value));
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_nlohmann__json ret = new SWIGTYPE_p_nlohmann__json(NWNXLibPINVOKE.Event_m_payload_get(swigCPtr), true);
      if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool IsValid() {
    bool ret = NWNXLibPINVOKE.Event_IsValid(swigCPtr);
    return ret;
  }

  public Event() : this(NWNXLibPINVOKE.new_Event(), true) {
  }

}

}