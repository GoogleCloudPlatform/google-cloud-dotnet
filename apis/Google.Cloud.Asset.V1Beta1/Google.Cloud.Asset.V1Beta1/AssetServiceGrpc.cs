// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/asset/v1beta1/asset_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2018 Google LLC.
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
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Asset.V1Beta1 {
  /// <summary>
  /// Asset service definition.
  /// </summary>
  public static partial class AssetService
  {
    static readonly string __ServiceName = "google.cloud.asset.v1beta1.AssetService";

    static readonly grpc::Marshaller<global::Google.Cloud.Asset.V1Beta1.ExportAssetsRequest> __Marshaller_ExportAssetsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Asset.V1Beta1.ExportAssetsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.LongRunning.Operation.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryRequest> __Marshaller_BatchGetAssetsHistoryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryResponse> __Marshaller_BatchGetAssetsHistoryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Asset.V1Beta1.ExportAssetsRequest, global::Google.LongRunning.Operation> __Method_ExportAssets = new grpc::Method<global::Google.Cloud.Asset.V1Beta1.ExportAssetsRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ExportAssets",
        __Marshaller_ExportAssetsRequest,
        __Marshaller_Operation);

    static readonly grpc::Method<global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryRequest, global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryResponse> __Method_BatchGetAssetsHistory = new grpc::Method<global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryRequest, global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "BatchGetAssetsHistory",
        __Marshaller_BatchGetAssetsHistoryRequest,
        __Marshaller_BatchGetAssetsHistoryResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Asset.V1Beta1.AssetServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AssetService</summary>
    public abstract partial class AssetServiceBase
    {
      /// <summary>
      /// Exports assets with time and resource types to a given Cloud Storage
      /// location. The output format is newline-delimited JSON.
      /// This API implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you
      /// to keep track of the export.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> ExportAssets(global::Google.Cloud.Asset.V1Beta1.ExportAssetsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Batch gets the update history of assets that overlap a time window.
      /// For RESOURCE content, this API outputs history with asset in both
      /// non-delete or deleted status.
      /// For IAM_POLICY content, this API outputs history when the asset and its
      /// attached IAM POLICY both exist. This can create gaps in the output history.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryResponse> BatchGetAssetsHistory(global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AssetService</summary>
    public partial class AssetServiceClient : grpc::ClientBase<AssetServiceClient>
    {
      /// <summary>Creates a new client for AssetService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AssetServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AssetService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AssetServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AssetServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AssetServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Exports assets with time and resource types to a given Cloud Storage
      /// location. The output format is newline-delimited JSON.
      /// This API implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you
      /// to keep track of the export.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation ExportAssets(global::Google.Cloud.Asset.V1Beta1.ExportAssetsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ExportAssets(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Exports assets with time and resource types to a given Cloud Storage
      /// location. The output format is newline-delimited JSON.
      /// This API implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you
      /// to keep track of the export.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation ExportAssets(global::Google.Cloud.Asset.V1Beta1.ExportAssetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ExportAssets, null, options, request);
      }
      /// <summary>
      /// Exports assets with time and resource types to a given Cloud Storage
      /// location. The output format is newline-delimited JSON.
      /// This API implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you
      /// to keep track of the export.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> ExportAssetsAsync(global::Google.Cloud.Asset.V1Beta1.ExportAssetsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ExportAssetsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Exports assets with time and resource types to a given Cloud Storage
      /// location. The output format is newline-delimited JSON.
      /// This API implements the [google.longrunning.Operation][google.longrunning.Operation] API allowing you
      /// to keep track of the export.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> ExportAssetsAsync(global::Google.Cloud.Asset.V1Beta1.ExportAssetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ExportAssets, null, options, request);
      }
      /// <summary>
      /// Batch gets the update history of assets that overlap a time window.
      /// For RESOURCE content, this API outputs history with asset in both
      /// non-delete or deleted status.
      /// For IAM_POLICY content, this API outputs history when the asset and its
      /// attached IAM POLICY both exist. This can create gaps in the output history.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryResponse BatchGetAssetsHistory(global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BatchGetAssetsHistory(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Batch gets the update history of assets that overlap a time window.
      /// For RESOURCE content, this API outputs history with asset in both
      /// non-delete or deleted status.
      /// For IAM_POLICY content, this API outputs history when the asset and its
      /// attached IAM POLICY both exist. This can create gaps in the output history.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryResponse BatchGetAssetsHistory(global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_BatchGetAssetsHistory, null, options, request);
      }
      /// <summary>
      /// Batch gets the update history of assets that overlap a time window.
      /// For RESOURCE content, this API outputs history with asset in both
      /// non-delete or deleted status.
      /// For IAM_POLICY content, this API outputs history when the asset and its
      /// attached IAM POLICY both exist. This can create gaps in the output history.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryResponse> BatchGetAssetsHistoryAsync(global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return BatchGetAssetsHistoryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Batch gets the update history of assets that overlap a time window.
      /// For RESOURCE content, this API outputs history with asset in both
      /// non-delete or deleted status.
      /// For IAM_POLICY content, this API outputs history when the asset and its
      /// attached IAM POLICY both exist. This can create gaps in the output history.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryResponse> BatchGetAssetsHistoryAsync(global::Google.Cloud.Asset.V1Beta1.BatchGetAssetsHistoryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_BatchGetAssetsHistory, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AssetServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AssetServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AssetServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ExportAssets, serviceImpl.ExportAssets)
          .AddMethod(__Method_BatchGetAssetsHistory, serviceImpl.BatchGetAssetsHistory).Build();
    }

  }
}
#endregion
