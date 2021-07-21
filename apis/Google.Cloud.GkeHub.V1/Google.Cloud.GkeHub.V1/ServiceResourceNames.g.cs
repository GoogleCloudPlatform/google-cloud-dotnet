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

using gagr = Google.Api.Gax.ResourceNames;
using gcgv = Google.Cloud.GkeHub.V1;

namespace Google.Cloud.GkeHub.V1
{
    public partial class ListMembershipsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetMembershipRequest
    {
        /// <summary>
        /// <see cref="gcgv::MembershipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipName MembershipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMembershipRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteMembershipRequest
    {
        /// <summary>
        /// <see cref="gcgv::MembershipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipName MembershipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
