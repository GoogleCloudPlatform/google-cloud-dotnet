// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Cloud.Spanner.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TypeCode = Google.Cloud.Spanner.V1.TypeCode;

namespace Google.Cloud.Spanner.Data
{
    public sealed partial class SpannerDbType
    {
        /// <summary>
        /// Given a string representation, returns an instance of <see cref="SpannerDbType"/>.
        /// </summary>
        /// <param name="spannerType">A string representation of a SpannerDbType. See <see cref="ToString"/>.</param>
        /// <param name="spannerDbType">If parsing was successful, then an instance of <see cref="SpannerDbType"/>.
        ///  Otherwise null.</param>
        /// <returns>True if the parse was successful.</returns>
        public static bool TryParse(string spannerType, out SpannerDbType spannerDbType)
        {
            spannerDbType = null;
            if (!TryParsePartial(spannerType, out TypeCode code, out int? size, out string remainder))
            {
                return false;
            }
            switch (code)
            {
                case TypeCode.Unspecified:
                case TypeCode.Bool:
                case TypeCode.Int64:
                case TypeCode.Float64:
                case TypeCode.Timestamp:
                case TypeCode.Date:
                case TypeCode.String:
                case TypeCode.Bytes:
                case TypeCode.Json:
                case TypeCode.Numeric:
                    if (!string.IsNullOrEmpty(remainder))
                    {
                        //unexepected inner remainder on simple type
                        return false;
                    }
                    // If there's no size, we can use cached values.
                    spannerDbType = size == null ? FromTypeCode(code) : new SpannerDbType(code, size);
                    return true;
                case TypeCode.Array:
                    if (!TryParse(remainder, out SpannerDbType elementType))
                    {
                        return false;
                    }
                    spannerDbType = new SpannerDbType(code, elementType);
                    return true;
                case TypeCode.Struct:
                    // There could be nested structs, so we need to be careful about parsing the inner string.
                    var fields = new List<StructField>();
                    int currentIndex = 0;
                    while (remainder != null && currentIndex < remainder.Length)
                    {
                        int midfieldIndex = NonNestedIndexOf(remainder, currentIndex, ':');
                        int endFieldIndex = NonNestedIndexOf(remainder, currentIndex, ',');
                        if (endFieldIndex == -1)
                        {
                            // We reached the last field.
                            endFieldIndex = remainder.Length;
                        }

                        string fieldName;
                        int fieldTypeStartIndex;
                        if (midfieldIndex != -1 && midfieldIndex < endFieldIndex)
                        {
                            fieldName = remainder.Substring(currentIndex, midfieldIndex - currentIndex).Trim();
                            // Empty names can't be specified expicitly; STRUCT<INT64> is fine, but STRUCT<:INT64> is not.
                            if (fieldName == "")
                            {
                                return false;
                            }
                            fieldTypeStartIndex = midfieldIndex + 1;
                        }
                        else
                        {
                            fieldName = "";
                            fieldTypeStartIndex = currentIndex;
                        }

                        if (!TryParse(remainder.Substring(fieldTypeStartIndex, endFieldIndex - fieldTypeStartIndex),
                            out SpannerDbType fieldDbType))
                        {
                            return false;
                        }
                        fields.Add(new StructField(fieldName, fieldDbType));
                        currentIndex = endFieldIndex + 1;
                    }
                    spannerDbType = new SpannerDbType(code, fields);
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// Returns the first index of 'c' within typeString at nesting level '0' where the nesting level is defined
        /// by brackets &lt; and &gt;
        /// </summary>
        private static int NonNestedIndexOf(string typeString, int startIndex, params char[] c)
        {
            int level = 0;
            for (var i = startIndex; i < typeString.Length; i++)
            {
                if (typeString[i] == '<') level++;
                else if (typeString[i] == '>') level--;
                else if (c.Contains(typeString[i]) && level == 0) return i;
            }
            return -1;
        }

        /// <summary>
        /// Parses a subsection of the given string into a TypeCode and size, returning the nested content
        /// as a remainder.
        /// Given a string of  ARRAY{STRING}, the remainer will be 'STRING' and the returned typecode will be ARRAY.
        /// </summary>
        private static bool TryParsePartial(string complexName, out TypeCode typeCode, out int? size, out string remainder)
        {
            typeCode = TypeCode.Unspecified;
            size = null;
            remainder = null;
            if (string.IsNullOrEmpty(complexName))
            {
                return false;
            }

            int remainderStart = complexName.IndexOfAny(new[] { '<', '(' });
            remainderStart = remainderStart != -1 ? remainderStart : complexName.Length;
            typeCode = TypeCodeExtensions.GetTypeCode(complexName.Substring(0, remainderStart));
            if (typeCode == TypeCode.Unspecified)
            {
                return false;
            }
            if (complexName.Length > remainderStart)
            {
                if (complexName[remainderStart] == '(')
                {
                    //get the size and remainder to send back
                    var sizeEnd = complexName.IndexOf(')');
                    if (sizeEnd == -1)
                    {
                        return false;
                    }
                    var sizeString = complexName.Substring(remainderStart + 1, sizeEnd - remainderStart - 1).Trim();
                    if (!sizeString.Equals("MAX", StringComparison.OrdinalIgnoreCase) &&
                         int.TryParse(sizeString, out int parsedSize))
                    {
                        size = parsedSize;
                    }
                    remainder = complexName.Substring(sizeEnd + 1).Trim();
                }
                else
                {
                    var innerEnd = complexName.LastIndexOf('>');
                    if (innerEnd == -1)
                    {
                        return false;
                    }
                    //get the remainder to send back.
                    remainder = complexName.Substring(remainderStart + 1, innerEnd - remainderStart - 1).Trim();
                }
            }
            return true;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            if (ArrayElementType != null)
            {
                return $"ARRAY<{ArrayElementType}>";
            }
            if (StructFields != null && StructFields.Count > 0)
            {
                var s = new StringBuilder();
                foreach (var field in StructFields)
                {
                    s.Append(s.Length == 0 ? "STRUCT<" : ", ");
                    s.Append(field.Name == "" ? field.Type.ToString() : $"{field.Name}: {field.Type}");
                }
                s.Append(">");
                return s.ToString();
            }
            return Size.HasValue ? $"{TypeCode.GetOriginalName()}({Size})" : TypeCode.GetOriginalName();
        }
    }
}
