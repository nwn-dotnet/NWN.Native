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

public unsafe class CNWSPlayerJournalQuestUpdates : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSPlayerJournalQuestUpdates(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSPlayerJournalQuestUpdates obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSPlayerJournalQuestUpdates() {
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
          NWNXLibPINVOKE.delete_CNWSPlayerJournalQuestUpdates(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSPlayerJournalQuestUpdates self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSPlayerJournalQuestUpdates FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSPlayerJournalQuestUpdates((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSPlayerJournalQuestUpdates FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSPlayerJournalQuestUpdates(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSPlayerJournalQuestUpdates other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSPlayerJournalQuestUpdates other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSPlayerJournalQuestUpdates left, CNWSPlayerJournalQuestUpdates right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSPlayerJournalQuestUpdates left, CNWSPlayerJournalQuestUpdates right) {
    return !Equals(left, right);
  }

  public ushort flags {
    set {
      NWNXLibPINVOKE.CNWSPlayerJournalQuestUpdates_flags_set(swigCPtr, value);
    } 
    get {
      ushort retVal = NWNXLibPINVOKE.CNWSPlayerJournalQuestUpdates_flags_get(swigCPtr);
      return retVal;
    }

  }

  public CExoString szPlot_Id {
    set {
      NWNXLibPINVOKE.CNWSPlayerJournalQuestUpdates_szPlot_Id_set(swigCPtr, CExoString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSPlayerJournalQuestUpdates_szPlot_Id_get(swigCPtr);
      CExoString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoString(cPtr, false);
      return ret;
    } 
  }

  public CNWSPlayerJournalQuestUpdates() : this(NWNXLibPINVOKE.new_CNWSPlayerJournalQuestUpdates(), true) {
  }

}

}