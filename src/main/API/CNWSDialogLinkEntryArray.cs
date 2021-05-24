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

public unsafe class CNWSDialogLinkEntryArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWSDialogLinkEntryArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSDialogLinkEntryArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSDialogLinkEntryArray() {
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
          NWNXLibPINVOKE.delete_CNWSDialogLinkEntryArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }
/*@SWIG:/__w/NWN.Native/NWN.Native/nwnx/Plugins/SWIG/SWIG_DotNET/API_NWNXLib.i,20,SWIG_DOTNET_EXTENSIONS@*/
  public global::System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWSDialogLinkEntryArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static unsafe CNWSDialogLinkEntryArray FromPointer(void* pointer, bool memoryOwn = false) {
    return pointer != null ? new CNWSDialogLinkEntryArray((global::System.IntPtr)pointer, memoryOwn) : null;
  }

  public static CNWSDialogLinkEntryArray FromPointer(global::System.IntPtr pointer, bool memoryOwn = false) {
    return pointer != global::System.IntPtr.Zero ? new CNWSDialogLinkEntryArray(pointer, memoryOwn) : null;
  }

  public bool Equals(CNWSDialogLinkEntryArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSDialogLinkEntryArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSDialogLinkEntryArray left, CNWSDialogLinkEntryArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSDialogLinkEntryArray left, CNWSDialogLinkEntryArray right) {
    return !Equals(left, right);
  }
/*@SWIG@*/

  public CNWSDialogLinkEntry this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }
  public CNWSDialogLinkEntryArray(int nElements) : this(NWNXLibPINVOKE.new_CNWSDialogLinkEntryArray(nElements), true) {
  }

  public CNWSDialogLinkEntry GetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogLinkEntryArray_GetItem(swigCPtr, index);
    CNWSDialogLinkEntry ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogLinkEntry(cPtr, false);
    return ret;
  }

  public void SetItem(int index, CNWSDialogLinkEntry value) {
    NWNXLibPINVOKE.CNWSDialogLinkEntryArray_SetItem(swigCPtr, index, CNWSDialogLinkEntry.getCPtr(value));
  }

  public static CNWSDialogLinkEntryArray FromPointer(CNWSDialogLinkEntry ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSDialogLinkEntryArray_FromPointer(CNWSDialogLinkEntry.getCPtr(ptr));
    CNWSDialogLinkEntryArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSDialogLinkEntryArray(cPtr, false);
    return ret;
  }

}

}