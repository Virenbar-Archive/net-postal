//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NetPostal {

public class libpostal_token_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal libpostal_token_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(libpostal_token_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~libpostal_token_t() {
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
          libpostalPINVOKE.delete_libpostal_token_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint offset {
    set {
      libpostalPINVOKE.libpostal_token_t_offset_set(swigCPtr, value);
    } 
    get {
      uint ret = libpostalPINVOKE.libpostal_token_t_offset_get(swigCPtr);
      return ret;
    } 
  }

  public uint len {
    set {
      libpostalPINVOKE.libpostal_token_t_len_set(swigCPtr, value);
    } 
    get {
      uint ret = libpostalPINVOKE.libpostal_token_t_len_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_uint16_t type {
    set {
      libpostalPINVOKE.libpostal_token_t_type_set(swigCPtr, SWIGTYPE_p_uint16_t.getCPtr(value));
      if (libpostalPINVOKE.SWIGPendingException.Pending) throw libpostalPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_uint16_t ret = new SWIGTYPE_p_uint16_t(libpostalPINVOKE.libpostal_token_t_type_get(swigCPtr), true);
      if (libpostalPINVOKE.SWIGPendingException.Pending) throw libpostalPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public libpostal_token_t() : this(libpostalPINVOKE.new_libpostal_token_t(), true) {
  }

}

}
