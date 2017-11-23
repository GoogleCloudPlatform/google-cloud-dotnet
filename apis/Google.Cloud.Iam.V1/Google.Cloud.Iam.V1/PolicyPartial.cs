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

using Google.Api.Gax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Google.Cloud.Iam.V1
{
    // Convenience methods for Policy
    public partial class Policy
    {
        /// <summary>
        /// Adds the specified member to the specified role. If the role does
        /// not already exist, it is created.
        /// </summary>
        /// <param name="role">The role to add the member to. Must not be null or empty.</param>
        /// <param name="member">The member to add to the role. Must not be null or empty.</param>
        /// <returns><c>true</c> if the policy was changed; <c>false</c> if the member already existed in the role.</returns>
        public bool AddRoleMember(string role, string member)
        {
            GaxPreconditions.CheckNotNullOrEmpty(role, nameof(role));
            GaxPreconditions.CheckNotNullOrEmpty(member, nameof(member));
            var binding = FindRole(role);
            if (binding == null)
            {
                Bindings.Add(new Binding { Role = role, Members = { member } });
                return true;
            }
            if (binding.Members.Contains(member))
            {
                return false;
            }
            binding.Members.Add(member);
            return true;
        }

        /// <summary>
        /// Removes the specified member to the specified role, if they belong to it. If the role becomes empty after
        /// removing the member, it is removed from the policy.
        /// </summary>
        /// <param name="role">The role to remove the member from. Must not be null or empty.</param>
        /// <param name="member">The member to remove from the role. Must not be null or empty.</param>
        /// <returns><c>true</c> if the policy was changed; <c>false</c> if the member didn't exist in the role
        /// or the role didn't exist.</returns>
        public bool RemoveRoleMember(string role, string member)
        {
            GaxPreconditions.CheckNotNullOrEmpty(role, nameof(role));
            GaxPreconditions.CheckNotNullOrEmpty(member, nameof(member));
            var binding = FindRole(role);
            if (binding == null)
            {
                return false;
            }
            if (!binding.Members.Remove(member))
            {
                return false;
            }
            if (binding.Members.Count == 0)
            {
                Bindings.Remove(binding);
            }
            return true;
        }

        private Binding FindRole(string role) => Bindings.FirstOrDefault(binding => binding.Role == role);
    }
}
