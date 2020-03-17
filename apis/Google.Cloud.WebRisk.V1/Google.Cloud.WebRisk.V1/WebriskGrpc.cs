// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/webrisk/v1/webrisk.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
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

namespace Google.Cloud.WebRisk.V1 {
  /// <summary>
  /// Web Risk API defines an interface to detect malicious URLs on your
  /// website and in client applications.
  /// </summary>
  public static partial class WebRiskService
  {
    static readonly string __ServiceName = "google.cloud.webrisk.v1.WebRiskService";

    static readonly grpc::Marshaller<global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffRequest> __Marshaller_google_cloud_webrisk_v1_ComputeThreatListDiffRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffResponse> __Marshaller_google_cloud_webrisk_v1_ComputeThreatListDiffResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.WebRisk.V1.SearchUrisRequest> __Marshaller_google_cloud_webrisk_v1_SearchUrisRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.WebRisk.V1.SearchUrisRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.WebRisk.V1.SearchUrisResponse> __Marshaller_google_cloud_webrisk_v1_SearchUrisResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.WebRisk.V1.SearchUrisResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.WebRisk.V1.SearchHashesRequest> __Marshaller_google_cloud_webrisk_v1_SearchHashesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.WebRisk.V1.SearchHashesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.WebRisk.V1.SearchHashesResponse> __Marshaller_google_cloud_webrisk_v1_SearchHashesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.WebRisk.V1.SearchHashesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.WebRisk.V1.CreateSubmissionRequest> __Marshaller_google_cloud_webrisk_v1_CreateSubmissionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.WebRisk.V1.CreateSubmissionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.WebRisk.V1.Submission> __Marshaller_google_cloud_webrisk_v1_Submission = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.WebRisk.V1.Submission.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffRequest, global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffResponse> __Method_ComputeThreatListDiff = new grpc::Method<global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffRequest, global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ComputeThreatListDiff",
        __Marshaller_google_cloud_webrisk_v1_ComputeThreatListDiffRequest,
        __Marshaller_google_cloud_webrisk_v1_ComputeThreatListDiffResponse);

