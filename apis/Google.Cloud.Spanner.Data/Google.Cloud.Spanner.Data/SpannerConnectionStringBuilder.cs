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
using System.IO;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Spanner.Admin.Database.V1;
using Google.Cloud.Spanner.V1;
using Grpc.Auth;
using Grpc.Core;
using DatabaseName = Google.Cloud.Spanner.V1.DatabaseName;

// ReSharper disable UnusedParameter.Local
namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// A connection string builder for Spanner connection strings.
    /// The connection string should be of the form:
    /// Data Source=projects/{project}/instances/{instance}/databases/{database};[Host={hostname};][Port={portnumber}]
    /// </summary>
    public sealed class SpannerConnectionStringBuilder : DbConnectionStringBuilder
    {
        private const string CredentialFileKeyword = "CredentialFile";
        private const string DataSourceKeyword = "Data Source";
        private const string UseClrDefaultForNullKeyword = "UseClrDefaultForNull";
        private const string EnableGetSchemaTableKeyword = "EnableGetSchemaTable";
        private InstanceName _instanceName;
        private DatabaseName _databaseName;

        /// <summary>
        /// The <see cref="ChannelCredentials"/> credential used to communicate with Spanner, if explicitly
        /// set. Otherwise, this method returns null, usually indicating that default application credentials should be used.
        /// Credentials can be retrieved from a file or obtained interactively.
        /// See Google Cloud documentation for more information.
        /// </summary>
        public ChannelCredentials GetCredentials()
        {
            // Check the ctor override.
            if (CredentialOverride != null)
            {
                return CredentialOverride;
            }

            //Calculate it from the CredentialFile argument in the connection string.
            GoogleCredential credentials = null;
            string jsonFile = CredentialFile;
            if (!string.IsNullOrEmpty(jsonFile))
            {
                if (!string.Equals(Path.GetExtension(jsonFile), ".json", StringComparison.OrdinalIgnoreCase))
                {
                    throw new InvalidOperationException($"{nameof(CredentialFile)} should only be set to a JSON file.");
                }

                if (!File.Exists(jsonFile))
                {
                    //try some relative locations.
                    jsonFile = $"{GetApplicationFolder()}{Path.DirectorySeparatorChar}{jsonFile}";
                }
                if (!File.Exists(jsonFile))
                {
                    //throw a meaningful error that tells the developer where we looked.
                    throw new FileNotFoundException($"Could not find {nameof(CredentialFile)}. Also looked in {jsonFile}.");
                }
                credentials = GoogleCredential.FromFile(jsonFile).CreateScoped(SpannerClient.DefaultScopes);
            }
            return credentials?.ToChannelCredentials();
        }

        /// <summary>
        /// Optional path to a JSON Credential file. If a Credential is not supplied, Cloud Spanner
        /// will use Default Application Credentials.
        /// </summary>
        public string CredentialFile
        {
            get => GetValueOrDefault(CredentialFileKeyword);
            set => this[CredentialFileKeyword] = value;
        }

        /// <summary>
        /// Option to change between the default handling of null database values (return <see cref="DBNull.Value">DBNull.Value</see>) or
        /// the non-standard handling (return the default value for whatever type is requested).
        /// </summary>
        /// <remarks>
        /// <para>
        /// If this is <c>false</c> (the default), requesting a value from a <see cref="SpannerDataReader"/> that is null
        /// in the database will return <see cref="DBNull.Value">DBNull.Value</see>, which may cause an <see cref="InvalidCastException"/> if
        /// the requested type is not compatible with that value.
        /// </para>
        /// <para>
        /// If this is <c>true</c>, requesting a value from a <see cref="SpannerDataReader"/> that is null in the
        /// database will return the default value of the requested type (e.g. 0 or a null reference). This is the
        /// behavior from release 1.0 of this package.
        /// </para>
        /// <para>
        /// This property only sets the behavior for top-level values. For arrays and structs, null references and default values
        /// are still used if the array or struct field value is null; this provides a better general experience, allowing
        /// conversions to specific array types for example.
        /// </para>
        /// <para>
        /// This property corresponds with the value of the "UseClrDefaultForNull" part of the connection string.
        /// </para>
        /// </remarks>
        public bool UseClrDefaultForNull
        {
            get => GetValueOrDefault(UseClrDefaultForNullKeyword).Equals("True", StringComparison.OrdinalIgnoreCase);
            set => this[UseClrDefaultForNullKeyword] = value.ToString(); // Always "True" or "False", regardless of culture.
        }

        // Note: GetSchemaTable can't be a link as it wouldn't build on netstandard1.0.

        /// <summary>
        /// Option to allow <see cref="SpannerDataReader"/> to return a schema from <c>GetSchemaTable</c>, on supported platforms.
        /// Only partial information is available, and when this option is enabled, <c>DbDataAdapter</c> may be overly eager to
        /// use the information to create and manage datasets.
        /// </summary>
        public bool EnableGetSchemaTable
        {
            get => GetValueOrDefault(EnableGetSchemaTableKeyword).Equals("True", StringComparison.OrdinalIgnoreCase);
            set => this[EnableGetSchemaTableKeyword] = value.ToString(); // Always "True" or "False", regardless of culture.
        }

        /// <summary>
        /// DataSource of the Spanner database in the form of 'projects/{project}/instances/{instance}/databases/{database}'
        /// </summary>
        public string DataSource
        {
            get => GetValueOrDefault(DataSourceKeyword);
            set => this[DataSourceKeyword] = ValidatedDataSource(value);
        }

        private bool ParseCurrentDataSource()
        {
            return ParseDataSource(DataSource);
        }

        private bool ParseDataSource(string dataSource)
        {
            return DatabaseName.TryParse(dataSource, out _databaseName)
                || InstanceName.TryParse(dataSource, out _instanceName);
        }

        private string ValidatedDataSource(string dataSource)
        {
            if (!ParseDataSource(dataSource))
            {
                throw new ArgumentException(
                    $"'{dataSource}' is not a valid value for ${nameof(DataSource)}. It should be of the form "
                    + "projects/<project>/instances/<instance>/databases/<database>.", nameof(DataSource));
            }

            return dataSource;
        }

        /// <summary>
        /// The <see cref="ServiceEndpoint"/> to use to connect to Spanner. If not supplied in the
        /// connection string, the default endpoint will be used.
        /// </summary>
        public ServiceEndpoint EndPoint => new ServiceEndpoint(Host, Port);

        /// <summary>
        /// The TCP Host name to connect to Spanner. If not supplied in the connection string, the default
        /// host will be used.
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
        public string Host
        {
            get => GetValueOrDefault(nameof(Host), SpannerClient.DefaultEndpoint.Host);
            set => this[nameof(Host)] = value;
        }

        /// <summary>
        /// The TCP port number to connect to Spanner. If not supplied in the connection string, the default
        /// port will be used.
        /// </summary>
        // ReSharper disable once MemberCanBePrivate.Global
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
            set => this[nameof(Port)] = value.ToString();
        }

        /// <summary>
        /// The Spanner Project name parsed from <see cref="DataSource"/>
        /// </summary>
        public string Project
        {
            get
            {
                ParseCurrentDataSource();
                return _databaseName?.ProjectId ?? _instanceName?.ProjectId;
            }
        }

        /// <summary>
        /// The Spanner Database name parsed from <see cref="DataSource"/>
        /// </summary>
        public string SpannerDatabase
        {
            get
            {
                ParseCurrentDataSource();
                return _databaseName?.DatabaseId;
            }
        }

        /// <summary>
        /// The Spanner Instance name parsed from <see cref="DataSource"/>
        /// </summary>
        public string SpannerInstance
        {
            get
            {
                ParseCurrentDataSource();
                return _databaseName?.InstanceId ?? _instanceName?.InstanceId;
            }
        }

        internal ChannelCredentials CredentialOverride { get; }

        /// <summary>
        /// Creates a new <see cref="SpannerConnectionStringBuilder"/> with the given
        /// connection string and optional credential
        /// </summary>
        /// <param name="connectionString">A connection string of the form
        /// Data Source=projects/{project}/instances/{instance}/databases/{database};[Host={hostname};][Port={portnumber}].
        /// Must not be null.
        /// </param>
        /// <param name="credentials">Optionally supplied credential to use for the connection.
        /// If not set, then default application credentials will be used.
        /// Credentials can be retrieved from a file or obtained interactively.
        /// See Google Cloud documentation for more information. May be null.
        /// </param>
        public SpannerConnectionStringBuilder(string connectionString, ChannelCredentials credentials = null)
        {
            GaxPreconditions.CheckNotNullOrEmpty(connectionString, nameof(connectionString));
            CredentialOverride = credentials;
            ConnectionString = connectionString;
        }

        /// <summary>
        /// Creates a new <see cref="SpannerConnectionStringBuilder"/>.
        /// </summary>
        public SpannerConnectionStringBuilder() { }


        internal SpannerConnectionStringBuilder Clone() => new SpannerConnectionStringBuilder(ConnectionString, CredentialOverride);

        internal SpannerConnectionStringBuilder CloneWithNewDataSource(string dataSource)
            => new SpannerConnectionStringBuilder(ConnectionString, CredentialOverride)
            {
                DataSource = dataSource
            };

        /// <summary>
        /// Returns a new instance of a <see cref="SpannerConnectionStringBuilder"/> with the database
        /// portion of the DataSource replaced with a new value.
        /// </summary>
        /// <param name="database">The new database name. Can be null to open a connection for Ddl commands.</param>
        /// <returns>A new instance of <see cref="SpannerConnectionStringBuilder"/></returns>
        public SpannerConnectionStringBuilder WithDatabase(string database)
            => string.IsNullOrEmpty(database)
                ? CloneWithNewDataSource($"projects/{Project}/instances/{SpannerInstance}")
                : CloneWithNewDataSource($"projects/{Project}/instances/{SpannerInstance}/databases/{database}");

        private string GetValueOrDefault(string key, string defaultValue = "")
        {
            key = key.ToLower();
            if (ContainsKey(key))
            {
                return (string) this[key];
            }

            return defaultValue;
        }

        private string GetApplicationFolder()
        {
#if NETSTANDARD1_5
            return AppContext.BaseDirectory;
#else
            return AppDomain.CurrentDomain.BaseDirectory;
#endif
        }

        /// <inheritdoc />
        public override object this[string keyword]
        {
            get => base[keyword];
            set
            {
                if (string.Equals(keyword, DataSourceKeyword, StringComparison.OrdinalIgnoreCase))
                {
                    value = ValidatedDataSource((string)value);
                }
                base[keyword] = value;
            }
        }
    }
}
