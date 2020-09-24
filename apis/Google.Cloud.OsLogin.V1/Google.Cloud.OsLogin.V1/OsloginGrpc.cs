// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/oslogin/v1/oslogin.proto
// </auto-generated>
// Original file comments:
// Copyright 2019 Google LLC.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.OsLogin.V1 {
  /// <summary>
  /// Cloud OS Login API
  ///
  /// The Cloud OS Login API allows you to manage users and their associated SSH
  /// public keys for logging into virtual machines on Google Cloud Platform.
  /// </summary>
  public static partial class OsLoginService
  {
    static readonly string __ServiceName = "google.cloud.oslogin.v1.OsLoginService";

    static readonly grpc::Marshaller<global::Google.Cloud.OsLogin.V1.DeletePosixAccountRequest> __Marshaller_google_cloud_oslogin_v1_DeletePosixAccountRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.OsLogin.V1.DeletePosixAccountRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.OsLogin.V1.DeleteSshPublicKeyRequest> __Marshaller_google_cloud_oslogin_v1_DeleteSshPublicKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.OsLogin.V1.DeleteSshPublicKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.OsLogin.V1.GetLoginProfileRequest> __Marshaller_google_cloud_oslogin_v1_GetLoginProfileRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.OsLogin.V1.GetLoginProfileRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.OsLogin.V1.LoginProfile> __Marshaller_google_cloud_oslogin_v1_LoginProfile = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.OsLogin.V1.LoginProfile.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.OsLogin.V1.GetSshPublicKeyRequest> __Marshaller_google_cloud_oslogin_v1_GetSshPublicKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.OsLogin.V1.GetSshPublicKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.OsLogin.Common.SshPublicKey> __Marshaller_google_cloud_oslogin_common_SshPublicKey = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.OsLogin.Common.SshPublicKey.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyRequest> __Marshaller_google_cloud_oslogin_v1_ImportSshPublicKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyResponse> __Marshaller_google_cloud_oslogin_v1_ImportSshPublicKeyResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.OsLogin.V1.UpdateSshPublicKeyRequest> __Marshaller_google_cloud_oslogin_v1_UpdateSshPublicKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.OsLogin.V1.UpdateSshPublicKeyRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.OsLogin.V1.DeletePosixAccountRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeletePosixAccount = new grpc::Method<global::Google.Cloud.OsLogin.V1.DeletePosixAccountRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeletePosixAccount",
        __Marshaller_google_cloud_oslogin_v1_DeletePosixAccountRequest,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::Google.Cloud.OsLogin.V1.DeleteSshPublicKeyRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteSshPublicKey = new grpc::Method<global::Google.Cloud.OsLogin.V1.DeleteSshPublicKeyRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteSshPublicKey",
        __Marshaller_google_cloud_oslogin_v1_DeleteSshPublicKeyRequest,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::Google.Cloud.OsLogin.V1.GetLoginProfileRequest, global::Google.Cloud.OsLogin.V1.LoginProfile> __Method_GetLoginProfile = new grpc::Method<global::Google.Cloud.OsLogin.V1.GetLoginProfileRequest, global::Google.Cloud.OsLogin.V1.LoginProfile>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetLoginProfile",
        __Marshaller_google_cloud_oslogin_v1_GetLoginProfileRequest,
        __Marshaller_google_cloud_oslogin_v1_LoginProfile);

    static readonly grpc::Method<global::Google.Cloud.OsLogin.V1.GetSshPublicKeyRequest, global::Google.Cloud.OsLogin.Common.SshPublicKey> __Method_GetSshPublicKey = new grpc::Method<global::Google.Cloud.OsLogin.V1.GetSshPublicKeyRequest, global::Google.Cloud.OsLogin.Common.SshPublicKey>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSshPublicKey",
        __Marshaller_google_cloud_oslogin_v1_GetSshPublicKeyRequest,
        __Marshaller_google_cloud_oslogin_common_SshPublicKey);

    static readonly grpc::Method<global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyRequest, global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyResponse> __Method_ImportSshPublicKey = new grpc::Method<global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyRequest, global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ImportSshPublicKey",
        __Marshaller_google_cloud_oslogin_v1_ImportSshPublicKeyRequest,
        __Marshaller_google_cloud_oslogin_v1_ImportSshPublicKeyResponse);

    static readonly grpc::Method<global::Google.Cloud.OsLogin.V1.UpdateSshPublicKeyRequest, global::Google.Cloud.OsLogin.Common.SshPublicKey> __Method_UpdateSshPublicKey = new grpc::Method<global::Google.Cloud.OsLogin.V1.UpdateSshPublicKeyRequest, global::Google.Cloud.OsLogin.Common.SshPublicKey>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateSshPublicKey",
        __Marshaller_google_cloud_oslogin_v1_UpdateSshPublicKeyRequest,
        __Marshaller_google_cloud_oslogin_common_SshPublicKey);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.OsLogin.V1.OsloginReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of OsLoginService</summary>
    [grpc::BindServiceMethod(typeof(OsLoginService), "BindService")]
    public abstract partial class OsLoginServiceBase
    {
      /// <summary>
      /// Deletes a POSIX account.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeletePosixAccount(global::Google.Cloud.OsLogin.V1.DeletePosixAccountRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes an SSH public key.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSshPublicKey(global::Google.Cloud.OsLogin.V1.DeleteSshPublicKeyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves the profile information used for logging in to a virtual machine
      /// on Google Compute Engine.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.OsLogin.V1.LoginProfile> GetLoginProfile(global::Google.Cloud.OsLogin.V1.GetLoginProfileRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Retrieves an SSH public key.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.OsLogin.Common.SshPublicKey> GetSshPublicKey(global::Google.Cloud.OsLogin.V1.GetSshPublicKeyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Adds an SSH public key and returns the profile information. Default POSIX
      /// account information is set when no username and UID exist as part of the
      /// login profile.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyResponse> ImportSshPublicKey(global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates an SSH public key and returns the profile information. This method
      /// supports patch semantics.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.OsLogin.Common.SshPublicKey> UpdateSshPublicKey(global::Google.Cloud.OsLogin.V1.UpdateSshPublicKeyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for OsLoginService</summary>
    public partial class OsLoginServiceClient : grpc::ClientBase<OsLoginServiceClient>
    {
      /// <summary>Creates a new client for OsLoginService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OsLoginServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OsLoginService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OsLoginServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OsLoginServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OsLoginServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Deletes a POSIX account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeletePosixAccount(global::Google.Cloud.OsLogin.V1.DeletePosixAccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePosixAccount(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a POSIX account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeletePosixAccount(global::Google.Cloud.OsLogin.V1.DeletePosixAccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeletePosixAccount, null, options, request);
      }
      /// <summary>
      /// Deletes a POSIX account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeletePosixAccountAsync(global::Google.Cloud.OsLogin.V1.DeletePosixAccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeletePosixAccountAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a POSIX account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeletePosixAccountAsync(global::Google.Cloud.OsLogin.V1.DeletePosixAccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeletePosixAccount, null, options, request);
      }
      /// <summary>
      /// Deletes an SSH public key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteSshPublicKey(global::Google.Cloud.OsLogin.V1.DeleteSshPublicKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteSshPublicKey(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes an SSH public key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteSshPublicKey(global::Google.Cloud.OsLogin.V1.DeleteSshPublicKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteSshPublicKey, null, options, request);
      }
      /// <summary>
      /// Deletes an SSH public key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSshPublicKeyAsync(global::Google.Cloud.OsLogin.V1.DeleteSshPublicKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteSshPublicKeyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes an SSH public key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSshPublicKeyAsync(global::Google.Cloud.OsLogin.V1.DeleteSshPublicKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteSshPublicKey, null, options, request);
      }
      /// <summary>
      /// Retrieves the profile information used for logging in to a virtual machine
      /// on Google Compute Engine.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.OsLogin.V1.LoginProfile GetLoginProfile(global::Google.Cloud.OsLogin.V1.GetLoginProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLoginProfile(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the profile information used for logging in to a virtual machine
      /// on Google Compute Engine.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.OsLogin.V1.LoginProfile GetLoginProfile(global::Google.Cloud.OsLogin.V1.GetLoginProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetLoginProfile, null, options, request);
      }
      /// <summary>
      /// Retrieves the profile information used for logging in to a virtual machine
      /// on Google Compute Engine.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.OsLogin.V1.LoginProfile> GetLoginProfileAsync(global::Google.Cloud.OsLogin.V1.GetLoginProfileRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLoginProfileAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the profile information used for logging in to a virtual machine
      /// on Google Compute Engine.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.OsLogin.V1.LoginProfile> GetLoginProfileAsync(global::Google.Cloud.OsLogin.V1.GetLoginProfileRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetLoginProfile, null, options, request);
      }
      /// <summary>
      /// Retrieves an SSH public key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.OsLogin.Common.SshPublicKey GetSshPublicKey(global::Google.Cloud.OsLogin.V1.GetSshPublicKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSshPublicKey(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves an SSH public key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.OsLogin.Common.SshPublicKey GetSshPublicKey(global::Google.Cloud.OsLogin.V1.GetSshPublicKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSshPublicKey, null, options, request);
      }
      /// <summary>
      /// Retrieves an SSH public key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.OsLogin.Common.SshPublicKey> GetSshPublicKeyAsync(global::Google.Cloud.OsLogin.V1.GetSshPublicKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSshPublicKeyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves an SSH public key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.OsLogin.Common.SshPublicKey> GetSshPublicKeyAsync(global::Google.Cloud.OsLogin.V1.GetSshPublicKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSshPublicKey, null, options, request);
      }
      /// <summary>
      /// Adds an SSH public key and returns the profile information. Default POSIX
      /// account information is set when no username and UID exist as part of the
      /// login profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyResponse ImportSshPublicKey(global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ImportSshPublicKey(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Adds an SSH public key and returns the profile information. Default POSIX
      /// account information is set when no username and UID exist as part of the
      /// login profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyResponse ImportSshPublicKey(global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ImportSshPublicKey, null, options, request);
      }
      /// <summary>
      /// Adds an SSH public key and returns the profile information. Default POSIX
      /// account information is set when no username and UID exist as part of the
      /// login profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ImportSshPublicKeyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Adds an SSH public key and returns the profile information. Default POSIX
      /// account information is set when no username and UID exist as part of the
      /// login profile.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ImportSshPublicKey, null, options, request);
      }
      /// <summary>
      /// Updates an SSH public key and returns the profile information. This method
      /// supports patch semantics.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.OsLogin.Common.SshPublicKey UpdateSshPublicKey(global::Google.Cloud.OsLogin.V1.UpdateSshPublicKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateSshPublicKey(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates an SSH public key and returns the profile information. This method
      /// supports patch semantics.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.OsLogin.Common.SshPublicKey UpdateSshPublicKey(global::Google.Cloud.OsLogin.V1.UpdateSshPublicKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateSshPublicKey, null, options, request);
      }
      /// <summary>
      /// Updates an SSH public key and returns the profile information. This method
      /// supports patch semantics.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.OsLogin.Common.SshPublicKey> UpdateSshPublicKeyAsync(global::Google.Cloud.OsLogin.V1.UpdateSshPublicKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateSshPublicKeyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates an SSH public key and returns the profile information. This method
      /// supports patch semantics.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.OsLogin.Common.SshPublicKey> UpdateSshPublicKeyAsync(global::Google.Cloud.OsLogin.V1.UpdateSshPublicKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateSshPublicKey, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override OsLoginServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OsLoginServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(OsLoginServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_DeletePosixAccount, serviceImpl.DeletePosixAccount)
          .AddMethod(__Method_DeleteSshPublicKey, serviceImpl.DeleteSshPublicKey)
          .AddMethod(__Method_GetLoginProfile, serviceImpl.GetLoginProfile)
          .AddMethod(__Method_GetSshPublicKey, serviceImpl.GetSshPublicKey)
          .AddMethod(__Method_ImportSshPublicKey, serviceImpl.ImportSshPublicKey)
          .AddMethod(__Method_UpdateSshPublicKey, serviceImpl.UpdateSshPublicKey).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, OsLoginServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_DeletePosixAccount, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.OsLogin.V1.DeletePosixAccountRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeletePosixAccount));
      serviceBinder.AddMethod(__Method_DeleteSshPublicKey, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.OsLogin.V1.DeleteSshPublicKeyRequest, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteSshPublicKey));
      serviceBinder.AddMethod(__Method_GetLoginProfile, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.OsLogin.V1.GetLoginProfileRequest, global::Google.Cloud.OsLogin.V1.LoginProfile>(serviceImpl.GetLoginProfile));
      serviceBinder.AddMethod(__Method_GetSshPublicKey, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.OsLogin.V1.GetSshPublicKeyRequest, global::Google.Cloud.OsLogin.Common.SshPublicKey>(serviceImpl.GetSshPublicKey));
      serviceBinder.AddMethod(__Method_ImportSshPublicKey, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyRequest, global::Google.Cloud.OsLogin.V1.ImportSshPublicKeyResponse>(serviceImpl.ImportSshPublicKey));
      serviceBinder.AddMethod(__Method_UpdateSshPublicKey, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.OsLogin.V1.UpdateSshPublicKeyRequest, global::Google.Cloud.OsLogin.Common.SshPublicKey>(serviceImpl.UpdateSshPublicKey));
    }

  }
}
#endregion
