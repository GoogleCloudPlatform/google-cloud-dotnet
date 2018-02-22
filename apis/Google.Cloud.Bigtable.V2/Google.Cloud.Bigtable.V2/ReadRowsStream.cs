﻿// Copyright 2018 Google LLC
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

using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Google.Cloud.Bigtable.V2
{
    /// <summary>
    /// The stream of <see cref="Row"/> instances returned from the server.
    /// </summary>
    public class ReadRowsStream : IAsyncEnumerable<Row>
    {
        private int _enumeratorCount;
        private BigtableServiceApiClient.ReadRowsStream _underlyingStream;

        internal ReadRowsStream(BigtableServiceApiClient.ReadRowsStream underlyingStream) =>
            _underlyingStream = underlyingStream;

        /// <summary>
        /// The underlying gRPC duplex streaming call.
        /// </summary>
        public AsyncServerStreamingCall<ReadRowsResponse> GrpcCall => _underlyingStream.GrpcCall;

        /// <inheritdoc/>
        public IAsyncEnumerator<Row> GetEnumerator()
        {
            if (Interlocked.CompareExchange(ref _enumeratorCount, 1, 0) == 1)
            {
                throw new InvalidOperationException($"The {nameof(ReadRowsStream)} can only be iterated once");
            }

            return new RowAsyncEnumerator(_underlyingStream);
        }
    }
}
