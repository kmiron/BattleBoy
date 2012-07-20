/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class UDPForwarder : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UDPForwarder(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(UDPForwarder obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~UDPForwarder() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_UDPForwarder(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public UDPForwarder() : this(RakNetPINVOKE.new_UDPForwarder(), true) {
  }

  public void Startup() {
    RakNetPINVOKE.UDPForwarder_Startup(swigCPtr);
  }

  public void Shutdown() {
    RakNetPINVOKE.UDPForwarder_Shutdown(swigCPtr);
  }

  public void SetMaxForwardEntries(ushort maxEntries) {
    RakNetPINVOKE.UDPForwarder_SetMaxForwardEntries(swigCPtr, maxEntries);
  }

  public int GetMaxForwardEntries() {
    int ret = RakNetPINVOKE.UDPForwarder_GetMaxForwardEntries(swigCPtr);
    return ret;
  }

  public int GetUsedForwardEntries() {
    int ret = RakNetPINVOKE.UDPForwarder_GetUsedForwardEntries(swigCPtr);
    return ret;
  }

  public UDPForwarderResult StartForwarding(SystemAddress source, SystemAddress destination, uint timeoutOnNoDataMS, string forceHostAddress, ushort socketFamily, out ushort forwardingPort, out uint forwardingSocket) {
    UDPForwarderResult ret = (UDPForwarderResult)RakNetPINVOKE.UDPForwarder_StartForwarding(swigCPtr, SystemAddress.getCPtr(source), SystemAddress.getCPtr(destination), timeoutOnNoDataMS, forceHostAddress, socketFamily, out forwardingPort, out forwardingSocket);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void StopForwarding(SystemAddress source, SystemAddress destination) {
    RakNetPINVOKE.UDPForwarder_StopForwarding(swigCPtr, SystemAddress.getCPtr(source), SystemAddress.getCPtr(destination));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
