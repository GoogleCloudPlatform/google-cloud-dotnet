// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/iam/v1/iam_policy.proto
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

namespace Google.Cloud.Iam.V1 {
  /// <summary>
  /// ## API Overview
  ///
  /// Manages Identity and Access Management (IAM) policies.
  ///
  /// Any implementation of an API that offers access control features
  /// implements the google.iam.v1.IAMPolicy interface.
  ///
  /// ## Data model
  ///
  /// Access control is applied when a principal (user or service account), takes
  /// some action on a resource exposed by a service. Resources, identified by
  /// URI-like names, are the unit of access control specification. Service
  /// implementations can choose the granularity of access control and the
  /// supported permissions for their resources.
  /// For example one database service may allow access control to be
  /// specified only at the Table level, whereas another might allow access control
  /// to also be specified at the Column level.
  ///
  /// ## Policy Structure
  ///
  /// See google.iam.v1.Policy
  ///
  /// This is intentionally not a CRUD style API because access control policies
  /// are created and deleted implicitly with the resources to which they are
  /// attached.
  /// </summary>
  public static partial class IAMPolicy
  {
    static readonly string __ServiceName = "google.iam.v1.IAMPolicy";

    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.SetIamPolicyRequest> __Marshaller_google_iam_v1_SetIamPolicyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Iam.V1.SetIamPolicyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.Policy> __Marshaller_google_iam_v1_Policy = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Iam.V1.Policy.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.GetIamPolicyRequest> __Marshaller_google_iam_v1_GetIamPolicyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Iam.V1.GetIamPolicyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.TestIamPermissionsRequest> __Marshaller_google_iam_v1_TestIamPermissionsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Iam.V1.TestIamPermissionsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.TestIamPermissionsResponse> __Marshaller_google_iam_v1_TestIamPermissionsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Iam.V1.TestIamPermissionsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Iam.V1.SetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy> __Method_SetIamPolicy = new grpc::Method<global::Google.Cloud.Iam.V1.SetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetIamPolicy",
        __Marshaller_google_iam_v1_SetIamPolicyRequest,
        __Marshaller_google_iam_v1_Policy);

