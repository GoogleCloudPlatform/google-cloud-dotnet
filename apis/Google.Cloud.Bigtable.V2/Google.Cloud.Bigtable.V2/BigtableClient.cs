// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// Bigtable client wrapper, for convenient use.
    /// </summary>
    public partial class BigtableClient
    {
        /// <summary>Streams back the contents of all requested rows in key order, optionally applying the same Reader filter to each.</summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// If the <see cref="ReadRowsRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual ReadRowsStream ReadRows(
            ReadRowsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// If the <see cref="SampleRowKeysRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(
            SampleRowKeysRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// If the <see cref="MutateRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<MutateRowResponse> MutateRowAsync(
            MutateRowRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by `mutation`.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// If the <see cref="MutateRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateRowResponse MutateRow(
            MutateRowRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// If the <see cref="MutateRowsRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRowsResponse MutateRows(
            MutateRowsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in MutateRow, but the entire batch is not executed
        /// atomically.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// If the <see cref="MutateRowsRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>The RPC response.</returns>
        public virtual Task<MutateRowsResponse> MutateRowsAsync(
            MutateRowsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// If the <see cref="CheckAndMutateRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            CheckAndMutateRowRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// If the <see cref="CheckAndMutateRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(
            CheckAndMutateRowRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// If the <see cref="ReadModifyWriteRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            ReadModifyWriteRowRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest
        /// existing timestamp and value from the specified columns and writes a new
        /// entry based on pre-defined read/modify/write rules. The new value for the
        /// timestamp is the greater of the existing timestamp or the current server
        /// time. The method returns the new contents of all modified cells.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// If the <see cref="ReadModifyWriteRowRequest.AppProfileId"/> has not been specified, it will be initialized from the value stored in the client.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(
            ReadModifyWriteRowRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Settings for creating <see cref="BigtableServiceApiClient"/>s.
        /// </summary>
        public sealed class ClientCreationSettings
        {
            /// <summary>
            /// Instantiate with the specified settings.
            /// </summary>
            /// <param name="clientCount">Optional.
            /// The number of <see cref="BigtableServiceApiClient"/>s to create and use within a <see cref="BigtableClient"/> instance.</param>
            /// <param name="bigtableServiceApiSettings">Optional. The settings to use when creating <see cref="BigtableServiceApiClient"/> instances.</param>
            /// <param name="credentials">Optional. Credentials to use when creating <see cref="BigtableServiceApiClient"/> instances.</param>
            /// <param name="serviceEndpoint">Optional.
            /// The <see cref="ServiceEndpoint"/> to use when creating <see cref="BigtableServiceApiClient"/> instances.</param>
            public ClientCreationSettings(
                int? clientCount = null,
                BigtableServiceApiSettings bigtableServiceApiSettings = null,
                ChannelCredentials credentials = null,
                ServiceEndpoint serviceEndpoint = null)
            {
                ClientCount = clientCount;
                BigtableServiceApiSettings = bigtableServiceApiSettings;
                Credentials = credentials;
                ServiceEndpoint = serviceEndpoint;
            }

            /// <summary>
            /// The number of <see cref="BigtableServiceApiClient"/>s to create and use within a <see cref="BigtableClient"/> instance.
            /// If <c>null</c>, defaults to the CPU count on the machine this is being executed on.
            /// </summary>
            public int? ClientCount { get; }

            /// <summary>
            /// The settings to use when creating <see cref="BigtableServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to <see2 cref="BigtableServiceApiSettings.GetDefault"/>.
            /// </summary>
            public BigtableServiceApiSettings BigtableServiceApiSettings { get; }

            /// <summary>
            /// Credentials to use when creating <see cref="BigtableServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to using the default credentials.
            /// </summary>
            public ChannelCredentials Credentials { get; }

            /// <summary>
            /// The <see cref="ServiceEndpoint"/> to use when creating <see cref="BigtableServiceApiClient"/> instances.
            /// If <c>null</c>, defaults to <see cref="BigtableServiceApiClient.DefaultEndpoint"/>.
            /// </summary>
            public ServiceEndpoint ServiceEndpoint { get; }

            /// <summary>
            /// Creates <see cref="ClientCreationSettings"/> to be used in creation of <see cref="BigtableClient"/> for use with Emulator.
            /// <param name="target"> Service enpoint target in the yourhost:yourport form.</param>
            /// </summary>
            internal static ClientCreationSettings FromEndpointTarget(string target)
            {
                string[] endpointValues = target.Split(':');
                return new ClientCreationSettings(null, null, ChannelCredentials.Insecure, new ServiceEndpoint(endpointValues[0], Convert.ToInt32(endpointValues[1])));
            }

            internal void Validate()
            {
                // Fairly arbitrary upper limit.
                GaxPreconditions.CheckArgumentRange(ClientCount ?? 1, nameof(ClientCount), 1, 256);
            }
        }
    }

    /// <summary>
    /// Bigtable client wrapper, for convenient use.
    /// </summary>
    public sealed partial class BigtableClientImpl : BigtableClient
    {
        /// <inheritdoc/>
        public override ReadRowsStream ReadRows(
            ReadRowsRequest request,
            CallSettings callSettings = null)
        {
            if (request.AppProfileId == null)
            {
                request.AppProfileId = _appProfileId;
            }

            return ConvertResult(request, callSettings, GetUnderlyingClient().ReadRows(request, callSettings));
        }

        /// <inheritdoc/>
        public override BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(
            SampleRowKeysRequest request,
            CallSettings callSettings = null)
        {
            if (request.AppProfileId == null)
            {
                request.AppProfileId = _appProfileId;
            }

            return GetUnderlyingClient().SampleRowKeys(request, callSettings);
        }

        /// <inheritdoc/>
        public override Task<MutateRowResponse> MutateRowAsync(
            MutateRowRequest request,
            CallSettings callSettings = null)
        {
            if (request.AppProfileId == null)
            {
                request.AppProfileId = _appProfileId;
            }

            return GetUnderlyingClient().MutateRowAsync(request, callSettings);
        }

        /// <inheritdoc/>
        public override MutateRowResponse MutateRow(
            MutateRowRequest request,
            CallSettings callSettings = null)
        {
            if (request.AppProfileId == null)
            {
                request.AppProfileId = _appProfileId;
            }

            return GetUnderlyingClient().MutateRow(request, callSettings);
        }

        /// <inheritdoc/>
        public override MutateRowsResponse MutateRows(
            MutateRowsRequest request,
            CallSettings callSettings = null) => Task.Run(() => MutateRowsAsync(request, callSettings)).ResultWithUnwrappedExceptions();

        /// <inheritdoc/>
        public override Task<MutateRowsResponse> MutateRowsAsync(
            MutateRowsRequest request,
            CallSettings callSettings = null)
        {
            if (request.AppProfileId == null)
            {
                request.AppProfileId = _appProfileId;
            }

            return ConvertResult(request, callSettings, GetUnderlyingClient().MutateRows(request, callSettings));
        }

        /// <inheritdoc/>
        public override Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            CheckAndMutateRowRequest request,
            CallSettings callSettings = null)
        {
            if (request.AppProfileId == null)
            {
                request.AppProfileId = _appProfileId;
            }

            return GetUnderlyingClient().CheckAndMutateRowAsync(request, callSettings);
        }

        /// <inheritdoc/>
        public override CheckAndMutateRowResponse CheckAndMutateRow(
            CheckAndMutateRowRequest request,
            CallSettings callSettings = null)
        {
            if (request.AppProfileId == null)
            {
                request.AppProfileId = _appProfileId;
            }

            return GetUnderlyingClient().CheckAndMutateRow(request, callSettings);
        }

        /// <inheritdoc/>
        public override Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            ReadModifyWriteRowRequest request,
            CallSettings callSettings = null)
        {
            if (request.AppProfileId == null)
            {
                request.AppProfileId = _appProfileId;
            }

            return GetUnderlyingClient().ReadModifyWriteRowAsync(request, callSettings);
        }

        /// <inheritdoc/>
        public override ReadModifyWriteRowResponse ReadModifyWriteRow(
            ReadModifyWriteRowRequest request,
            CallSettings callSettings = null)
        {
            if (request.AppProfileId == null)
            {
                request.AppProfileId = _appProfileId;
            }

            return GetUnderlyingClient().ReadModifyWriteRow(request, callSettings);
        }
    }
}