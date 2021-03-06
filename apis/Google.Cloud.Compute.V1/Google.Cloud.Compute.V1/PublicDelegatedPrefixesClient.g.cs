// Copyright 2021 Google LLC
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

using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="PublicDelegatedPrefixesClient"/> instances.</summary>
    public sealed partial class PublicDelegatedPrefixesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PublicDelegatedPrefixesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PublicDelegatedPrefixesSettings"/>.</returns>
        public static PublicDelegatedPrefixesSettings GetDefault() => new PublicDelegatedPrefixesSettings();

        /// <summary>
        /// Constructs a new <see cref="PublicDelegatedPrefixesSettings"/> object with default settings.
        /// </summary>
        public PublicDelegatedPrefixesSettings()
        {
        }

        private PublicDelegatedPrefixesSettings(PublicDelegatedPrefixesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AggregatedListSettings = existing.AggregatedListSettings;
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            PatchSettings = existing.PatchSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PublicDelegatedPrefixesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicDelegatedPrefixesClient.AggregatedList</c> and <c>PublicDelegatedPrefixesClient.AggregatedListAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AggregatedListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicDelegatedPrefixesClient.Delete</c> and <c>PublicDelegatedPrefixesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicDelegatedPrefixesClient.Get</c> and <c>PublicDelegatedPrefixesClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicDelegatedPrefixesClient.Insert</c> and <c>PublicDelegatedPrefixesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicDelegatedPrefixesClient.List</c> and <c>PublicDelegatedPrefixesClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PublicDelegatedPrefixesClient.Patch</c> and <c>PublicDelegatedPrefixesClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PublicDelegatedPrefixesSettings"/> object.</returns>
        public PublicDelegatedPrefixesSettings Clone() => new PublicDelegatedPrefixesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PublicDelegatedPrefixesClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class PublicDelegatedPrefixesClientBuilder : gaxgrpc::ClientBuilderBase<PublicDelegatedPrefixesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PublicDelegatedPrefixesSettings Settings { get; set; }

        partial void InterceptBuild(ref PublicDelegatedPrefixesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PublicDelegatedPrefixesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PublicDelegatedPrefixesClient Build()
        {
            PublicDelegatedPrefixesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PublicDelegatedPrefixesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PublicDelegatedPrefixesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PublicDelegatedPrefixesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PublicDelegatedPrefixesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<PublicDelegatedPrefixesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PublicDelegatedPrefixesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => PublicDelegatedPrefixesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => PublicDelegatedPrefixesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PublicDelegatedPrefixesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>PublicDelegatedPrefixes client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The PublicDelegatedPrefixes API.
    /// </remarks>
    public abstract partial class PublicDelegatedPrefixesClient
    {
        /// <summary>
        /// The default endpoint for the PublicDelegatedPrefixes service, which is a host of "compute.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default PublicDelegatedPrefixes scopes.</summary>
        /// <remarks>
        /// The default PublicDelegatedPrefixes scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="PublicDelegatedPrefixesClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="PublicDelegatedPrefixesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PublicDelegatedPrefixesClient"/>.</returns>
        public static stt::Task<PublicDelegatedPrefixesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PublicDelegatedPrefixesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PublicDelegatedPrefixesClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="PublicDelegatedPrefixesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PublicDelegatedPrefixesClient"/>.</returns>
        public static PublicDelegatedPrefixesClient Create() => new PublicDelegatedPrefixesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PublicDelegatedPrefixesClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PublicDelegatedPrefixesSettings"/>.</param>
        /// <returns>The created <see cref="PublicDelegatedPrefixesClient"/>.</returns>
        internal static PublicDelegatedPrefixesClient Create(grpccore::CallInvoker callInvoker, PublicDelegatedPrefixesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PublicDelegatedPrefixes.PublicDelegatedPrefixesClient grpcClient = new PublicDelegatedPrefixes.PublicDelegatedPrefixesClient(callInvoker);
            return new PublicDelegatedPrefixesClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC PublicDelegatedPrefixes client</summary>
        public virtual PublicDelegatedPrefixes.PublicDelegatedPrefixesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all PublicDelegatedPrefix resources owned by the specific project across all scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicDelegatedPrefixAggregatedList AggregatedList(AggregatedListPublicDelegatedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all PublicDelegatedPrefix resources owned by the specific project across all scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefixAggregatedList> AggregatedListAsync(AggregatedListPublicDelegatedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all PublicDelegatedPrefix resources owned by the specific project across all scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefixAggregatedList> AggregatedListAsync(AggregatedListPublicDelegatedPrefixesRequest request, st::CancellationToken cancellationToken) =>
            AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all PublicDelegatedPrefix resources owned by the specific project across all scopes.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicDelegatedPrefixAggregatedList AggregatedList(string project, gaxgrpc::CallSettings callSettings = null) =>
            AggregatedList(new AggregatedListPublicDelegatedPrefixesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Lists all PublicDelegatedPrefix resources owned by the specific project across all scopes.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefixAggregatedList> AggregatedListAsync(string project, gaxgrpc::CallSettings callSettings = null) =>
            AggregatedListAsync(new AggregatedListPublicDelegatedPrefixesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Lists all PublicDelegatedPrefix resources owned by the specific project across all scopes.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefixAggregatedList> AggregatedListAsync(string project, st::CancellationToken cancellationToken) =>
            AggregatedListAsync(project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified PublicDelegatedPrefix in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeletePublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified PublicDelegatedPrefix in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeletePublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified PublicDelegatedPrefix in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeletePublicDelegatedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified PublicDelegatedPrefix in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region of this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(string project, string region, string publicDelegatedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeletePublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicDelegatedPrefix, nameof(publicDelegatedPrefix)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified PublicDelegatedPrefix in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region of this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string region, string publicDelegatedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeletePublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicDelegatedPrefix, nameof(publicDelegatedPrefix)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified PublicDelegatedPrefix in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region of this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string region, string publicDelegatedPrefix, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, region, publicDelegatedPrefix, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified PublicDelegatedPrefix resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicDelegatedPrefix Get(GetPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified PublicDelegatedPrefix resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefix> GetAsync(GetPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified PublicDelegatedPrefix resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefix> GetAsync(GetPublicDelegatedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified PublicDelegatedPrefix resource in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region of this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicDelegatedPrefix Get(string project, string region, string publicDelegatedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetPublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicDelegatedPrefix, nameof(publicDelegatedPrefix)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified PublicDelegatedPrefix resource in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region of this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefix> GetAsync(string project, string region, string publicDelegatedPrefix, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetPublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicDelegatedPrefix, nameof(publicDelegatedPrefix)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified PublicDelegatedPrefix resource in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region of this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefix> GetAsync(string project, string region, string publicDelegatedPrefix, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, publicDelegatedPrefix, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a PublicDelegatedPrefix in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a PublicDelegatedPrefix in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a PublicDelegatedPrefix in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertPublicDelegatedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a PublicDelegatedPrefix in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region of this request.
        /// </param>
        /// <param name="publicDelegatedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(string project, string region, PublicDelegatedPrefix publicDelegatedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertPublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefixResource = gax::GaxPreconditions.CheckNotNull(publicDelegatedPrefixResource, nameof(publicDelegatedPrefixResource)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates a PublicDelegatedPrefix in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region of this request.
        /// </param>
        /// <param name="publicDelegatedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, string region, PublicDelegatedPrefix publicDelegatedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertPublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefixResource = gax::GaxPreconditions.CheckNotNull(publicDelegatedPrefixResource, nameof(publicDelegatedPrefixResource)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates a PublicDelegatedPrefix in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region of this request.
        /// </param>
        /// <param name="publicDelegatedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, string region, PublicDelegatedPrefix publicDelegatedPrefixResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, region, publicDelegatedPrefixResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the PublicDelegatedPrefixes for a project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicDelegatedPrefixList List(ListPublicDelegatedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the PublicDelegatedPrefixes for a project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefixList> ListAsync(ListPublicDelegatedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the PublicDelegatedPrefixes for a project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefixList> ListAsync(ListPublicDelegatedPrefixesRequest request, st::CancellationToken cancellationToken) =>
            ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the PublicDelegatedPrefixes for a project in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region of this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PublicDelegatedPrefixList List(string project, string region, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListPublicDelegatedPrefixesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Lists the PublicDelegatedPrefixes for a project in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region of this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefixList> ListAsync(string project, string region, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListPublicDelegatedPrefixesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Lists the PublicDelegatedPrefixes for a project in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region of this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PublicDelegatedPrefixList> ListAsync(string project, string region, st::CancellationToken cancellationToken) =>
            ListAsync(project, region, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the specified PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(PatchPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchPublicDelegatedPrefixeRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the specified PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to patch.
        /// </param>
        /// <param name="publicDelegatedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(string project, string region, string publicDelegatedPrefix, PublicDelegatedPrefix publicDelegatedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchPublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicDelegatedPrefix, nameof(publicDelegatedPrefix)),
                PublicDelegatedPrefixResource = gax::GaxPreconditions.CheckNotNull(publicDelegatedPrefixResource, nameof(publicDelegatedPrefixResource)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Patches the specified PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to patch.
        /// </param>
        /// <param name="publicDelegatedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string project, string region, string publicDelegatedPrefix, PublicDelegatedPrefix publicDelegatedPrefixResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchPublicDelegatedPrefixeRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PublicDelegatedPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(publicDelegatedPrefix, nameof(publicDelegatedPrefix)),
                PublicDelegatedPrefixResource = gax::GaxPreconditions.CheckNotNull(publicDelegatedPrefixResource, nameof(publicDelegatedPrefixResource)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Patches the specified PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="publicDelegatedPrefix">
        /// Name of the PublicDelegatedPrefix resource to patch.
        /// </param>
        /// <param name="publicDelegatedPrefixResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string project, string region, string publicDelegatedPrefix, PublicDelegatedPrefix publicDelegatedPrefixResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, region, publicDelegatedPrefix, publicDelegatedPrefixResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PublicDelegatedPrefixes client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The PublicDelegatedPrefixes API.
    /// </remarks>
    public sealed partial class PublicDelegatedPrefixesClientImpl : PublicDelegatedPrefixesClient
    {
        private readonly gaxgrpc::ApiCall<AggregatedListPublicDelegatedPrefixesRequest, PublicDelegatedPrefixAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<DeletePublicDelegatedPrefixeRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetPublicDelegatedPrefixeRequest, PublicDelegatedPrefix> _callGet;

        private readonly gaxgrpc::ApiCall<InsertPublicDelegatedPrefixeRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListPublicDelegatedPrefixesRequest, PublicDelegatedPrefixList> _callList;

        private readonly gaxgrpc::ApiCall<PatchPublicDelegatedPrefixeRequest, Operation> _callPatch;

        /// <summary>
        /// Constructs a client wrapper for the PublicDelegatedPrefixes service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PublicDelegatedPrefixesSettings"/> used within this client.
        /// </param>
        public PublicDelegatedPrefixesClientImpl(PublicDelegatedPrefixes.PublicDelegatedPrefixesClient grpcClient, PublicDelegatedPrefixesSettings settings)
        {
            GrpcClient = grpcClient;
            PublicDelegatedPrefixesSettings effectiveSettings = settings ?? PublicDelegatedPrefixesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListPublicDelegatedPrefixesRequest, PublicDelegatedPrefixAggregatedList>(grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callDelete = clientHelper.BuildApiCall<DeletePublicDelegatedPrefixeRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("public_delegated_prefix", request => request.PublicDelegatedPrefix);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetPublicDelegatedPrefixeRequest, PublicDelegatedPrefix>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("public_delegated_prefix", request => request.PublicDelegatedPrefix);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertPublicDelegatedPrefixeRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListPublicDelegatedPrefixesRequest, PublicDelegatedPrefixList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPatch = clientHelper.BuildApiCall<PatchPublicDelegatedPrefixeRequest, Operation>(grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("public_delegated_prefix", request => request.PublicDelegatedPrefix);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListPublicDelegatedPrefixesRequest, PublicDelegatedPrefixAggregatedList> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeletePublicDelegatedPrefixeRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetPublicDelegatedPrefixeRequest, PublicDelegatedPrefix> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertPublicDelegatedPrefixeRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListPublicDelegatedPrefixesRequest, PublicDelegatedPrefixList> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchPublicDelegatedPrefixeRequest, Operation> call);

        partial void OnConstruction(PublicDelegatedPrefixes.PublicDelegatedPrefixesClient grpcClient, PublicDelegatedPrefixesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PublicDelegatedPrefixes client</summary>
        public override PublicDelegatedPrefixes.PublicDelegatedPrefixesClient GrpcClient { get; }

        partial void Modify_AggregatedListPublicDelegatedPrefixesRequest(ref AggregatedListPublicDelegatedPrefixesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePublicDelegatedPrefixeRequest(ref DeletePublicDelegatedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPublicDelegatedPrefixeRequest(ref GetPublicDelegatedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertPublicDelegatedPrefixeRequest(ref InsertPublicDelegatedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPublicDelegatedPrefixesRequest(ref ListPublicDelegatedPrefixesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchPublicDelegatedPrefixeRequest(ref PatchPublicDelegatedPrefixeRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists all PublicDelegatedPrefix resources owned by the specific project across all scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublicDelegatedPrefixAggregatedList AggregatedList(AggregatedListPublicDelegatedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListPublicDelegatedPrefixesRequest(ref request, ref callSettings);
            return _callAggregatedList.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all PublicDelegatedPrefix resources owned by the specific project across all scopes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PublicDelegatedPrefixAggregatedList> AggregatedListAsync(AggregatedListPublicDelegatedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListPublicDelegatedPrefixesRequest(ref request, ref callSettings);
            return _callAggregatedList.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified PublicDelegatedPrefix in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeletePublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified PublicDelegatedPrefix in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeletePublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified PublicDelegatedPrefix resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublicDelegatedPrefix Get(GetPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified PublicDelegatedPrefix resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PublicDelegatedPrefix> GetAsync(GetPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a PublicDelegatedPrefix in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertPublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a PublicDelegatedPrefix in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertPublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the PublicDelegatedPrefixes for a project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PublicDelegatedPrefixList List(ListPublicDelegatedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPublicDelegatedPrefixesRequest(ref request, ref callSettings);
            return _callList.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the PublicDelegatedPrefixes for a project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PublicDelegatedPrefixList> ListAsync(ListPublicDelegatedPrefixesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPublicDelegatedPrefixesRequest(ref request, ref callSettings);
            return _callList.Async(request, callSettings);
        }

        /// <summary>
        /// Patches the specified PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Patch(PatchPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchPublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callPatch.Sync(request, callSettings);
        }

        /// <summary>
        /// Patches the specified PublicDelegatedPrefix resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PatchAsync(PatchPublicDelegatedPrefixeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchPublicDelegatedPrefixeRequest(ref request, ref callSettings);
            return _callPatch.Async(request, callSettings);
        }
    }
}
