// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using sysnet = System.Net;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.RecaptchaEnterprise.V1Beta1
{
    /// <summary>Settings for <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/> instances.</summary>
    public sealed partial class RecaptchaEnterpriseServiceV1Beta1Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/>.</returns>
        public static RecaptchaEnterpriseServiceV1Beta1Settings GetDefault() =>
            new RecaptchaEnterpriseServiceV1Beta1Settings();

        /// <summary>
        /// Constructs a new <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/> object with default settings.
        /// </summary>
        public RecaptchaEnterpriseServiceV1Beta1Settings()
        {
        }

        private RecaptchaEnterpriseServiceV1Beta1Settings(RecaptchaEnterpriseServiceV1Beta1Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateAssessmentSettings = existing.CreateAssessmentSettings;
            AnnotateAssessmentSettings = existing.AnnotateAssessmentSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RecaptchaEnterpriseServiceV1Beta1Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceV1Beta1Client.CreateAssessment</c> and
        /// <c>RecaptchaEnterpriseServiceV1Beta1Client.CreateAssessmentAsync</c>.
        /// </summary>
        /// <remarks>By default, retry will not be attempted.</remarks>
        public gaxgrpc::CallSettings CreateAssessmentSettings { get; set; }

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RecaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessment</c> and
        /// <c>RecaptchaEnterpriseServiceV1Beta1Client.AnnotateAssessmentAsync</c>.
        /// </summary>
        /// <remarks>By default, retry will not be attempted.</remarks>
        public gaxgrpc::CallSettings AnnotateAssessmentSettings { get; set; }

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/> object.</returns>
        public RecaptchaEnterpriseServiceV1Beta1Settings Clone() => new RecaptchaEnterpriseServiceV1Beta1Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class RecaptchaEnterpriseServiceV1Beta1ClientBuilder : gaxgrpc::ClientBuilderBase<RecaptchaEnterpriseServiceV1Beta1Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RecaptchaEnterpriseServiceV1Beta1Settings Settings { get; set; }

        /// <inheritdoc/>
        public override RecaptchaEnterpriseServiceV1Beta1Client Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RecaptchaEnterpriseServiceV1Beta1Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        public override async stt::Task<RecaptchaEnterpriseServiceV1Beta1Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RecaptchaEnterpriseServiceV1Beta1Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc/>
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() =>
            RecaptchaEnterpriseServiceV1Beta1Client.DefaultEndpoint;

        /// <inheritdoc/>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            RecaptchaEnterpriseServiceV1Beta1Client.DefaultScopes;

        /// <inheritdoc/>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RecaptchaEnterpriseServiceV1Beta1Client.ChannelPool;
    }

    /// <summary>RecaptchaEnterpriseServiceV1Beta1 client wrapper, for convenient use.</summary>
    public abstract partial class RecaptchaEnterpriseServiceV1Beta1Client
    {
        /// <summary>
        /// The default endpoint for the RecaptchaEnterpriseServiceV1Beta1 service, which is a host of
        /// "recaptchaenterprise.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("recaptchaenterprise.googleapis.com", 443);

        /// <summary>The default RecaptchaEnterpriseServiceV1Beta1 scopes.</summary>
        /// <remarks>
        /// The default RecaptchaEnterpriseServiceV1Beta1 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/>, applying defaults for all
        /// unspecified settings, and creating a channel connecting to the given endpoint with application default
        /// credentials where necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = await ImageAnnotatorClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/>.</param>
        /// <returns>The task representing the created <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/>.</returns>
        public static async stt::Task<RecaptchaEnterpriseServiceV1Beta1Client> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, RecaptchaEnterpriseServiceV1Beta1Settings settings = null)
        {
            grpccore::Channel channel = await ChannelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/>, applying defaults for all
        /// unspecified settings, and creating a channel connecting to the given endpoint with application default
        /// credentials where necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Vision.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ImageAnnotatorClient.DefaultEndpoint.Host, ImageAnnotatorClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ImageAnnotatorClient client = ImageAnnotatorClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/>.</returns>
        public static RecaptchaEnterpriseServiceV1Beta1Client Create(gaxgrpc::ServiceEndpoint endpoint = null, RecaptchaEnterpriseServiceV1Beta1Settings settings = null)
        {
            grpccore::Channel channel = ChannelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/> which uses the specified channel for remote
        /// operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/>.</returns>
        public static RecaptchaEnterpriseServiceV1Beta1Client Create(grpccore::Channel channel, RecaptchaEnterpriseServiceV1Beta1Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/>.</param>
        /// <returns>The created <see cref="RecaptchaEnterpriseServiceV1Beta1Client"/>.</returns>
        public static RecaptchaEnterpriseServiceV1Beta1Client Create(grpccore::CallInvoker callInvoker, RecaptchaEnterpriseServiceV1Beta1Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client grpcClient = new RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client(callInvoker);
            return new RecaptchaEnterpriseServiceV1Beta1ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by
        /// <see cref="Create(grpccore::CallInvoker,RecaptchaEnterpriseServiceV1Beta1Settings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,RecaptchaEnterpriseServiceV1Beta1Settings)"/>. Channels
        /// which weren't automatically created are not affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to
        /// <see cref="Create(grpccore::CallInvoker,RecaptchaEnterpriseServiceV1Beta1Settings)"/> and
        /// <see cref="CreateAsync(gaxgrpc::ServiceEndpoint,RecaptchaEnterpriseServiceV1Beta1Settings)"/> will create
        /// new channels, which could in turn be shut down by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC RecaptchaEnterpriseServiceV1Beta1 client</summary>
        public virtual RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assessment CreateAssessment(CreateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assessment> CreateAssessmentAsync(CreateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assessment> CreateAssessmentAsync(CreateAssessmentRequest request, st::CancellationToken cancellationToken) =>
            CreateAssessmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which the assessment will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="assessment">
        /// Required. The assessment details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assessment CreateAssessment(string parent, Assessment assessment, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssessment(new CreateAssessmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Assessment = gax::GaxPreconditions.CheckNotNull(assessment, nameof(assessment)),
            }, callSettings);

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which the assessment will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="assessment">
        /// Required. The assessment details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assessment> CreateAssessmentAsync(string parent, Assessment assessment, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssessmentAsync(new CreateAssessmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Assessment = gax::GaxPreconditions.CheckNotNull(assessment, nameof(assessment)),
            }, callSettings);

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which the assessment will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="assessment">
        /// Required. The assessment details.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assessment> CreateAssessmentAsync(string parent, Assessment assessment, st::CancellationToken cancellationToken) =>
            CreateAssessmentAsync(parent, assessment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which the assessment will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="assessment">
        /// Required. The assessment details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Assessment CreateAssessment(gagr::ProjectName parent, Assessment assessment, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssessment(new CreateAssessmentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Assessment = gax::GaxPreconditions.CheckNotNull(assessment, nameof(assessment)),
            }, callSettings);

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which the assessment will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="assessment">
        /// Required. The assessment details.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assessment> CreateAssessmentAsync(gagr::ProjectName parent, Assessment assessment, gaxgrpc::CallSettings callSettings = null) =>
            CreateAssessmentAsync(new CreateAssessmentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Assessment = gax::GaxPreconditions.CheckNotNull(assessment, nameof(assessment)),
            }, callSettings);

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which the assessment will be created,
        /// in the format "projects/{project_number}".
        /// </param>
        /// <param name="assessment">
        /// Required. The assessment details.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Assessment> CreateAssessmentAsync(gagr::ProjectName parent, Assessment assessment, st::CancellationToken cancellationToken) =>
            CreateAssessmentAsync(parent, assessment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotateAssessmentResponse AnnotateAssessment(AnnotateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(AnnotateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(AnnotateAssessmentRequest request, st::CancellationToken cancellationToken) =>
            AnnotateAssessmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// "projects/{project_number}/assessments/{assessment_id}".
        /// </param>
        /// <param name="annotation">
        /// Required. The annotation that will be assigned to the Event.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotateAssessmentResponse AnnotateAssessment(string name, AnnotateAssessmentRequest.Types.Annotation annotation, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateAssessment(new AnnotateAssessmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Annotation = annotation,
            }, callSettings);

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// "projects/{project_number}/assessments/{assessment_id}".
        /// </param>
        /// <param name="annotation">
        /// Required. The annotation that will be assigned to the Event.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(string name, AnnotateAssessmentRequest.Types.Annotation annotation, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateAssessmentAsync(new AnnotateAssessmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Annotation = annotation,
            }, callSettings);

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// "projects/{project_number}/assessments/{assessment_id}".
        /// </param>
        /// <param name="annotation">
        /// Required. The annotation that will be assigned to the Event.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(string name, AnnotateAssessmentRequest.Types.Annotation annotation, st::CancellationToken cancellationToken) =>
            AnnotateAssessmentAsync(name, annotation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// "projects/{project_number}/assessments/{assessment_id}".
        /// </param>
        /// <param name="annotation">
        /// Required. The annotation that will be assigned to the Event.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotateAssessmentResponse AnnotateAssessment(AssessmentName name, AnnotateAssessmentRequest.Types.Annotation annotation, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateAssessment(new AnnotateAssessmentRequest
            {
                AssessmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Annotation = annotation,
            }, callSettings);

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// "projects/{project_number}/assessments/{assessment_id}".
        /// </param>
        /// <param name="annotation">
        /// Required. The annotation that will be assigned to the Event.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(AssessmentName name, AnnotateAssessmentRequest.Types.Annotation annotation, gaxgrpc::CallSettings callSettings = null) =>
            AnnotateAssessmentAsync(new AnnotateAssessmentRequest
            {
                AssessmentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Annotation = annotation,
            }, callSettings);

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Assessment, in the format
        /// "projects/{project_number}/assessments/{assessment_id}".
        /// </param>
        /// <param name="annotation">
        /// Required. The annotation that will be assigned to the Event.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(AssessmentName name, AnnotateAssessmentRequest.Types.Annotation annotation, st::CancellationToken cancellationToken) =>
            AnnotateAssessmentAsync(name, annotation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RecaptchaEnterpriseServiceV1Beta1 client wrapper implementation, for convenient use.</summary>
    public sealed partial class RecaptchaEnterpriseServiceV1Beta1ClientImpl : RecaptchaEnterpriseServiceV1Beta1Client
    {
        private readonly gaxgrpc::ApiCall<CreateAssessmentRequest, Assessment> _callCreateAssessment;

        private readonly gaxgrpc::ApiCall<AnnotateAssessmentRequest, AnnotateAssessmentResponse> _callAnnotateAssessment;

        /// <summary>
        /// Constructs a client wrapper for the RecaptchaEnterpriseServiceV1Beta1 service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RecaptchaEnterpriseServiceV1Beta1Settings"/> used within this client.
        /// </param>
        public RecaptchaEnterpriseServiceV1Beta1ClientImpl(RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client grpcClient, RecaptchaEnterpriseServiceV1Beta1Settings settings)
        {
            GrpcClient = grpcClient;
            RecaptchaEnterpriseServiceV1Beta1Settings effectiveSettings = settings ?? RecaptchaEnterpriseServiceV1Beta1Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callCreateAssessment = clientHelper.BuildApiCall<CreateAssessmentRequest, Assessment>(grpcClient.CreateAssessmentAsync, grpcClient.CreateAssessment, effectiveSettings.CreateAssessmentSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={(sysnet::WebUtility.UrlEncode(request.Parent))}"));
            Modify_ApiCall(ref _callCreateAssessment);
            Modify_CreateAssessmentApiCall(ref _callCreateAssessment);
            _callAnnotateAssessment = clientHelper.BuildApiCall<AnnotateAssessmentRequest, AnnotateAssessmentResponse>(grpcClient.AnnotateAssessmentAsync, grpcClient.AnnotateAssessment, effectiveSettings.AnnotateAssessmentSettings).WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={(sysnet::WebUtility.UrlEncode(request.Name))}"));
            Modify_ApiCall(ref _callAnnotateAssessment);
            Modify_AnnotateAssessmentApiCall(ref _callAnnotateAssessment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateAssessmentApiCall(ref gaxgrpc::ApiCall<CreateAssessmentRequest, Assessment> call);

        partial void Modify_AnnotateAssessmentApiCall(ref gaxgrpc::ApiCall<AnnotateAssessmentRequest, AnnotateAssessmentResponse> call);

        partial void OnConstruction(RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client grpcClient, RecaptchaEnterpriseServiceV1Beta1Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RecaptchaEnterpriseServiceV1Beta1 client</summary>
        public override RecaptchaEnterpriseServiceV1Beta1.RecaptchaEnterpriseServiceV1Beta1Client GrpcClient { get; }

        partial void Modify_CreateAssessmentRequest(ref CreateAssessmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AnnotateAssessmentRequest(ref AnnotateAssessmentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Assessment CreateAssessment(CreateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAssessmentRequest(ref request, ref callSettings);
            return _callCreateAssessment.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an Assessment of the likelihood an event is legitimate.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Assessment> CreateAssessmentAsync(CreateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAssessmentRequest(ref request, ref callSettings);
            return _callCreateAssessment.Async(request, callSettings);
        }

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnnotateAssessmentResponse AnnotateAssessment(AnnotateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnotateAssessmentRequest(ref request, ref callSettings);
            return _callAnnotateAssessment.Sync(request, callSettings);
        }

        /// <summary>
        /// Annotates a previously created Assessment to provide additional information
        /// on whether the event turned out to be authentic or fradulent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnnotateAssessmentResponse> AnnotateAssessmentAsync(AnnotateAssessmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnotateAssessmentRequest(ref request, ref callSettings);
            return _callAnnotateAssessment.Async(request, callSettings);
        }
    }
}
