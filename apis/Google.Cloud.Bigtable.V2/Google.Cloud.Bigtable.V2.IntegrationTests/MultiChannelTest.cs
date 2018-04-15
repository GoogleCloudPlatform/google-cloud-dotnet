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

using Google.Cloud.ClientTesting;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Bigtable.V2.IntegrationTests
{
    [Collection(nameof(BigtableFixture))]
    public class MultiChannelTest
    {
        private readonly BigtableFixture _fixture;

        public MultiChannelTest(BigtableFixture fixture) => _fixture = fixture;

        [Fact]
        public async Task SeparateSubchannels()
        {
            int originalSubchannelCount = GrpcInfo.SubchannelCount;
            int clientCount = 2;

            var client = await BigtableClient.CreateAsync(new BigtableClient.ClientCreationSettings(clientCount));
            for (int i = 0; i < 10; i++)
            {
                await client.ReadRowAsync(_fixture.TableName, "abc");
            }

            int subchannelsCreated = GrpcInfo.SubchannelCount- originalSubchannelCount;
            Assert.Equal(clientCount, subchannelsCreated);
        }
    }
}
