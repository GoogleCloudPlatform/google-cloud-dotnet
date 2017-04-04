﻿// Copyright 2017 Google Inc. All Rights Reserved.
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

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Xunit;

namespace Google.Cloud.Diagnostics.AspNetCore.Tests
{
    public class TraceDecisionPredicateTest
    {
        [Fact]
        public void Default_Trace()
        {
            var request = new DefaultHttpRequest(new DefaultHttpContext())
            {
                Path = "/_ah/somepath"
            };
            Assert.Null(TraceDecisionPredicate.Default(request));
        }

        [Fact]
        public void Default_DoNotTrace()
        {
            var request = new DefaultHttpRequest(new DefaultHttpContext())
            {
                Path = "/_ah/health"
            };
            Assert.False(TraceDecisionPredicate.Default(request));
        }
    }
}
