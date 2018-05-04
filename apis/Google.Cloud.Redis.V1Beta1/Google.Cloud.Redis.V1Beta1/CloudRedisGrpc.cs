// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/redis/v1beta1/cloud_redis.proto
// </auto-generated>
// Original file comments:
// Copyright 2018 Google Inc.
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
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Google.Cloud.Redis.V1Beta1 {
  /// <summary>
  /// Configures and manages Cloud Memorystore for Redis instances
  ///
  /// Google Cloud Memorystore for Redis v1beta1
  ///
  /// The `redis.googleapis.com` service implements the Google Cloud Memorystore
  /// for Redis API and defines the following resource model for managing Redis
  /// instances:
  /// * The service works with a collection of cloud projects, named: `/projects/*`
  /// * Each project has a collection of available locations, named: `/locations/*`
  /// * Each location has a collection of Redis instances, named: `/instances/*`
  /// * As such, Redis instances are resources of the form:
  ///   `/projects/{project_id}/locations/{location_id}/instances/{instance_id}`
  ///
  /// Note that location_id must be refering to a GCP `region`; for example:
  /// * `projects/redpepper-1290/locations/us-central1/instances/my-redis`
  /// </summary>
  public static partial class CloudRedis
  {
    static readonly string __ServiceName = "google.cloud.redis.v1beta1.CloudRedis";

    static readonly grpc::Marshaller<global::Google.Cloud.Redis.V1Beta1.ListInstancesRequest> __Marshaller_ListInstancesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Redis.V1Beta1.ListInstancesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Redis.V1Beta1.ListInstancesResponse> __Marshaller_ListInstancesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Redis.V1Beta1.ListInstancesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Redis.V1Beta1.GetInstanceRequest> __Marshaller_GetInstanceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Redis.V1Beta1.GetInstanceRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Redis.V1Beta1.Instance> __Marshaller_Instance = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Redis.V1Beta1.Instance.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Redis.V1Beta1.CreateInstanceRequest> __Marshaller_CreateInstanceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Redis.V1Beta1.CreateInstanceRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.LongRunning.Operation.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Redis.V1Beta1.UpdateInstanceRequest> __Marshaller_UpdateInstanceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Redis.V1Beta1.UpdateInstanceRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Redis.V1Beta1.DeleteInstanceRequest> __Marshaller_DeleteInstanceRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Redis.V1Beta1.DeleteInstanceRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Redis.V1Beta1.ListInstancesRequest, global::Google.Cloud.Redis.V1Beta1.ListInstancesResponse> __Method_ListInstances = new grpc::Method<global::Google.Cloud.Redis.V1Beta1.ListInstancesRequest, global::Google.Cloud.Redis.V1Beta1.ListInstancesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListInstances",
        __Marshaller_ListInstancesRequest,
        __Marshaller_ListInstancesResponse);

    static readonly grpc::Method<global::Google.Cloud.Redis.V1Beta1.GetInstanceRequest, global::Google.Cloud.Redis.V1Beta1.Instance> __Method_GetInstance = new grpc::Method<global::Google.Cloud.Redis.V1Beta1.GetInstanceRequest, global::Google.Cloud.Redis.V1Beta1.Instance>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetInstance",
        __Marshaller_GetInstanceRequest,
        __Marshaller_Instance);

    static readonly grpc::Method<global::Google.Cloud.Redis.V1Beta1.CreateInstanceRequest, global::Google.LongRunning.Operation> __Method_CreateInstance = new grpc::Method<global::Google.Cloud.Redis.V1Beta1.CreateInstanceRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateInstance",
        __Marshaller_CreateInstanceRequest,
        __Marshaller_Operation);

    static readonly grpc::Method<global::Google.Cloud.Redis.V1Beta1.UpdateInstanceRequest, global::Google.LongRunning.Operation> __Method_UpdateInstance = new grpc::Method<global::Google.Cloud.Redis.V1Beta1.UpdateInstanceRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateInstance",
        __Marshaller_UpdateInstanceRequest,
        __Marshaller_Operation);

    static readonly grpc::Method<global::Google.Cloud.Redis.V1Beta1.DeleteInstanceRequest, global::Google.LongRunning.Operation> __Method_DeleteInstance = new grpc::Method<global::Google.Cloud.Redis.V1Beta1.DeleteInstanceRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteInstance",
        __Marshaller_DeleteInstanceRequest,
        __Marshaller_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Redis.V1Beta1.CloudRedisReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CloudRedis</summary>
    public abstract partial class CloudRedisBase
    {
      /// <summary>
      /// Lists all Redis instances owned by a project in either the specified
      /// location (region) or all locations.
      ///
      /// The location should have the following format:
      /// * `projects/{project_id}/locations/{location_id}`
      ///
      /// If `location_id` is specified as `-` (wildcard), then all regions
      /// available to the project are queried, and the results are aggregated.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Redis.V1Beta1.ListInstancesResponse> ListInstances(global::Google.Cloud.Redis.V1Beta1.ListInstancesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets the details of a specific Redis instance.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Redis.V1Beta1.Instance> GetInstance(global::Google.Cloud.Redis.V1Beta1.GetInstanceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a Redis instance based on the specified tier and memory size.
      ///
      /// By default, the instance is peered to the project's
      /// [default network](/compute/docs/networks-and-firewalls#networks).
      ///
      /// The creation is executed asynchronously and callers may check the returned
      /// operation to track its progress. Once the operation is completed the Redis
      /// instance will be fully functional. Completed longrunning.Operation will
      /// contain the new instance object in the response field.
      ///
      /// The returned operation is automatically deleted after a few hours, so there
      /// is no need to call DeleteOperation.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> CreateInstance(global::Google.Cloud.Redis.V1Beta1.CreateInstanceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates the metadata and configuration of a specific Redis instance.
      ///
      /// Completed longrunning.Operation will contain the new instance object
      /// in the response field. The returned operation is automatically deleted
      /// after a few hours, so there is no need to call DeleteOperation.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> UpdateInstance(global::Google.Cloud.Redis.V1Beta1.UpdateInstanceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes a specific Redis instance.  Instance stops serving and data is
      /// deleted.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> DeleteInstance(global::Google.Cloud.Redis.V1Beta1.DeleteInstanceRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CloudRedis</summary>
    public partial class CloudRedisClient : grpc::ClientBase<CloudRedisClient>
    {
      /// <summary>Creates a new client for CloudRedis</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CloudRedisClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CloudRedis that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CloudRedisClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CloudRedisClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CloudRedisClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists all Redis instances owned by a project in either the specified
      /// location (region) or all locations.
      ///
      /// The location should have the following format:
      /// * `projects/{project_id}/locations/{location_id}`
      ///
      /// If `location_id` is specified as `-` (wildcard), then all regions
      /// available to the project are queried, and the results are aggregated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Redis.V1Beta1.ListInstancesResponse ListInstances(global::Google.Cloud.Redis.V1Beta1.ListInstancesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListInstances(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all Redis instances owned by a project in either the specified
      /// location (region) or all locations.
      ///
      /// The location should have the following format:
      /// * `projects/{project_id}/locations/{location_id}`
      ///
      /// If `location_id` is specified as `-` (wildcard), then all regions
      /// available to the project are queried, and the results are aggregated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Redis.V1Beta1.ListInstancesResponse ListInstances(global::Google.Cloud.Redis.V1Beta1.ListInstancesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListInstances, null, options, request);
      }
      /// <summary>
      /// Lists all Redis instances owned by a project in either the specified
      /// location (region) or all locations.
      ///
      /// The location should have the following format:
      /// * `projects/{project_id}/locations/{location_id}`
      ///
      /// If `location_id` is specified as `-` (wildcard), then all regions
      /// available to the project are queried, and the results are aggregated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Redis.V1Beta1.ListInstancesResponse> ListInstancesAsync(global::Google.Cloud.Redis.V1Beta1.ListInstancesRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ListInstancesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists all Redis instances owned by a project in either the specified
      /// location (region) or all locations.
      ///
      /// The location should have the following format:
      /// * `projects/{project_id}/locations/{location_id}`
      ///
      /// If `location_id` is specified as `-` (wildcard), then all regions
      /// available to the project are queried, and the results are aggregated.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Redis.V1Beta1.ListInstancesResponse> ListInstancesAsync(global::Google.Cloud.Redis.V1Beta1.ListInstancesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListInstances, null, options, request);
      }
      /// <summary>
      /// Gets the details of a specific Redis instance.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Redis.V1Beta1.Instance GetInstance(global::Google.Cloud.Redis.V1Beta1.GetInstanceRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetInstance(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the details of a specific Redis instance.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Redis.V1Beta1.Instance GetInstance(global::Google.Cloud.Redis.V1Beta1.GetInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetInstance, null, options, request);
      }
      /// <summary>
      /// Gets the details of a specific Redis instance.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Redis.V1Beta1.Instance> GetInstanceAsync(global::Google.Cloud.Redis.V1Beta1.GetInstanceRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetInstanceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the details of a specific Redis instance.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Redis.V1Beta1.Instance> GetInstanceAsync(global::Google.Cloud.Redis.V1Beta1.GetInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetInstance, null, options, request);
      }
      /// <summary>
      /// Creates a Redis instance based on the specified tier and memory size.
      ///
      /// By default, the instance is peered to the project's
      /// [default network](/compute/docs/networks-and-firewalls#networks).
      ///
      /// The creation is executed asynchronously and callers may check the returned
      /// operation to track its progress. Once the operation is completed the Redis
      /// instance will be fully functional. Completed longrunning.Operation will
      /// contain the new instance object in the response field.
      ///
      /// The returned operation is automatically deleted after a few hours, so there
      /// is no need to call DeleteOperation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation CreateInstance(global::Google.Cloud.Redis.V1Beta1.CreateInstanceRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateInstance(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a Redis instance based on the specified tier and memory size.
      ///
      /// By default, the instance is peered to the project's
      /// [default network](/compute/docs/networks-and-firewalls#networks).
      ///
      /// The creation is executed asynchronously and callers may check the returned
      /// operation to track its progress. Once the operation is completed the Redis
      /// instance will be fully functional. Completed longrunning.Operation will
      /// contain the new instance object in the response field.
      ///
      /// The returned operation is automatically deleted after a few hours, so there
      /// is no need to call DeleteOperation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation CreateInstance(global::Google.Cloud.Redis.V1Beta1.CreateInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateInstance, null, options, request);
      }
      /// <summary>
      /// Creates a Redis instance based on the specified tier and memory size.
      ///
      /// By default, the instance is peered to the project's
      /// [default network](/compute/docs/networks-and-firewalls#networks).
      ///
      /// The creation is executed asynchronously and callers may check the returned
      /// operation to track its progress. Once the operation is completed the Redis
      /// instance will be fully functional. Completed longrunning.Operation will
      /// contain the new instance object in the response field.
      ///
      /// The returned operation is automatically deleted after a few hours, so there
      /// is no need to call DeleteOperation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateInstanceAsync(global::Google.Cloud.Redis.V1Beta1.CreateInstanceRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateInstanceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a Redis instance based on the specified tier and memory size.
      ///
      /// By default, the instance is peered to the project's
      /// [default network](/compute/docs/networks-and-firewalls#networks).
      ///
      /// The creation is executed asynchronously and callers may check the returned
      /// operation to track its progress. Once the operation is completed the Redis
      /// instance will be fully functional. Completed longrunning.Operation will
      /// contain the new instance object in the response field.
      ///
      /// The returned operation is automatically deleted after a few hours, so there
      /// is no need to call DeleteOperation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateInstanceAsync(global::Google.Cloud.Redis.V1Beta1.CreateInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateInstance, null, options, request);
      }
      /// <summary>
      /// Updates the metadata and configuration of a specific Redis instance.
      ///
      /// Completed longrunning.Operation will contain the new instance object
      /// in the response field. The returned operation is automatically deleted
      /// after a few hours, so there is no need to call DeleteOperation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation UpdateInstance(global::Google.Cloud.Redis.V1Beta1.UpdateInstanceRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateInstance(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the metadata and configuration of a specific Redis instance.
      ///
      /// Completed longrunning.Operation will contain the new instance object
      /// in the response field. The returned operation is automatically deleted
      /// after a few hours, so there is no need to call DeleteOperation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation UpdateInstance(global::Google.Cloud.Redis.V1Beta1.UpdateInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateInstance, null, options, request);
      }
      /// <summary>
      /// Updates the metadata and configuration of a specific Redis instance.
      ///
      /// Completed longrunning.Operation will contain the new instance object
      /// in the response field. The returned operation is automatically deleted
      /// after a few hours, so there is no need to call DeleteOperation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> UpdateInstanceAsync(global::Google.Cloud.Redis.V1Beta1.UpdateInstanceRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateInstanceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the metadata and configuration of a specific Redis instance.
      ///
      /// Completed longrunning.Operation will contain the new instance object
      /// in the response field. The returned operation is automatically deleted
      /// after a few hours, so there is no need to call DeleteOperation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> UpdateInstanceAsync(global::Google.Cloud.Redis.V1Beta1.UpdateInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateInstance, null, options, request);
      }
      /// <summary>
      /// Deletes a specific Redis instance.  Instance stops serving and data is
      /// deleted.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation DeleteInstance(global::Google.Cloud.Redis.V1Beta1.DeleteInstanceRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteInstance(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a specific Redis instance.  Instance stops serving and data is
      /// deleted.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation DeleteInstance(global::Google.Cloud.Redis.V1Beta1.DeleteInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteInstance, null, options, request);
      }
      /// <summary>
      /// Deletes a specific Redis instance.  Instance stops serving and data is
      /// deleted.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteInstanceAsync(global::Google.Cloud.Redis.V1Beta1.DeleteInstanceRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteInstanceAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a specific Redis instance.  Instance stops serving and data is
      /// deleted.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteInstanceAsync(global::Google.Cloud.Redis.V1Beta1.DeleteInstanceRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteInstance, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CloudRedisClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CloudRedisClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CloudRedisBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListInstances, serviceImpl.ListInstances)
          .AddMethod(__Method_GetInstance, serviceImpl.GetInstance)
          .AddMethod(__Method_CreateInstance, serviceImpl.CreateInstance)
          .AddMethod(__Method_UpdateInstance, serviceImpl.UpdateInstance)
          .AddMethod(__Method_DeleteInstance, serviceImpl.DeleteInstance).Build();
    }

  }
}
#endregion
