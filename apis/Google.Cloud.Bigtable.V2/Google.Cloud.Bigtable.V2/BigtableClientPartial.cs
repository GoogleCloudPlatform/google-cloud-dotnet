﻿// Copyright 2017 Google Inc. All rights reserved.
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.V2
{
    public partial class BigtableClient
    {
        // TODO: Auto-generate these if possible/easy after multi-channel support is added.

        /// <summary>
        /// Asynchronously creates a <see cref="BigtableClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableServiceApiSettings"/>.</param>
        /// <param name="appProfileId">
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <returns>The task representing the created <see cref="BigtableClient"/>.</returns>
        public static async Task<BigtableClient> CreateAsync(ServiceEndpoint endpoint = null, BigtableServiceApiSettings settings = null, string appProfileId = null)
        {
            var client = await BigtableServiceApiClient.CreateAsync(endpoint, settings).ConfigureAwait(false);
            return new BigtableClientImpl(client, appProfileId);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BigtableClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BigtableServiceApiSettings"/>.</param>
        /// <param name="appProfileId">
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <returns>The created <see cref="BigtableClient"/>.</returns>
        public static BigtableClient Create(ServiceEndpoint endpoint = null, BigtableServiceApiSettings settings = null, string appProfileId = null)
        {
            var client = BigtableServiceApiClient.Create(endpoint, settings);
            return new BigtableClientImpl(client, appProfileId);
        }

        /// <summary>
        /// Creates a <see cref="BigtableClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BigtableServiceApiSettings"/>.</param>
        /// <param name="appProfileId">
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <returns>The created <see cref="BigtableClient"/>.</returns>
        public static BigtableClient Create(Channel channel, BigtableServiceApiSettings settings = null, string appProfileId = null)
        {
            var client = BigtableServiceApiClient.Create(channel, settings);
            return new BigtableClientImpl(client, appProfileId);
        }

        /// <summary>
        /// Gets a <see cref="BigtableClient"/> matching this one but with the specified <paramref name="appProfileId"/>.
        /// </summary>
        /// <param name="appProfileId">
        /// This is a private alpha release of Cloud Bigtable replication. This feature
        /// is not currently available to most Cloud Bigtable customers. This feature
        /// might be changed in backward-incompatible ways and is not recommended for
        /// production use. It is not subject to any SLA or deprecation policy.
        ///
        /// This value specifies routing for replication. If not specified, the
        /// "default" application profile will be used.
        /// </param>
        /// <returns>The updated <see cref="BigtableClient"/>.</returns>
        public virtual BigtableClient WithAppProfileId(string appProfileId) => this;

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="CheckAndMutateRow(CheckAndMutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either <paramref name="trueMutations"/> or
        /// <paramref name="falseMutations"/> will be executed. If null, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// yields at least one cell when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if <paramref name="falseMutations"/> is null or empty, and
        /// at most 100000. Can be null or empty, but must not contain null elements.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// does not yield any cells when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if <paramref name="trueMutations"/> is null or empty, and
        /// at most 100000. Can be null or empty, but must not contain null elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from trying to mutate the row.
        /// </returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter predicateFilter,
            IEnumerable<Mutation> trueMutations,
            IEnumerable<Mutation> falseMutations,
            CallSettings callSettings = null) =>
            CheckAndMutateRow(
                CreateCheckAndMutateRowRequest(tableName, rowKey, predicateFilter, trueMutations, falseMutations),
                callSettings);

        /// <summary>
        /// Mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="CheckAndMutateRow(CheckAndMutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, <paramref name="trueMutations"/> may or may not
        /// be executed. If null, checks that the row contains any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// yields at least one cell when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.  Must not be null, or contain null elements.
        /// </param>
        /// <returns>
        /// The response from trying to mutate the row.
        /// </returns>
        public virtual CheckAndMutateRowResponse CheckAndMutateRow(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter predicateFilter,
            params Mutation[] trueMutations) =>
            CheckAndMutateRow(
                CreateCheckAndMutateRowRequest(tableName, rowKey, predicateFilter, trueMutations, falseMutations: null));

        /// <summary>
        /// Asynchronously mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="CheckAndMutateRowAsync(CheckAndMutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, either <paramref name="trueMutations"/> or
        /// <paramref name="falseMutations"/> will be executed. If null, checks that the row contains
        /// any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// yields at least one cell when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if <paramref name="falseMutations"/> is null or empty, and
        /// at most 100000. Can be null or empty, but must not contain null elements.
        /// </param>
        /// <param name="falseMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// does not yield any cells when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry if <paramref name="trueMutations"/> is null or empty, and
        /// at most 100000. Can be null or empty, but must not contain null elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from trying to mutate the row.
        /// </returns>
        public virtual Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter predicateFilter,
            IEnumerable<Mutation> trueMutations,
            IEnumerable<Mutation> falseMutations,
            CallSettings callSettings = null) =>
            CheckAndMutateRowAsync(
                CreateCheckAndMutateRowRequest(tableName, rowKey, predicateFilter, trueMutations, falseMutations),
                callSettings);

        /// <summary>
        /// Asynchronously mutates a row atomically based on the output of a predicate Reader filter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="CheckAndMutateRowAsync(CheckAndMutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the conditional mutation should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the conditional mutation should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="predicateFilter">
        /// The filter to be applied to the contents of the specified row. Depending
        /// on whether or not any results are yielded, <paramref name="trueMutations"/> may or may not
        /// be executed. If null, checks that the row contains any values at all.
        /// </param>
        /// <param name="trueMutations">
        /// Changes to be atomically applied to the specified row if <paramref name="predicateFilter"/>
        /// yields at least one cell when applied to <paramref name="rowKey"/>. Entries are applied in
        /// order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000.  Must not be null, or contain null elements.
        /// </param>
        /// <returns>
        /// The response from trying to mutate the row.
        /// </returns>
        public virtual Task<CheckAndMutateRowResponse> CheckAndMutateRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter predicateFilter,
            params Mutation[] trueMutations) =>
            CheckAndMutateRowAsync(
                CreateCheckAndMutateRowRequest(tableName, rowKey, predicateFilter, trueMutations, falseMutations: null));

        private static CheckAndMutateRowRequest CreateCheckAndMutateRowRequest(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter predicateFilter,
            IEnumerable<Mutation> trueMutations,
            IEnumerable<Mutation> falseMutations)
        {
            GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            GaxPreconditions.CheckArgument(rowKey.Length != 0, nameof(rowKey), "The row key must not empty");

            var request = new CheckAndMutateRowRequest
            {
                TableNameAsTableName = tableName,
                RowKey = rowKey.Value,
                PredicateFilter = predicateFilter,
                TrueMutations = { Utilities.ValidateCollection(trueMutations, nameof(trueMutations), allowNullCollection: true) },
                FalseMutations = { Utilities.ValidateCollection(falseMutations, nameof(falseMutations), allowNullCollection: true) }
            };

            GaxPreconditions.CheckArgument(
                request.TrueMutations.Count + request.FalseMutations.Count != 0,
                nameof(trueMutations),
                "There must be at least one mutation.");
            return request;
        }

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by <paramref name="mutations"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="MutateRow(MutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied. Must not be empty.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from mutating the row.
        /// </returns>
        public virtual MutateRowResponse MutateRow(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) =>
            MutateRow(
                CreateMutateRowRequest(tableName, rowKey, mutations),
                callSettings);

        /// <summary>
        /// Mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by <paramref name="mutations"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="MutateRow(MutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied. Must not be empty.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <returns>
        /// The response from mutating the row.
        /// </returns>
        public virtual MutateRowResponse MutateRow(
            TableName tableName,
            BigtableByteString rowKey,
            params Mutation[] mutations) =>
            MutateRow(
                CreateMutateRowRequest(tableName, rowKey, mutations));

        /// <summary>
        /// Asynchronously mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by <paramref name="mutations"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="MutateRowAsync(MutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied. Must not be empty.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from mutating the row.
        /// </returns>
        public virtual Task<MutateRowResponse> MutateRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<Mutation> mutations,
            CallSettings callSettings = null) =>
            MutateRowAsync(
                CreateMutateRowRequest(tableName, rowKey, mutations),
                callSettings);

        /// <summary>
        /// Asynchronously mutates a row atomically. Cells already present in the row are left
        /// unchanged unless explicitly changed by <paramref name="mutations"/>.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="MutateRowAsync(MutateRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutation should be applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the mutation should be applied. Must not be empty.
        /// </param>
        /// <param name="mutations">
        /// Changes to be atomically applied to the specified row. Entries are applied
        /// in order, meaning that earlier mutations can be masked by later ones.
        /// Must contain at least one entry and at most 100000. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <returns>
        /// The response from mutating the row.
        /// </returns>
        public virtual Task<MutateRowResponse> MutateRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            params Mutation[] mutations) =>
            MutateRowAsync(
                CreateMutateRowRequest(tableName, rowKey, mutations));

        private static MutateRowRequest CreateMutateRowRequest(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<Mutation> mutations)
        {
            GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            GaxPreconditions.CheckArgument(rowKey.Length != 0, nameof(rowKey), "The row key must not empty");
            
            var request = new MutateRowRequest
            {
                TableNameAsTableName = tableName,
                RowKey = rowKey.Value,
                Mutations = { Utilities.ValidateCollection(mutations, nameof(mutations)) }
            };

            GaxPreconditions.CheckArgument(
                request.Mutations.Count != 0, nameof(mutations), "There must be at least one entry.");
            return request;
        }

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in <see cref="MutateRow(MutateRowRequest, CallSettings)"/>,
        /// but the entire batch is not executed atomically.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note this method executes a server streaming RPC. It is not a synchronous call. The caller must process the responses from
        /// stream as they are returned from the server. Each response will indicate the status for one or more entry of mutations.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="MutateRows(MutateRowsRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutations should be applied. Must not be null.
        /// </param>
        /// <param name="entries">
        /// The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual BigtableServiceApiClient.MutateRowsStream MutateRows(
            TableName tableName,
            IEnumerable<MutateRowsRequest.Types.Entry> entries,
            CallSettings callSettings = null)
        {
            var request = new MutateRowsRequest
            {
                TableNameAsTableName = GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                Entries = { Utilities.ValidateCollection(entries, nameof(entries)) }
            };
            GaxPreconditions.CheckArgument(
                request.Entries.Count != 0, nameof(entries), "There must be at least one entry.");
            return MutateRows(request, callSettings);
        }

        /// <summary>
        /// Mutates multiple rows in a batch. Each individual row is mutated
        /// atomically as in <see cref="MutateRow(MutateRowRequest, CallSettings)"/>,
        /// but the entire batch is not executed atomically.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note this method executes a server streaming RPC. It is not a synchronous call. The caller must process the responses from
        /// stream as they are returned from the server. Each response will indicate the status for one or more entry of mutations.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="MutateRows(TableName, IEnumerable{MutateRowsRequest.Types.Entry}, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the mutations should be applied. Must not be null.
        /// </param>
        /// <param name="entries">
        /// The row keys and corresponding mutations to be applied in bulk.
        /// Each entry is applied as an atomic mutation, but the entries may be
        /// applied in arbitrary order (even between entries for the same row).
        /// At least one entry must be specified, and in total the entries can
        /// contain at most 100000 mutations.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual BigtableServiceApiClient.MutateRowsStream MutateRows(
            TableName tableName,
            params MutateRowsRequest.Types.Entry[] entries) =>
            MutateRows(tableName, entries, callSettings: null);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest existing version
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the version is the
        /// greater of the previous value's version or the current server version. The method
        /// returns the new contents of all modified cells.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that the server version is based on the current timestamp since the Unix epoch, so for
        /// columns which are updated using ReadModifyWriteRow, other reads and writes of those columns
        /// should use <see cref="BigtableVersion"/> values constructed from DateTime values, as opposed
        /// to using a custom versioning scheme with 64-bit values.
        /// </para>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="ReadModifyWriteRow(ReadModifyWriteRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.  Must not be null, or contain null
        /// elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from modifying the row.
        /// </returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<ReadModifyWriteRule> rules,
            CallSettings callSettings = null) =>
            ReadModifyWriteRow(
                CreateReadModifyWriteRowRequest(tableName, rowKey, rules),
                callSettings);

        /// <summary>
        /// Modifies a row atomically on the server. The method reads the latest existing version
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the version is the
        /// greater of the previous value's version or the current server version. The method
        /// returns the new contents of all modified cells.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that the server version is based on the current timestamp since the Unix epoch, so for
        /// columns which are updated using ReadModifyWriteRow, other reads and writes of those columns
        /// should use <see cref="BigtableVersion"/> values constructed from DateTime values, as opposed
        /// to using a custom versioning scheme with 64-bit values.
        /// </para>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="ReadModifyWriteRow(ReadModifyWriteRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <returns>
        /// The response from modifying the row.
        /// </returns>
        public virtual ReadModifyWriteRowResponse ReadModifyWriteRow(
            TableName tableName,
            BigtableByteString rowKey,
            params ReadModifyWriteRule[] rules) =>
            ReadModifyWriteRow(
                CreateReadModifyWriteRowRequest(tableName, rowKey, rules));

        /// <summary>
        /// Asynchronously modifies a row atomically on the server. The method reads the latest existing version
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the version is the
        /// greater of the previous value's version or the current server version. The method
        /// returns the new contents of all modified cells.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that the server version is based on the current timestamp since the Unix epoch, so for
        /// columns which are updated using ReadModifyWriteRow, other reads and writes of those columns
        /// should use <see cref="BigtableVersion"/> values constructed from DateTime values, as opposed
        /// to using a custom versioning scheme with 64-bit values.
        /// </para>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="ReadModifyWriteRowAsync(ReadModifyWriteRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones.  Must not be null, or contain null
        /// elements.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The response from modifying the row.
        /// </returns>
        public virtual Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<ReadModifyWriteRule> rules,
            CallSettings callSettings = null) =>
            ReadModifyWriteRowAsync(
                CreateReadModifyWriteRowRequest(tableName, rowKey, rules),
                callSettings);

        /// <summary>
        /// Asynchronously modifies a row atomically on the server. The method reads the latest existing version
        /// and value from the specified columns and writes a new entry based on
        /// pre-defined read/modify/write rules. The new value for the version is the
        /// greater of the previous value's version or the current server version. The method
        /// returns the new contents of all modified cells.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Note that the server version is based on the current timestamp since the Unix epoch, so for
        /// columns which are updated using ReadModifyWriteRow, other reads and writes of those columns
        /// should use <see cref="BigtableVersion"/> values constructed from DateTime values, as opposed
        /// to using a custom versioning scheme with 64-bit values.
        /// </para>
        /// <para>
        /// Note that string is implicitly convertible to <see cref="BigtableByteString"/>, so <paramref name="rowKey"/> can
        /// be specified using a string as well and its UTF-8 representations will be used.
        /// </para>
        /// <para>
        /// This method simply delegates to <see cref="ReadModifyWriteRowAsync(ReadModifyWriteRowRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table to which the read/modify/write rules should be
        /// applied. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to which the read/modify/write rules should be applied.
        /// Must not be empty.
        /// </param>
        /// <param name="rules">
        /// Rules specifying how the specified row's contents are to be transformed
        /// into writes. Entries are applied in order, meaning that earlier rules will
        /// affect the results of later ones. Must not be null, or contain null
        /// elements.
        /// </param>
        /// <returns>
        /// The response from modifying the row.
        /// </returns>
        public virtual Task<ReadModifyWriteRowResponse> ReadModifyWriteRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            params ReadModifyWriteRule[] rules) =>
            ReadModifyWriteRowAsync(
                CreateReadModifyWriteRowRequest(tableName, rowKey, rules));

        private static ReadModifyWriteRowRequest CreateReadModifyWriteRowRequest(
            TableName tableName,
            BigtableByteString rowKey,
            IEnumerable<ReadModifyWriteRule> rules)
        {
            GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            GaxPreconditions.CheckArgument(rowKey.Length != 0, nameof(rowKey), "The row key must not empty");
            
            var request = new ReadModifyWriteRowRequest
            {
                TableNameAsTableName = tableName,
                RowKey = rowKey.Value,
                Rules = { Utilities.ValidateCollection(rules, nameof(rules)) }
            };

            GaxPreconditions.CheckArgument(
                request.Rules.Count != 0, nameof(rules), "There must be at least one entry.");
            return request;
        }

        /// <summary>
        /// Returns the contents of the requested row, optionally applying the specified Reader filter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="ReadRowAsync(TableName, BigtableByteString, RowFilter, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table from which to read. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to read. Must not be empty.
        /// </param>
        /// <param name="filter">
        /// The filter to apply to the contents of the specified row. If null,
        /// reads the entirety of the row.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The row from the server or null if it does not exist.
        /// </returns>
        public virtual Row ReadRow(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter filter = null,
            CallSettings callSettings = null) =>
            Task.Run(() => ReadRowAsync(tableName, rowKey, filter, callSettings)).ResultWithUnwrappedExceptions();

        /// <summary>
        /// Asynchronously returns the contents of the requested row, optionally applying the specified Reader filter.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="ReadRows(TableName, RowSet, RowFilter, long?, CallSettings)"/>
        /// and takes the single row result or null if no rows are returned.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table from which to read. Must not be null.
        /// </param>
        /// <param name="rowKey">
        /// The key of the row to read. Must not be empty.
        /// </param>
        /// <param name="filter">
        /// The filter to apply to the contents of the specified row. If null,
        /// reads the entirety of the row.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The row from the server or null if it does not exist.
        /// </returns>
        public virtual async Task<Row> ReadRowAsync(
            TableName tableName,
            BigtableByteString rowKey,
            RowFilter filter = null,
            CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(tableName, nameof(tableName));
            GaxPreconditions.CheckArgument(rowKey.Length != 0, nameof(rowKey), "The row key must not empty");

            var response = ReadRows(
                tableName,
                new RowSet { RowKeys = { rowKey.Value } },
                filter,
                callSettings: callSettings);

            return await response.AsAsyncEnumerable().SingleOrDefault().ConfigureAwait(false);
        }

        /// <summary>
        /// Streams back the contents of all requested rows in key order, optionally
        /// applying the same Reader filter to each.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="ReadRows(ReadRowsRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table from which to read. Must not be null.
        /// </param>
        /// <param name="rows">
        /// The row keys and/or ranges to read. If null, reads from all rows.
        /// </param>
        /// <param name="filter">
        /// The filter to apply to the contents of the specified row(s). If null,
        /// reads the entirety of each row.
        /// </param>
        /// <param name="rowsLimit">
        /// The read will terminate after committing to N rows' worth of results.
        /// If null or 0, returns all results.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream.
        /// </returns>
        public virtual BigtableServiceApiClient.ReadRowsStream ReadRows(
            TableName tableName,
            RowSet rows = null,
            RowFilter filter = null,
            long? rowsLimit = null,
            CallSettings callSettings = null) =>
            ReadRows(
                new ReadRowsRequest
                {
                    TableNameAsTableName = GaxPreconditions.CheckNotNull(tableName, nameof(tableName)),
                    Rows = rows,
                    Filter = filter,
                    RowsLimit = GaxPreconditions.CheckArgumentRange(rowsLimit ?? 0, nameof(rowsLimit), 0, long.MaxValue)
                },
                callSettings);

        // TODO: Remove when generator supports flattening of server streaming methods.
        /// <summary>
        /// Returns a sample of row keys in the table. The returned row keys will
        /// delimit contiguous sections of the table of approximately equal size,
        /// which can be used to break up the data for distributed tasks like
        /// mapreduces.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method simply delegates to <see cref="SampleRowKeys(SampleRowKeysRequest, CallSettings)"/>.
        /// </para>
        /// </remarks>
        /// <param name="tableName">
        /// The unique name of the table from which to sample row keys. Must not be null.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The server stream with the row key samples.
        /// </returns>
        public virtual BigtableServiceApiClient.SampleRowKeysStream SampleRowKeys(
            TableName tableName,
            CallSettings callSettings = null) =>
            SampleRowKeys(new SampleRowKeysRequest
                {
                    TableNameAsTableName = GaxPreconditions.CheckNotNull(tableName, nameof(tableName))
                },
                callSettings);
    }

    public partial class BigtableClientImpl
    {
        private readonly string _appProfileId;
        private readonly BigtableServiceApiClient _client;

        // TODO: Add a public constructor after multi-channel support?
        internal BigtableClientImpl(BigtableServiceApiClient client, string appProfileId)
        {
            _client = client;
            _appProfileId = appProfileId;
        }

        // TODO: Add Multi-channel support
        private BigtableServiceApiClient GetClient() => _client;

        /// <inheritdoc/>
        public override BigtableClient WithAppProfileId(string appProfileId) =>
            new BigtableClientImpl(_client, appProfileId);
    }
}
