﻿// Copyright 2016 Google Inc. All Rights Reserved.
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
using System;
using Xunit;

namespace Google.Bigquery.V2.Tests
{
    public class BigqueryParameterCollectionTest
    {
        [Fact]
        public void Add_Parameterless()
        {
            var collection = new BigqueryParameterCollection();
            var parameter = collection.Add();
            Assert.Same(parameter, collection[0]);
            Assert.Null(parameter.Name);
            Assert.Null(parameter.Type);
            Assert.Null(parameter.Value);
        }

        [Fact]
        public void Add_NameAndType()
        {
            var collection = new BigqueryParameterCollection();
            var parameter = collection.Add("name", BigqueryParameterType.Date);
            Assert.Same(parameter, collection[0]);
            Assert.Equal("name", parameter.Name);
            Assert.Equal(BigqueryParameterType.Date, parameter.Type);
            Assert.Null(parameter.Value);
        }

        [Fact]
        public void Add_NameTypeValue()
        {
            var collection = new BigqueryParameterCollection();
            var value = DateTime.UtcNow;
            var parameter = collection.Add("name", BigqueryParameterType.Date, value);
            Assert.Same(parameter, collection[0]);
            Assert.Equal("name", parameter.Name);
            Assert.Equal(BigqueryParameterType.Date, parameter.Type);
            Assert.Equal(value, parameter.Value);
        }

        [Fact]
        public void Add_TypeValue()
        {
            var collection = new BigqueryParameterCollection();
            var value = DateTime.UtcNow;
            var parameter = collection.Add(BigqueryParameterType.Date, value);
            Assert.Same(parameter, collection[0]);
            Assert.Null(parameter.Name);
            Assert.Equal(BigqueryParameterType.Date, parameter.Type);
            Assert.Equal(value, parameter.Value);
        }

        [Fact]
        public void Add_Parameter()
        {
            var collection = new BigqueryParameterCollection();
            var parameter = new BigqueryParameter();
            var added = collection.Add(parameter);
            Assert.Same(parameter, added);
            Assert.Same(parameter, collection[0]);
        }

        [Fact]
        public void ListMemberDelegation()
        {
            var p1 = new BigqueryParameter();
            var p2 = new BigqueryParameter();
            var collection = new BigqueryParameterCollection { p1, p2 };
            Assert.Equal(new[] { p1, p2 }, collection);
            Assert.Same(p1, collection[0]);
            Assert.Same(p2, collection[1]);
            Assert.Equal(2, collection.Count);

            collection.Clear();
            Assert.Equal(0, collection.Count);
        }
    }
}
