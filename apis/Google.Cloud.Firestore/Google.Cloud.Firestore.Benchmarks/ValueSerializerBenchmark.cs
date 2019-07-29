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

using BenchmarkDotNet.Attributes;
using Google.Cloud.Firestore.V1;
using System.Collections.Generic;

namespace Google.Cloud.Firestore.Benchmarks
{
    public class ValueSerializerBenchmark
    {
        private static readonly SerializationContext _serializationContext = new SerializationContext(null);

        [Benchmark]
        public Dictionary<string, Value> SerializeMap_Attributed() =>
            ValueSerializer.SerializeMap(_serializationContext, SampleData.Attributed);

        [Benchmark]
        public Value Serialize_Attributed() =>
            ValueSerializer.Serialize(_serializationContext, SampleData.Attributed);

        [Benchmark]
        public Dictionary<string, Value> SerializeMap_Anonymous() =>
            ValueSerializer.SerializeMap(_serializationContext, SampleData.Anonymous);

        [Benchmark]
        public Value Serialize_Anonymous() =>
            ValueSerializer.Serialize(_serializationContext, SampleData.Anonymous);

        [Benchmark]
        public Dictionary<string, Value> SerializeMap_Dictionary() =>
            ValueSerializer.SerializeMap(_serializationContext, SampleData.Dictionary);

        [Benchmark]
        public Value Serialize_Dictionary() =>
            ValueSerializer.Serialize(_serializationContext, SampleData.Dictionary);

        [Benchmark]
        public Dictionary<string, Value> SerializeMap_Expando() =>
        ValueSerializer.SerializeMap(_serializationContext, SampleData.Expando);

        [Benchmark]
        public Value Serialize_Expando() =>
            ValueSerializer.Serialize(_serializationContext, SampleData.Expando);
    }
}
