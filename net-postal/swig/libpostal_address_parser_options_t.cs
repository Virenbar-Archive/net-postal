//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class libpostal_address_parser_options_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal libpostal_address_parser_options_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(libpostal_address_parser_options_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~libpostal_address_parser_options_t() {
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
          libpostalPINVOKE.delete_libpostal_address_parser_options_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string language {
    set {
      libpostalPINVOKE.libpostal_address_parser_options_t_language_set(swigCPtr, value);
    } 
    get {
      string ret = libpostalPINVOKE.libpostal_address_parser_options_t_language_get(swigCPtr);
      return ret;
    } 
  }

  public string country {
    set {
      libpostalPINVOKE.libpostal_address_parser_options_t_country_set(swigCPtr, value);
    } 
    get {
      string ret = libpostalPINVOKE.libpostal_address_parser_options_t_country_get(swigCPtr);
      return ret;
    } 
  }

  public libpostal_address_parser_options_t() : this(libpostalPINVOKE.new_libpostal_address_parser_options_t(), true) {
  }

}