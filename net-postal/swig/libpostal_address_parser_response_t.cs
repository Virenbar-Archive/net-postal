//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class libpostal_address_parser_response_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal libpostal_address_parser_response_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(libpostal_address_parser_response_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~libpostal_address_parser_response_t() {
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
          libpostalPINVOKE.delete_libpostal_address_parser_response_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint num_components {
    set {
      libpostalPINVOKE.libpostal_address_parser_response_t_num_components_set(swigCPtr, value);
    } 
    get {
      uint ret = libpostalPINVOKE.libpostal_address_parser_response_t_num_components_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_char components {
    set {
      libpostalPINVOKE.libpostal_address_parser_response_t_components_set(swigCPtr, SWIGTYPE_p_p_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = libpostalPINVOKE.libpostal_address_parser_response_t_components_get(swigCPtr);
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_char labels {
    set {
      libpostalPINVOKE.libpostal_address_parser_response_t_labels_set(swigCPtr, SWIGTYPE_p_p_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = libpostalPINVOKE.libpostal_address_parser_response_t_labels_get(swigCPtr);
      SWIGTYPE_p_p_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_char(cPtr, false);
      return ret;
    } 
  }

  public libpostal_address_parser_response_t() : this(libpostalPINVOKE.new_libpostal_address_parser_response_t(), true) {
  }

}
