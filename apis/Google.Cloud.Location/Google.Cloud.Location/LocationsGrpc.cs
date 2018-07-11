// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/location/locations.proto
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

using grpc = global::Grpc.Core;

namespace Google.Cloud.Location {
  /// <summary>
  /// An abstract interface that provides location-related information for
  /// a service. Service-specific metadata is provided through the
  /// [Location.metadata][google.cloud.location.Location.metadata] field.
  /// </summary>
  public static partial class Locations
  {
    static readonly string __ServiceName = "google.cloud.location.Locations";

    static readonly grpc::Marshaller<global::Google.Cloud.Location.ListLocationsRequest> __Marshaller_ListLocationsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Location.ListLocationsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Location.ListLocationsResponse> __Marshaller_ListLocationsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Location.ListLocationsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Location.GetLocationRequest> __Marshaller_GetLocationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Location.GetLocationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Location.Location> __Marshaller_Location = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Location.Location.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Location.ListLocationsRequest, global::Google.Cloud.Location.ListLocationsResponse> __Method_ListLocations = new grpc::Method<global::Google.Cloud.Location.ListLocationsRequest, global::Google.Cloud.Location.ListLocationsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListLocations",
        __Marshaller_ListLocationsRequest,
        __Marshaller_ListLocationsResponse);

    static readonly grpc::Method<global::Google.Cloud.Location.GetLocationRequest, global::Google.Cloud.Location.Location> __Method_GetLocation = new grpc::Method<global::Google.Cloud.Location.GetLocationRequest, global::Google.Cloud.Location.Location>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetLocation",
        __Marshaller_GetLocationRequest,
        __Marshaller_Location);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Location.LocationsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Locations</summary>
    public abstract partial class LocationsBase
    {
      /// <summary>
      /// Lists information about the supported locations for this service.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Location.ListLocationsResponse> ListLocations(global::Google.Cloud.Location.ListLocationsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets information about a location.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Location.Location> GetLocation(global::Google.Cloud.Location.GetLocationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Locations</summary>
    public partial class LocationsClient : grpc::ClientBase<LocationsClient>
    {
      /// <summary>Creates a new client for Locations</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public LocationsClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Locations that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public LocationsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected LocationsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected LocationsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists information about the supported locations for this service.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Location.ListLocationsResponse ListLocations(global::Google.Cloud.Location.ListLocationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListLocations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists information about the supported locations for this service.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Location.ListLocationsResponse ListLocations(global::Google.Cloud.Location.ListLocationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListLocations, null, options, request);
      }
      /// <summary>
      /// Lists information about the supported locations for this service.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Location.ListLocationsResponse> ListLocationsAsync(global::Google.Cloud.Location.ListLocationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListLocationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists information about the supported locations for this service.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Location.ListLocationsResponse> ListLocationsAsync(global::Google.Cloud.Location.ListLocationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListLocations, null, options, request);
      }
      /// <summary>
      /// Gets information about a location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Location.Location GetLocation(global::Google.Cloud.Location.GetLocationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLocation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets information about a location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Location.Location GetLocation(global::Google.Cloud.Location.GetLocationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetLocation, null, options, request);
      }
      /// <summary>
      /// Gets information about a location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Location.Location> GetLocationAsync(global::Google.Cloud.Location.GetLocationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetLocationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets information about a location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Location.Location> GetLocationAsync(global::Google.Cloud.Location.GetLocationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetLocation, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override LocationsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LocationsClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(LocationsBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListLocations, serviceImpl.ListLocations)
          .AddMethod(__Method_GetLocation, serviceImpl.GetLocation).Build();
    }

  }
}
#endregion
