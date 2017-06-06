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

using System;
using System.Data.Common;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util;
using Google.Cloud.Spanner.V1;

// ReSharper disable UnusedParameter.Local
namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// A connection string builder for Spanner connection strings.
    /// </summary>
    public sealed class SpannerConnectionStringBuilder : DbConnectionStringBuilder
    {
        /// <summary>
        /// </summary>
        public ITokenAccess Credential { get; private set; }

        /// <summary>
        /// </summary>
        public string DataSource
        {
            get => GetValueOrDefault("Data Source");
            private set => this["Data Source"] = ValidatedDataSource(value);
        }

        private string ValidatedDataSource(string dataSource)
        {
            var parts = dataSource?.Split('/');
            if (parts?.Length == 3)
            {
                return dataSource;
            }
            if (parts?.Length == 6
                && String.Equals(parts[0], "projects", StringComparison.OrdinalIgnoreCase)
                && String.Equals(parts[2], "instances", StringComparison.OrdinalIgnoreCase)
                && String.Equals(parts[4], "databases", StringComparison.OrdinalIgnoreCase))
            {
                return dataSource;
            }
            throw new ArgumentException($"'{dataSource}' is not a valid value for ${nameof(DataSource)}.  It should be of the form "
                + "projects/<project>/instances/<instance>/databases/<database>.", nameof(DataSource));
        }

        /// <summary>
        /// </summary>
        public ServiceEndpoint EndPoint => new ServiceEndpoint(Host, Port);

        /// <summary>
        /// </summary>
        public string Host
        {
            get => GetValueOrDefault(nameof(Host), SpannerClient.DefaultEndpoint.Host);
            private set => this[nameof(Host)] = value;
        }

        /// <summary>
        /// </summary>
        public int Port
        {
            get
            {
                int result = SpannerClient.DefaultEndpoint.Port;
                string value = GetValueOrDefault(nameof(Port));
                if (!string.IsNullOrEmpty(value))
                {
                    if (!int.TryParse(value, out result))
                    {
                        result = SpannerClient.DefaultEndpoint.Port;
                    }
                }

                return result;
            }
            private set => this[nameof(Port)] = value.ToString();
        }

        /// <summary>
        /// </summary>
        public string Project => ParsedDataSourcePart(0);

        /// <summary>
        /// </summary>
        public string SpannerDatabase => ParsedDataSourcePart(2);

        /// <summary>
        /// </summary>
        public string SpannerInstance => ParsedDataSourcePart(1);

        /// <summary>
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="credential"></param>
        public SpannerConnectionStringBuilder(string connectionString, ITokenAccess credential)
        {
            connectionString.ThrowIfNullOrEmpty(nameof(connectionString));
            Credential = credential;
            ConnectionString = connectionString;
        }

        /// <summary>
        /// </summary>
        public SpannerConnectionStringBuilder() { }

        internal SpannerConnectionStringBuilder CloneWithNewDataSource(string dataSource) => new
            SpannerConnectionStringBuilder
            {
                Credential = Credential,
                Host = Host,
                Port = Port,
                DataSource = dataSource
            };

        private string GetValueOrDefault(string key, string defaultValue = "")
        {
            key = key.ToLower();
            if (ContainsKey(key))
            {
                return (string) this[key];
            }

            return defaultValue;
        }

        private string ParsedDataSourcePart(int index)
        {
            string dataSource = DataSource;
            if (string.IsNullOrEmpty(dataSource))
                return "";
            var parts = dataSource.Split('/');
            if (parts.Length == 3)
            {
                return parts[index];
            }
            else if (parts.Length == 6)
            {
                return parts[index * 2 + 1];
            }
            return "";
        }
    }
}
