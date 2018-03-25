﻿/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.
    Copyright 2018 Google LLC

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/


namespace BreakingChangesDetector.MetadataItems
{
    /// <summary>
    /// Represents an item that has parameters, such as a constructor, method, delegate, or indexer.
    /// </summary>
    public interface IParameterizedItem
    {
        /// <summary>
        /// Indicates whether a new member of the same type and name is logically the same member as the current member, just from a newer build, possibly
        /// by ignoring any new optional parameters which may have been added since the older build.
        /// </summary> 
        bool IsEquivalentToNewMember(MemberDataBase newMember, AssemblyFamily newAssemblyFamily, bool ignoreNewOptionalParameters);

        /// <summary>
        /// Gets the collection of parameters on the item.
        /// </summary>
        ParameterCollection Parameters { get; }
    }
}
