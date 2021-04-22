// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/resourcemanager/v3/organizations.proto
// </auto-generated>
// Original file comments:
// Copyright 2021 Google LLC
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
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.ResourceManager.V3 {
  /// <summary>
  /// Allows users to manage their organization resources.
  /// </summary>
  public static partial class Organizations
  {
    static readonly string __ServiceName = "google.cloud.resourcemanager.v3.Organizations";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Google.Cloud.ResourceManager.V3.GetOrganizationRequest> __Marshaller_google_cloud_resourcemanager_v3_GetOrganizationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ResourceManager.V3.GetOrganizationRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.ResourceManager.V3.Organization> __Marshaller_google_cloud_resourcemanager_v3_Organization = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ResourceManager.V3.Organization.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.ResourceManager.V3.SearchOrganizationsRequest> __Marshaller_google_cloud_resourcemanager_v3_SearchOrganizationsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ResourceManager.V3.SearchOrganizationsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.ResourceManager.V3.SearchOrganizationsResponse> __Marshaller_google_cloud_resourcemanager_v3_SearchOrganizationsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.ResourceManager.V3.SearchOrganizationsResponse.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.GetIamPolicyRequest> __Marshaller_google_iam_v1_GetIamPolicyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Iam.V1.GetIamPolicyRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.Policy> __Marshaller_google_iam_v1_Policy = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Iam.V1.Policy.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.SetIamPolicyRequest> __Marshaller_google_iam_v1_SetIamPolicyRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Iam.V1.SetIamPolicyRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.TestIamPermissionsRequest> __Marshaller_google_iam_v1_TestIamPermissionsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Iam.V1.TestIamPermissionsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Iam.V1.TestIamPermissionsResponse> __Marshaller_google_iam_v1_TestIamPermissionsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Iam.V1.TestIamPermissionsResponse.Parser));

    static readonly grpc::Method<global::Google.Cloud.ResourceManager.V3.GetOrganizationRequest, global::Google.Cloud.ResourceManager.V3.Organization> __Method_GetOrganization = new grpc::Method<global::Google.Cloud.ResourceManager.V3.GetOrganizationRequest, global::Google.Cloud.ResourceManager.V3.Organization>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetOrganization",
        __Marshaller_google_cloud_resourcemanager_v3_GetOrganizationRequest,
        __Marshaller_google_cloud_resourcemanager_v3_Organization);

    static readonly grpc::Method<global::Google.Cloud.ResourceManager.V3.SearchOrganizationsRequest, global::Google.Cloud.ResourceManager.V3.SearchOrganizationsResponse> __Method_SearchOrganizations = new grpc::Method<global::Google.Cloud.ResourceManager.V3.SearchOrganizationsRequest, global::Google.Cloud.ResourceManager.V3.SearchOrganizationsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SearchOrganizations",
        __Marshaller_google_cloud_resourcemanager_v3_SearchOrganizationsRequest,
        __Marshaller_google_cloud_resourcemanager_v3_SearchOrganizationsResponse);

    static readonly grpc::Method<global::Google.Cloud.Iam.V1.GetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy> __Method_GetIamPolicy = new grpc::Method<global::Google.Cloud.Iam.V1.GetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetIamPolicy",
        __Marshaller_google_iam_v1_GetIamPolicyRequest,
        __Marshaller_google_iam_v1_Policy);

    static readonly grpc::Method<global::Google.Cloud.Iam.V1.SetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy> __Method_SetIamPolicy = new grpc::Method<global::Google.Cloud.Iam.V1.SetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetIamPolicy",
        __Marshaller_google_iam_v1_SetIamPolicyRequest,
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
      get { return global::Google.Cloud.ResourceManager.V3.OrganizationsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Organizations</summary>
    [grpc::BindServiceMethod(typeof(Organizations), "BindService")]
    public abstract partial class OrganizationsBase
    {
      /// <summary>
      /// Fetches an organization resource identified by the specified resource name.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ResourceManager.V3.Organization> GetOrganization(global::Google.Cloud.ResourceManager.V3.GetOrganizationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Searches organization resources that are visible to the user and satisfy
      /// the specified filter. This method returns organizations in an unspecified
      /// order. New organizations do not necessarily appear at the end of the
      /// results, and may take a small amount of time to appear.
      ///
      /// Search will only return organizations on which the user has the permission
      /// `resourcemanager.organizations.get`
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.ResourceManager.V3.SearchOrganizationsResponse> SearchOrganizations(global::Google.Cloud.ResourceManager.V3.SearchOrganizationsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets the access control policy for an organization resource. The policy may
      /// be empty if no such policy or resource exists. The `resource` field should
      /// be the organization's resource name, for example: "organizations/123".
      ///
      /// Authorization requires the IAM permission
      /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Iam.V1.Policy> GetIamPolicy(global::Google.Cloud.Iam.V1.GetIamPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Sets the access control policy on an organization resource. Replaces any
      /// existing policy. The `resource` field should be the organization's resource
      /// name, for example: "organizations/123".
      ///
      /// Authorization requires the IAM permission
      /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Iam.V1.Policy> SetIamPolicy(global::Google.Cloud.Iam.V1.SetIamPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns the permissions that a caller has on the specified organization.
      /// The `resource` field should be the organization's resource name,
      /// for example: "organizations/123".
      ///
      /// There are no permissions required for making this API call.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Iam.V1.TestIamPermissionsResponse> TestIamPermissions(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Organizations</summary>
    public partial class OrganizationsClient : grpc::ClientBase<OrganizationsClient>
    {
      /// <summary>Creates a new client for Organizations</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OrganizationsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Organizations that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OrganizationsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OrganizationsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OrganizationsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Fetches an organization resource identified by the specified resource name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.ResourceManager.V3.Organization GetOrganization(global::Google.Cloud.ResourceManager.V3.GetOrganizationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetOrganization(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Fetches an organization resource identified by the specified resource name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.ResourceManager.V3.Organization GetOrganization(global::Google.Cloud.ResourceManager.V3.GetOrganizationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetOrganization, null, options, request);
      }
      /// <summary>
      /// Fetches an organization resource identified by the specified resource name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ResourceManager.V3.Organization> GetOrganizationAsync(global::Google.Cloud.ResourceManager.V3.GetOrganizationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetOrganizationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Fetches an organization resource identified by the specified resource name.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ResourceManager.V3.Organization> GetOrganizationAsync(global::Google.Cloud.ResourceManager.V3.GetOrganizationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetOrganization, null, options, request);
      }
      /// <summary>
      /// Searches organization resources that are visible to the user and satisfy
      /// the specified filter. This method returns organizations in an unspecified
      /// order. New organizations do not necessarily appear at the end of the
      /// results, and may take a small amount of time to appear.
      ///
      /// Search will only return organizations on which the user has the permission
      /// `resourcemanager.organizations.get`
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.ResourceManager.V3.SearchOrganizationsResponse SearchOrganizations(global::Google.Cloud.ResourceManager.V3.SearchOrganizationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchOrganizations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Searches organization resources that are visible to the user and satisfy
      /// the specified filter. This method returns organizations in an unspecified
      /// order. New organizations do not necessarily appear at the end of the
      /// results, and may take a small amount of time to appear.
      ///
      /// Search will only return organizations on which the user has the permission
      /// `resourcemanager.organizations.get`
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.ResourceManager.V3.SearchOrganizationsResponse SearchOrganizations(global::Google.Cloud.ResourceManager.V3.SearchOrganizationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchOrganizations, null, options, request);
      }
      /// <summary>
      /// Searches organization resources that are visible to the user and satisfy
      /// the specified filter. This method returns organizations in an unspecified
      /// order. New organizations do not necessarily appear at the end of the
      /// results, and may take a small amount of time to appear.
      ///
      /// Search will only return organizations on which the user has the permission
      /// `resourcemanager.organizations.get`
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ResourceManager.V3.SearchOrganizationsResponse> SearchOrganizationsAsync(global::Google.Cloud.ResourceManager.V3.SearchOrganizationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchOrganizationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Searches organization resources that are visible to the user and satisfy
      /// the specified filter. This method returns organizations in an unspecified
      /// order. New organizations do not necessarily appear at the end of the
      /// results, and may take a small amount of time to appear.
      ///
      /// Search will only return organizations on which the user has the permission
      /// `resourcemanager.organizations.get`
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.ResourceManager.V3.SearchOrganizationsResponse> SearchOrganizationsAsync(global::Google.Cloud.ResourceManager.V3.SearchOrganizationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchOrganizations, null, options, request);
      }
      /// <summary>
      /// Gets the access control policy for an organization resource. The policy may
      /// be empty if no such policy or resource exists. The `resource` field should
      /// be the organization's resource name, for example: "organizations/123".
      ///
      /// Authorization requires the IAM permission
      /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
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
      /// Gets the access control policy for an organization resource. The policy may
      /// be empty if no such policy or resource exists. The `resource` field should
      /// be the organization's resource name, for example: "organizations/123".
      ///
      /// Authorization requires the IAM permission
      /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Iam.V1.Policy GetIamPolicy(global::Google.Cloud.Iam.V1.GetIamPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetIamPolicy, null, options, request);
      }
      /// <summary>
      /// Gets the access control policy for an organization resource. The policy may
      /// be empty if no such policy or resource exists. The `resource` field should
      /// be the organization's resource name, for example: "organizations/123".
      ///
      /// Authorization requires the IAM permission
      /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
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
      /// Gets the access control policy for an organization resource. The policy may
      /// be empty if no such policy or resource exists. The `resource` field should
      /// be the organization's resource name, for example: "organizations/123".
      ///
      /// Authorization requires the IAM permission
      /// `resourcemanager.organizations.getIamPolicy` on the specified organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.Policy> GetIamPolicyAsync(global::Google.Cloud.Iam.V1.GetIamPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetIamPolicy, null, options, request);
      }
      /// <summary>
      /// Sets the access control policy on an organization resource. Replaces any
      /// existing policy. The `resource` field should be the organization's resource
      /// name, for example: "organizations/123".
      ///
      /// Authorization requires the IAM permission
      /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
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
      /// Sets the access control policy on an organization resource. Replaces any
      /// existing policy. The `resource` field should be the organization's resource
      /// name, for example: "organizations/123".
      ///
      /// Authorization requires the IAM permission
      /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Iam.V1.Policy SetIamPolicy(global::Google.Cloud.Iam.V1.SetIamPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetIamPolicy, null, options, request);
      }
      /// <summary>
      /// Sets the access control policy on an organization resource. Replaces any
      /// existing policy. The `resource` field should be the organization's resource
      /// name, for example: "organizations/123".
      ///
      /// Authorization requires the IAM permission
      /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
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
      /// Sets the access control policy on an organization resource. Replaces any
      /// existing policy. The `resource` field should be the organization's resource
      /// name, for example: "organizations/123".
      ///
      /// Authorization requires the IAM permission
      /// `resourcemanager.organizations.setIamPolicy` on the specified organization.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.Policy> SetIamPolicyAsync(global::Google.Cloud.Iam.V1.SetIamPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetIamPolicy, null, options, request);
      }
      /// <summary>
      /// Returns the permissions that a caller has on the specified organization.
      /// The `resource` field should be the organization's resource name,
      /// for example: "organizations/123".
      ///
      /// There are no permissions required for making this API call.
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
      /// Returns the permissions that a caller has on the specified organization.
      /// The `resource` field should be the organization's resource name,
      /// for example: "organizations/123".
      ///
      /// There are no permissions required for making this API call.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Iam.V1.TestIamPermissionsResponse TestIamPermissions(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_TestIamPermissions, null, options, request);
      }
      /// <summary>
      /// Returns the permissions that a caller has on the specified organization.
      /// The `resource` field should be the organization's resource name,
      /// for example: "organizations/123".
      ///
      /// There are no permissions required for making this API call.
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
      /// Returns the permissions that a caller has on the specified organization.
      /// The `resource` field should be the organization's resource name,
      /// for example: "organizations/123".
      ///
      /// There are no permissions required for making this API call.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Iam.V1.TestIamPermissionsResponse> TestIamPermissionsAsync(global::Google.Cloud.Iam.V1.TestIamPermissionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_TestIamPermissions, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override OrganizationsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OrganizationsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(OrganizationsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetOrganization, serviceImpl.GetOrganization)
          .AddMethod(__Method_SearchOrganizations, serviceImpl.SearchOrganizations)
          .AddMethod(__Method_GetIamPolicy, serviceImpl.GetIamPolicy)
          .AddMethod(__Method_SetIamPolicy, serviceImpl.SetIamPolicy)
          .AddMethod(__Method_TestIamPermissions, serviceImpl.TestIamPermissions).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, OrganizationsBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetOrganization, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ResourceManager.V3.GetOrganizationRequest, global::Google.Cloud.ResourceManager.V3.Organization>(serviceImpl.GetOrganization));
      serviceBinder.AddMethod(__Method_SearchOrganizations, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.ResourceManager.V3.SearchOrganizationsRequest, global::Google.Cloud.ResourceManager.V3.SearchOrganizationsResponse>(serviceImpl.SearchOrganizations));
      serviceBinder.AddMethod(__Method_GetIamPolicy, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Iam.V1.GetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy>(serviceImpl.GetIamPolicy));
      serviceBinder.AddMethod(__Method_SetIamPolicy, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Iam.V1.SetIamPolicyRequest, global::Google.Cloud.Iam.V1.Policy>(serviceImpl.SetIamPolicy));
      serviceBinder.AddMethod(__Method_TestIamPermissions, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Iam.V1.TestIamPermissionsRequest, global::Google.Cloud.Iam.V1.TestIamPermissionsResponse>(serviceImpl.TestIamPermissions));
    }

  }
}
#endregion
