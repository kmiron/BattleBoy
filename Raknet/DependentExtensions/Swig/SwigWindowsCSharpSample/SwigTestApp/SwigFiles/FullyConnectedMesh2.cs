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

public class FullyConnectedMesh2 : PluginInterface2 {
  private HandleRef swigCPtr;

  internal FullyConnectedMesh2(IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.FullyConnectedMesh2_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FullyConnectedMesh2 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FullyConnectedMesh2() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_FullyConnectedMesh2(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FullyConnectedMesh2 GetInstance() {
    IntPtr cPtr = RakNetPINVOKE.FullyConnectedMesh2_GetInstance();
    FullyConnectedMesh2 ret = (cPtr == IntPtr.Zero) ? null : new FullyConnectedMesh2(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(FullyConnectedMesh2 i) {
    RakNetPINVOKE.FullyConnectedMesh2_DestroyInstance(FullyConnectedMesh2.getCPtr(i));
  }

  public FullyConnectedMesh2() : this(RakNetPINVOKE.new_FullyConnectedMesh2(), true) {
  }

  public void SetConnectOnNewRemoteConnection(bool attemptConnection, RakString pw) {
    RakNetPINVOKE.FullyConnectedMesh2_SetConnectOnNewRemoteConnection(swigCPtr, attemptConnection, RakString.getCPtr(pw));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public RakNetGUID GetConnectedHost() {
    RakNetGUID ret = new RakNetGUID(RakNetPINVOKE.FullyConnectedMesh2_GetConnectedHost(swigCPtr), true);
    return ret;
  }

  public SystemAddress GetConnectedHostAddr() {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.FullyConnectedMesh2_GetConnectedHostAddr(swigCPtr), true);
    return ret;
  }

  public RakNetGUID GetHostSystem() {
    RakNetGUID ret = new RakNetGUID(RakNetPINVOKE.FullyConnectedMesh2_GetHostSystem(swigCPtr), true);
    return ret;
  }

  public bool IsHostSystem() {
    bool ret = RakNetPINVOKE.FullyConnectedMesh2_IsHostSystem(swigCPtr);
    return ret;
  }

  public void GetHostOrder(RakNetListRakNetGUID hostList) {
    RakNetPINVOKE.FullyConnectedMesh2_GetHostOrder(swigCPtr, RakNetListRakNetGUID.getCPtr(hostList));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsConnectedHost() {
    bool ret = RakNetPINVOKE.FullyConnectedMesh2_IsConnectedHost(swigCPtr);
    return ret;
  }

  public void SetAutoparticipateConnections(bool b) {
    RakNetPINVOKE.FullyConnectedMesh2_SetAutoparticipateConnections(swigCPtr, b);
  }

  public void ResetHostCalculation() {
    RakNetPINVOKE.FullyConnectedMesh2_ResetHostCalculation(swigCPtr);
  }

  public void AddParticipant(RakNetGUID rakNetGuid) {
    RakNetPINVOKE.FullyConnectedMesh2_AddParticipant(swigCPtr, RakNetGUID.getCPtr(rakNetGuid));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetParticipantList(RakNetListRakNetGUID participantList) {
    RakNetPINVOKE.FullyConnectedMesh2_GetParticipantList(swigCPtr, RakNetListRakNetGUID.getCPtr(participantList));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasParticipant(RakNetGUID participantGuid) {
    bool ret = RakNetPINVOKE.FullyConnectedMesh2_HasParticipant(swigCPtr, RakNetGUID.getCPtr(participantGuid));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ConnectToRemoteNewIncomingConnections(Packet packet) {
    RakNetPINVOKE.FullyConnectedMesh2_ConnectToRemoteNewIncomingConnections(swigCPtr, Packet.getCPtr(packet));
  }

  public void Clear() {
    RakNetPINVOKE.FullyConnectedMesh2_Clear(swigCPtr);
  }

  public uint GetParticipantCount() {
    uint ret = RakNetPINVOKE.FullyConnectedMesh2_GetParticipantCount__SWIG_0(swigCPtr);
    return ret;
  }

  public void GetParticipantCount(SWIGTYPE_p_unsigned_int participantListSize) {
    RakNetPINVOKE.FullyConnectedMesh2_GetParticipantCount__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(participantListSize));
  }

  public virtual void StartVerifiedJoin(RakNetGUID client) {
    RakNetPINVOKE.FullyConnectedMesh2_StartVerifiedJoin(swigCPtr, RakNetGUID.getCPtr(client));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void RespondOnVerifiedJoinCapable(Packet packet, bool accept, BitStream additionalData) {
    RakNetPINVOKE.FullyConnectedMesh2_RespondOnVerifiedJoinCapable(swigCPtr, Packet.getCPtr(packet), accept, BitStream.getCPtr(additionalData));
  }

  public virtual void GetVerifiedJoinRequiredProcessingList(RakNetGUID host, RakNetListSystemAddress addresses, RakNetListRakNetGUID guids) {
    RakNetPINVOKE.FullyConnectedMesh2_GetVerifiedJoinRequiredProcessingList(swigCPtr, RakNetGUID.getCPtr(host), RakNetListSystemAddress.getCPtr(addresses), RakNetListRakNetGUID.getCPtr(guids));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void GetVerifiedJoinAcceptedAdditionalData(Packet packet, SWIGTYPE_p_bool thisSystemAccepted, RakNetListRakNetGUID systemsAccepted, BitStream additionalData) {
    RakNetPINVOKE.FullyConnectedMesh2_GetVerifiedJoinAcceptedAdditionalData(swigCPtr, Packet.getCPtr(packet), SWIGTYPE_p_bool.getCPtr(thisSystemAccepted), RakNetListRakNetGUID.getCPtr(systemsAccepted), BitStream.getCPtr(additionalData));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void GetVerifiedJoinRejectedAdditionalData(Packet packet, BitStream additionalData) {
    RakNetPINVOKE.FullyConnectedMesh2_GetVerifiedJoinRejectedAdditionalData(swigCPtr, Packet.getCPtr(packet), BitStream.getCPtr(additionalData));
  }

  public uint GetTotalConnectionCount() {
    uint ret = RakNetPINVOKE.FullyConnectedMesh2_GetTotalConnectionCount(swigCPtr);
    return ret;
  }

  public enum JoinInProgressState {
    JIPS_PROCESSING,
    JIPS_FAILED,
    JIPS_CONNECTED,
    JIPS_UNNECESSARY
  }

}

}