    static readonly grpc::Method<global::Google.Cloud.WebRisk.V1.SearchUrisRequest, global::Google.Cloud.WebRisk.V1.SearchUrisResponse> __Method_SearchUris = new grpc::Method<global::Google.Cloud.WebRisk.V1.SearchUrisRequest, global::Google.Cloud.WebRisk.V1.SearchUrisResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SearchUris",
        __Marshaller_google_cloud_webrisk_v1_SearchUrisRequest,
        __Marshaller_google_cloud_webrisk_v1_SearchUrisResponse);

    static readonly grpc::Method<global::Google.Cloud.WebRisk.V1.SearchHashesRequest, global::Google.Cloud.WebRisk.V1.SearchHashesResponse> __Method_SearchHashes = new grpc::Method<global::Google.Cloud.WebRisk.V1.SearchHashesRequest, global::Google.Cloud.WebRisk.V1.SearchHashesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SearchHashes",
        __Marshaller_google_cloud_webrisk_v1_SearchHashesRequest,
        __Marshaller_google_cloud_webrisk_v1_SearchHashesResponse);

    static readonly grpc::Method<global::Google.Cloud.WebRisk.V1.CreateSubmissionRequest, global::Google.Cloud.WebRisk.V1.Submission> __Method_CreateSubmission = new grpc::Method<global::Google.Cloud.WebRisk.V1.CreateSubmissionRequest, global::Google.Cloud.WebRisk.V1.Submission>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateSubmission",
        __Marshaller_google_cloud_webrisk_v1_CreateSubmissionRequest,
        __Marshaller_google_cloud_webrisk_v1_Submission);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.WebRisk.V1.WebriskReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of WebRiskService</summary>
    [grpc::BindServiceMethod(typeof(WebRiskService), "BindService")]
    public abstract partial class WebRiskServiceBase
    {
      /// <summary>
      /// Gets the most recent threat list diffs. These diffs should be applied to
      /// a local database of hashes to keep it up-to-date. If the local database is
      /// empty or excessively out-of-date, a complete snapshot of the database will
      /// be returned. This Method only updates a single ThreatList at a time. To
      /// update multiple ThreatList databases, this method needs to be called once
      /// for each list.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffResponse> ComputeThreatListDiff(global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// This method is used to check whether a URI is on a given threatList.
      /// Multiple threatLists may be searched in a single query.
      /// The response will list all requested threatLists the URI was found to
      /// match. If the URI is not found on any of the requested ThreatList an
      /// empty response will be returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.WebRisk.V1.SearchUrisResponse> SearchUris(global::Google.Cloud.WebRisk.V1.SearchUrisRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets the full hashes that match the requested hash prefix.
      /// This is used after a hash prefix is looked up in a threatList
      /// and there is a match. The client side threatList only holds partial hashes
      /// so the client must query this method to determine if there is a full
      /// hash match of a threat.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.WebRisk.V1.SearchHashesResponse> SearchHashes(global::Google.Cloud.WebRisk.V1.SearchHashesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a Submission of a URI suspected of containing phishing content to
      /// be reviewed. If the result verifies the existence of malicious phishing
      /// content, the site will be added to the [Google's Social Engineering
      /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
      /// protect users that could get exposed to this threat in the future. Only
      /// projects with CREATE_SUBMISSION_USERS visibility can use this method.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.WebRisk.V1.Submission> CreateSubmission(global::Google.Cloud.WebRisk.V1.CreateSubmissionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for WebRiskService</summary>
    public partial class WebRiskServiceClient : grpc::ClientBase<WebRiskServiceClient>
    {
      /// <summary>Creates a new client for WebRiskService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public WebRiskServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for WebRiskService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public WebRiskServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected WebRiskServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected WebRiskServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Gets the most recent threat list diffs. These diffs should be applied to
      /// a local database of hashes to keep it up-to-date. If the local database is
      /// empty or excessively out-of-date, a complete snapshot of the database will
      /// be returned. This Method only updates a single ThreatList at a time. To
      /// update multiple ThreatList databases, this method needs to be called once
      /// for each list.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffResponse ComputeThreatListDiff(global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ComputeThreatListDiff(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the most recent threat list diffs. These diffs should be applied to
      /// a local database of hashes to keep it up-to-date. If the local database is
      /// empty or excessively out-of-date, a complete snapshot of the database will
      /// be returned. This Method only updates a single ThreatList at a time. To
      /// update multiple ThreatList databases, this method needs to be called once
      /// for each list.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffResponse ComputeThreatListDiff(global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ComputeThreatListDiff, null, options, request);
      }
      /// <summary>
      /// Gets the most recent threat list diffs. These diffs should be applied to
      /// a local database of hashes to keep it up-to-date. If the local database is
      /// empty or excessively out-of-date, a complete snapshot of the database will
      /// be returned. This Method only updates a single ThreatList at a time. To
      /// update multiple ThreatList databases, this method needs to be called once
      /// for each list.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffResponse> ComputeThreatListDiffAsync(global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ComputeThreatListDiffAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the most recent threat list diffs. These diffs should be applied to
      /// a local database of hashes to keep it up-to-date. If the local database is
      /// empty or excessively out-of-date, a complete snapshot of the database will
      /// be returned. This Method only updates a single ThreatList at a time. To
      /// update multiple ThreatList databases, this method needs to be called once
      /// for each list.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffResponse> ComputeThreatListDiffAsync(global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ComputeThreatListDiff, null, options, request);
      }
      /// <summary>
      /// This method is used to check whether a URI is on a given threatList.
      /// Multiple threatLists may be searched in a single query.
      /// The response will list all requested threatLists the URI was found to
      /// match. If the URI is not found on any of the requested ThreatList an
      /// empty response will be returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.WebRisk.V1.SearchUrisResponse SearchUris(global::Google.Cloud.WebRisk.V1.SearchUrisRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchUris(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// This method is used to check whether a URI is on a given threatList.
      /// Multiple threatLists may be searched in a single query.
      /// The response will list all requested threatLists the URI was found to
      /// match. If the URI is not found on any of the requested ThreatList an
      /// empty response will be returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.WebRisk.V1.SearchUrisResponse SearchUris(global::Google.Cloud.WebRisk.V1.SearchUrisRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchUris, null, options, request);
      }
      /// <summary>
      /// This method is used to check whether a URI is on a given threatList.
      /// Multiple threatLists may be searched in a single query.
      /// The response will list all requested threatLists the URI was found to
      /// match. If the URI is not found on any of the requested ThreatList an
      /// empty response will be returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.WebRisk.V1.SearchUrisResponse> SearchUrisAsync(global::Google.Cloud.WebRisk.V1.SearchUrisRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchUrisAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// This method is used to check whether a URI is on a given threatList.
      /// Multiple threatLists may be searched in a single query.
      /// The response will list all requested threatLists the URI was found to
      /// match. If the URI is not found on any of the requested ThreatList an
      /// empty response will be returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.WebRisk.V1.SearchUrisResponse> SearchUrisAsync(global::Google.Cloud.WebRisk.V1.SearchUrisRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchUris, null, options, request);
      }
      /// <summary>
      /// Gets the full hashes that match the requested hash prefix.
      /// This is used after a hash prefix is looked up in a threatList
      /// and there is a match. The client side threatList only holds partial hashes
      /// so the client must query this method to determine if there is a full
      /// hash match of a threat.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.WebRisk.V1.SearchHashesResponse SearchHashes(global::Google.Cloud.WebRisk.V1.SearchHashesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchHashes(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the full hashes that match the requested hash prefix.
      /// This is used after a hash prefix is looked up in a threatList
      /// and there is a match. The client side threatList only holds partial hashes
      /// so the client must query this method to determine if there is a full
      /// hash match of a threat.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.WebRisk.V1.SearchHashesResponse SearchHashes(global::Google.Cloud.WebRisk.V1.SearchHashesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchHashes, null, options, request);
      }
      /// <summary>
      /// Gets the full hashes that match the requested hash prefix.
      /// This is used after a hash prefix is looked up in a threatList
      /// and there is a match. The client side threatList only holds partial hashes
      /// so the client must query this method to determine if there is a full
      /// hash match of a threat.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.WebRisk.V1.SearchHashesResponse> SearchHashesAsync(global::Google.Cloud.WebRisk.V1.SearchHashesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchHashesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets the full hashes that match the requested hash prefix.
      /// This is used after a hash prefix is looked up in a threatList
      /// and there is a match. The client side threatList only holds partial hashes
      /// so the client must query this method to determine if there is a full
      /// hash match of a threat.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.WebRisk.V1.SearchHashesResponse> SearchHashesAsync(global::Google.Cloud.WebRisk.V1.SearchHashesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchHashes, null, options, request);
      }
      /// <summary>
      /// Creates a Submission of a URI suspected of containing phishing content to
      /// be reviewed. If the result verifies the existence of malicious phishing
      /// content, the site will be added to the [Google's Social Engineering
      /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
      /// protect users that could get exposed to this threat in the future. Only
      /// projects with CREATE_SUBMISSION_USERS visibility can use this method.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.WebRisk.V1.Submission CreateSubmission(global::Google.Cloud.WebRisk.V1.CreateSubmissionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateSubmission(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a Submission of a URI suspected of containing phishing content to
      /// be reviewed. If the result verifies the existence of malicious phishing
      /// content, the site will be added to the [Google's Social Engineering
      /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
      /// protect users that could get exposed to this threat in the future. Only
      /// projects with CREATE_SUBMISSION_USERS visibility can use this method.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.WebRisk.V1.Submission CreateSubmission(global::Google.Cloud.WebRisk.V1.CreateSubmissionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateSubmission, null, options, request);
      }
      /// <summary>
      /// Creates a Submission of a URI suspected of containing phishing content to
      /// be reviewed. If the result verifies the existence of malicious phishing
      /// content, the site will be added to the [Google's Social Engineering
      /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
      /// protect users that could get exposed to this threat in the future. Only
      /// projects with CREATE_SUBMISSION_USERS visibility can use this method.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.WebRisk.V1.Submission> CreateSubmissionAsync(global::Google.Cloud.WebRisk.V1.CreateSubmissionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateSubmissionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a Submission of a URI suspected of containing phishing content to
      /// be reviewed. If the result verifies the existence of malicious phishing
      /// content, the site will be added to the [Google's Social Engineering
      /// lists](https://support.google.com/webmasters/answer/6350487/) in order to
      /// protect users that could get exposed to this threat in the future. Only
      /// projects with CREATE_SUBMISSION_USERS visibility can use this method.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.WebRisk.V1.Submission> CreateSubmissionAsync(global::Google.Cloud.WebRisk.V1.CreateSubmissionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateSubmission, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override WebRiskServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new WebRiskServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(WebRiskServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ComputeThreatListDiff, serviceImpl.ComputeThreatListDiff)
          .AddMethod(__Method_SearchUris, serviceImpl.SearchUris)
          .AddMethod(__Method_SearchHashes, serviceImpl.SearchHashes)
          .AddMethod(__Method_CreateSubmission, serviceImpl.CreateSubmission).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, WebRiskServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ComputeThreatListDiff, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffRequest, global::Google.Cloud.WebRisk.V1.ComputeThreatListDiffResponse>(serviceImpl.ComputeThreatListDiff));
      serviceBinder.AddMethod(__Method_SearchUris, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.WebRisk.V1.SearchUrisRequest, global::Google.Cloud.WebRisk.V1.SearchUrisResponse>(serviceImpl.SearchUris));
      serviceBinder.AddMethod(__Method_SearchHashes, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.WebRisk.V1.SearchHashesRequest, global::Google.Cloud.WebRisk.V1.SearchHashesResponse>(serviceImpl.SearchHashes));
      serviceBinder.AddMethod(__Method_CreateSubmission, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.WebRisk.V1.CreateSubmissionRequest, global::Google.Cloud.WebRisk.V1.Submission>(serviceImpl.CreateSubmission));
    }

  }
}
#endregion