    static readonly grpc::Method<global::Google.Cloud.Iam.V1.GetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy> __Method_GetIamPolicy = new grpc::Method<global::Google.Cloud.Iam.V1.GetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetIamPolicy",
        __Marshaller_google_iam_v1_GetIamPolicyRequest,
        __Marshaller_google_iam_v1_Policy);

    static readonly grpc::Method<global::Google.Cloud.Iam.V1.TestIamPermissionsRequest, global::Google.Cloud.Iam.V1.TestIamPermissionsResponse> __Method_TestIamPermissions = new grpc::Method<global::Google.Cloud.Iam.V1.TestIamPermissionsRequest, global::Google.Cloud.Iam.V1.TestIamPermissionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "TestIamPermissions",
        __Marshaller_google_iam_v1_TestIamPermissionsRequest,
        __Marshaller_google_iam_v1_TestIamPermissionsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Iam.V1.IamPolicyReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of IAMPolicy</summary>
    [grpc::BindServiceMethod(typeof(IAMPolicy), "BindService")]
    public abstract partial class IAMPolicyBase
    {
      /// <summary>
      /// Sets the access control policy on the specified resource. Replaces any
      /// existing policy.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Iam.V1.Policy> SetIamPolicy(global::Google.Cloud.Iam.V1.SetIamPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets the access control policy for a resource.
      /// Returns an empty policy if the resource exists and does not have a policy
      /// set.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Iam.V1.Policy> GetIamPolicy(global::Google.Cloud.Iam.V1.GetIamPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns permissions that a caller has on the specified resource.
      /// If the resource does not exist, this will return an empty set of
      /// permissions, not a NOT_FOUND error.
      ///
      /// Note: This operation is designed to be used for building permission-aware
      /// UIs and command-line tools, not for authorization checking. This operation
      /// may "fail open" without warning.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Iam.V1.TestIamPermissionsResponse> TestIamPermissions(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for IAMPolicy</summary>
    public partial class IAMPolicyClient : grpc::ClientBase<IAMPolicyClient>
    {
      /// <summary>Creates a new client for IAMPolicy</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public IAMPolicyClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for IAMPolicy that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public IAMPolicyClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected IAMPolicyClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected IAMPolicyClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Sets the access control policy on the specified resource. Replaces any
      /// existing policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Iam.V1.Policy SetIamPolicy(global::Google.Cloud.Iam.V1.SetIamPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetIamPolicy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sets the access control policy on the specified resource. Replaces any
      /// existing policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Iam.V1.Policy SetIamPolicy(global::Google.Cloud.Iam.V1.SetIamPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetIamPolicy, null, options, request);
      }
      /// <summary>
      /// Sets the access control policy on the specified resource. Replaces any
      /// existing policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.Policy> SetIamPolicyAsync(global::Google.Cloud.Iam.V1.SetIamPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetIamPolicyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Sets the access control policy on the specified resource. Replaces any
      /// existing policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.Policy> SetIamPolicyAsync(global::Google.Cloud.Iam.V1.SetIamPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetIamPolicy, null, options, request);
      }
      /// <summary>
      /// Gets the access control policy for a resource.
      /// Returns an empty policy if the resource exists and does not have a policy
      /// set.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Iam.V1.Policy GetIamPolicy(global::Google.Cloud.Iam.V1.GetIamPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetIamPolicy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the access control policy for a resource.
      /// Returns an empty policy if the resource exists and does not have a policy
      /// set.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Iam.V1.Policy GetIamPolicy(global::Google.Cloud.Iam.V1.GetIamPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetIamPolicy, null, options, request);
      }
      /// <summary>
      /// Gets the access control policy for a resource.
      /// Returns an empty policy if the resource exists and does not have a policy
      /// set.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.Policy> GetIamPolicyAsync(global::Google.Cloud.Iam.V1.GetIamPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetIamPolicyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the access control policy for a resource.
      /// Returns an empty policy if the resource exists and does not have a policy
      /// set.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.Policy> GetIamPolicyAsync(global::Google.Cloud.Iam.V1.GetIamPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetIamPolicy, null, options, request);
      }
      /// <summary>
      /// Returns permissions that a caller has on the specified resource.
      /// If the resource does not exist, this will return an empty set of
      /// permissions, not a NOT_FOUND error.
      ///
      /// Note: This operation is designed to be used for building permission-aware
      /// UIs and command-line tools, not for authorization checking. This operation
      /// may "fail open" without warning.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Iam.V1.TestIamPermissionsResponse TestIamPermissions(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TestIamPermissions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns permissions that a caller has on the specified resource.
      /// If the resource does not exist, this will return an empty set of
      /// permissions, not a NOT_FOUND error.
      ///
      /// Note: This operation is designed to be used for building permission-aware
      /// UIs and command-line tools, not for authorization checking. This operation
      /// may "fail open" without warning.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Iam.V1.TestIamPermissionsResponse TestIamPermissions(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_TestIamPermissions, null, options, request);
      }
      /// <summary>
      /// Returns permissions that a caller has on the specified resource.
      /// If the resource does not exist, this will return an empty set of
      /// permissions, not a NOT_FOUND error.
      ///
      /// Note: This operation is designed to be used for building permission-aware
      /// UIs and command-line tools, not for authorization checking. This operation
      /// may "fail open" without warning.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.TestIamPermissionsResponse> TestIamPermissionsAsync(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return TestIamPermissionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns permissions that a caller has on the specified resource.
      /// If the resource does not exist, this will return an empty set of
      /// permissions, not a NOT_FOUND error.
      ///
      /// Note: This operation is designed to be used for building permission-aware
      /// UIs and command-line tools, not for authorization checking. This operation
      /// may "fail open" without warning.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.TestIamPermissionsResponse> TestIamPermissionsAsync(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_TestIamPermissions, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override IAMPolicyClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new IAMPolicyClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(IAMPolicyBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SetIamPolicy, serviceImpl.SetIamPolicy)
          .AddMethod(__Method_GetIamPolicy, serviceImpl.GetIamPolicy)
          .AddMethod(__Method_TestIamPermissions, serviceImpl.TestIamPermissions).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, IAMPolicyBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SetIamPolicy, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Iam.V1.SetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy>(serviceImpl.SetIamPolicy));
      serviceBinder.AddMethod(__Method_GetIamPolicy, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Iam.V1.GetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy>(serviceImpl.GetIamPolicy));
      serviceBinder.AddMethod(__Method_TestIamPermissions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Iam.V1.TestIamPermissionsRequest, global::Google.Cloud.Iam.V1.TestIamPermissionsResponse>(serviceImpl.TestIamPermissions));
    }

  }
}
#endregion
