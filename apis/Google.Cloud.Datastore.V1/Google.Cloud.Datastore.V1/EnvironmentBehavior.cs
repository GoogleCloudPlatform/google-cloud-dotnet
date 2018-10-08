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

using System;
using System.Collections.Generic;
using System.Text;

namespace Google.Cloud.Datastore.V1
{
    /// <summary>
    /// Specifies how <see cref="DatastoreDb.CreateWithEnvironment(EnvironmentBehavior, string, string)"/>
    /// behaves in different scenarios.
    /// </summary>
    public enum EnvironmentBehavior
    {
        /// <summary>
        /// Always connect to the production servers, regardless of environment
        /// variables. This is equivalent to the <see cref="DatastoreDb.Create"/>
        /// call.
        /// </summary>
        ProductionOnlyIgnoreEnvironment = 0,

        /// <summary>
        /// Always connect to the production servers, but throw an exception if
        /// environment variables exist that would suggest the emulator is expected.
        /// </summary>
        ProductionOnlyThrowOnEmulatorEnvironment = 1,

        /// <summary>
        /// Always connect to the emulator, throwing an exception if the environment
        /// variables are not configured.
        /// </summary>
        EmulatorOnly = 2,

        /// <summary>
        /// Connect to the emulator if suitable environment variables are present,
        /// or production otherwise. This is a convenient option, but risks damage to
        /// production databases or running up unexpected bills if tests are accidentally
        /// run in production due to environment variables being absent unexpectedly.
        /// (Using separate projects for production and testing is a best practice for
        /// preventing the first issue, but may be unrealistic for small or hobby projects.)
        /// </summary>
        ProductionOrEmulator = 3
    }
}
