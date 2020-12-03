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
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Represents a SQL query or command to execute against
    /// a Spanner database.
    /// If the command is a SQL query, then <see cref="SpannerCommand.CommandText"/>
    /// contains the entire SQL statement. Use <see cref="SpannerCommand.ExecuteReaderAsync()"/>  to obtain results.
    /// 
    /// If the command is an update, insert or delete command, then <see cref="SpannerCommand.CommandText"/>
    /// is simply "[operation] [spanner_table]" such as "UPDATE MYTABLE" with the parameter
    /// collection containing <see cref="SpannerParameter"/> instances whose name matches a column
    /// in the target table. Use <see cref="ExecuteNonQueryAsync"/> to execute the command.
    /// 
    /// The command may also be a DDL statement such as CREATE TABLE. Use <see cref="ExecuteNonQueryAsync"/>
    /// to execute a DDL statement.
    /// </summary>
    public sealed partial class SpannerCommand : DbCommand, ICloneable
    {
        private readonly CancellationTokenSource _synchronousCancellationTokenSource = new CancellationTokenSource();
        private int _commandTimeout;
        private SpannerTransaction _transaction;

        /// <summary>
        /// Initializes a new instance of <see cref="SpannerCommand"/>, using a default command timeout.
        /// </summary>
        public SpannerCommand()
        {
            DesignTimeVisible = true;
            _commandTimeout = SpannerConnectionStringBuilder.DefaultTimeout;
        }

        internal SpannerCommand(SpannerConnection connection)
        {
            SpannerConnection = connection;
            // If we have a connection, use its configuration for the default timeout.
            if (connection != null)
            {
                _commandTimeout = connection.Builder.Timeout;
            }
        }

        private SpannerCommand(
            SpannerConnection connection,
            SpannerTransaction transaction,
            SpannerParameterCollection parameters,
            CommandPartition commandPartition) : this(connection)
        {
            _transaction = transaction;
            Partition = commandPartition;
            if (parameters != null)
            {
                Parameters = parameters;
            }
        }

        /// <summary>
        /// Initializes a new instance of <see cref="SpannerCommand"/>.
        /// </summary>
        /// <remarks>
        /// The initial command timeout is taken from the options associated with <paramref name="connection"/>.
        /// </remarks>
        /// <param name="commandTextBuilder">The <see cref="SpannerCommandTextBuilder"/>
        /// that configures the text of this command. Must not be null.</param>
        /// <param name="connection">The <see cref="SpannerConnection"/> that is
        /// associated with this <see cref="SpannerCommand"/>. Must not be null.</param>
        /// <param name="transaction">An optional <see cref="SpannerTransaction"/>
        /// created through <see cref="SpannerConnection.BeginTransactionAsync" />. May be null.</param>
        /// <param name="parameters">An optional collection of <see cref="SpannerParameter"/>
        /// that is used in the command. May be null.</param>
        public SpannerCommand(
            SpannerCommandTextBuilder commandTextBuilder,
            SpannerConnection connection,
            SpannerTransaction transaction = null,
            SpannerParameterCollection parameters = null)
            : this(connection, transaction, parameters, null)
        {
            GaxPreconditions.CheckNotNull(commandTextBuilder, nameof(commandTextBuilder));
            GaxPreconditions.CheckNotNull(connection, nameof(connection));

            SpannerCommandTextBuilder = commandTextBuilder;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="SpannerCommand"/>.
        /// </summary>
        /// <param name="connection">The <see cref="SpannerConnection"/> that is
        /// associated with this <see cref="SpannerCommand"/>. Must not be null.</param>
        /// <param name="transaction">The <see cref="SpannerTransaction"/>
        /// used when creating the <see cref="CommandPartition"/>.
        /// </param>
        /// <param name="commandPartition">
        /// The partition which this command is restricted to.
        /// See <see cref="SpannerConnection.BeginReadOnlyTransaction(TransactionId)"/>
        /// </param>
        public SpannerCommand(
            SpannerConnection connection,
            SpannerTransaction transaction,
            CommandPartition commandPartition)
            : this(connection, transaction, null, commandPartition)
        {
            GaxPreconditions.CheckNotNull(connection, nameof(connection));
            GaxPreconditions.CheckNotNull(transaction, nameof(transaction));
            GaxPreconditions.CheckNotNull(commandPartition, nameof(commandPartition));
            SpannerCommandTextBuilder = SpannerCommandTextBuilder.FromCommandText(commandPartition.ExecuteSqlRequest.Sql);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="SpannerCommand"/>
        /// </summary>
        /// <param name="commandText">If this command is a SQL Query, then commandText is
        /// the SQL statement. If its an update, insert or delete command, then this text
        /// is "[operation] [table]" such as "UPDATE MYTABLE"</param>. Must not be null.
        /// <param name="connection">The <see cref="SpannerConnection"/> that is
        /// associated with this <see cref="SpannerCommand"/>. Must not be null.</param>
        /// <param name="transaction">An optional <see cref="SpannerTransaction"/>
        /// created through <see>
        /// <cref>SpannerConnection.BeginTransactionAsync</cref></see>. May be null.</param>
        /// <param name="parameters">An optional collection of <see cref="SpannerParameter"/>
        /// that is used in the command. May be null.</param>
        public SpannerCommand(
            string commandText,
            SpannerConnection connection,
            SpannerTransaction transaction = null,
            SpannerParameterCollection parameters = null)
            : this(SpannerCommandTextBuilder.FromCommandText(commandText), connection, transaction, parameters) { }

        internal SpannerCommand(string commandText, SpannerParameterCollection parameters = null)
        {
            SpannerCommandTextBuilder = SpannerCommandTextBuilder.FromCommandText(commandText);
            if(parameters != null)
            {
                Parameters = parameters;
            }
        }

        /// <inheritdoc />
        public override string CommandText
        {
            get => SpannerCommandTextBuilder?.ToString() ?? "";
            set => SpannerCommandTextBuilder = string.IsNullOrEmpty(value) ? null :
                        SpannerCommandTextBuilder.FromCommandText(value);
        }

        /// <summary>
        /// Gets or sets the wait time before terminating the attempt to execute a command and generating an error.
        /// Defaults to the timeout from the connection string.
        /// </summary>
        /// <remarks>
        /// A value of '0' normally indicates that no timeout should be used (it waits an infinite amount of time).
        /// However, if you specify AllowImmediateTimeouts=true in the connection string, '0' will cause a timeout
        /// that expires immediately. This is normally used only for testing purposes.
        /// </remarks>
        public override int CommandTimeout
        {
            get => _commandTimeout;
            set => _commandTimeout = GaxPreconditions.CheckArgumentRange(value, nameof(value), 0, int.MaxValue);
        }

        /// <inheritdoc />
        public override CommandType CommandType
        {
            get => CommandType.Text;
            set
            {
                if (value != CommandType.Text)
                {
                    throw new NotSupportedException("Cloud Spanner only supports CommandType.Text.");
                }
            }
        }

        /// <inheritdoc />
        public override bool DesignTimeVisible { get; set; }

        /// <summary>
        /// The parameters of the SQL statement or command.
        /// </summary>
        public new SpannerParameterCollection Parameters { get; } = new SpannerParameterCollection();

        /// <summary>
        /// The connection to the data source.
        /// </summary>
        public SpannerConnection SpannerConnection { get; set; }

        /// <inheritdoc />
        public override UpdateRowSource UpdatedRowSource
        {
            get => UpdateRowSource.None;
            set
            {
                if (value != UpdateRowSource.None)
                {
                    throw new NotSupportedException(
                        "Cloud Spanner does not support updating datasets on update/insert queries."
                        + " Please use UUIDs instead of auto increment columns, which can be created on the client.");
                }
            }
        }

        /// <summary>
        /// Query options to use when running SQL and streaming SQL commands.
        /// </summary>
        public QueryOptions QueryOptions { get; set; }

        // Request options for this command. Only the relevant properties are publicly exposed.
        private V1.RequestOptions RequestOptions = new V1.RequestOptions();

        /// <summary>
        /// The RPC priority to use for this command.
        /// </summary>
        public Priority Priority
        {
            get => PriorityConverter.FromProto(RequestOptions.Priority);
            set => RequestOptions.Priority = PriorityConverter.ToProto(value);
        }

        /// <inheritdoc />
        protected override DbConnection DbConnection
        {
            get => SpannerConnection;
            set => SpannerConnection = (SpannerConnection) value;
        }

        /// <inheritdoc />
        protected override DbParameterCollection DbParameterCollection => Parameters;

        // Note: Transaction and IDbCommand.Transaction both call through to this property within DbCommand.

        /// <inheritdoc />
        protected override DbTransaction DbTransaction
        {
            get => _transaction;
            set => _transaction = (SpannerTransaction) value;
        }

        // Visible for testing
        internal SpannerCommandTextBuilder SpannerCommandTextBuilder { get; private set; }

        /// <summary>
        /// The optional partition which this command is restricted to.
        /// If set, the command runs only on the data associated with the given partition.
        /// Setting this property overrides any values in <see cref="CommandText"/> and <see cref="Parameters"/>
        /// </summary>
        public CommandPartition Partition { get; set; }

        /// <summary>
        /// Returns a copy of this <see cref="SpannerCommand"/>.
        /// </summary>
        /// <returns>a copy of this <see cref="SpannerCommand"/>.</returns>
        public object Clone() => new SpannerCommand(SpannerConnection, _transaction, Parameters?.Clone(), Partition?.Clone())
        {
            DesignTimeVisible = DesignTimeVisible,
            SpannerCommandTextBuilder = SpannerCommandTextBuilder,
            CommandTimeout = CommandTimeout,
            QueryOptions = QueryOptions,
            RequestOptions = RequestOptions.Clone()
        };

        /// <inheritdoc />
        public override void Cancel() =>_synchronousCancellationTokenSource.Cancel();

        /// <inheritdoc />
        public override int ExecuteNonQuery() =>
            Task.Run(() => ExecuteNonQueryAsync(_synchronousCancellationTokenSource.Token)).ResultWithUnwrappedExceptions();

        /// <summary>
        /// Executes the command against the <see cref="SpannerConnection"/>.
        /// </summary>
        /// <remarks>
        /// <para>This method is thread safe.</para>
        /// </remarks>
        /// <param name="singleUseReadSettings">The settings to use for the implicit single-use read-only transaction.</param>
        /// <param name="cancellationToken">A cancellation token for the operation.</param>
        /// <returns>A <see cref="SpannerDataReader"/>.</returns>
        public Task<DbDataReader> ExecuteReaderAsync(TimestampBound singleUseReadSettings, CancellationToken cancellationToken = default) =>
            CreateExecutableCommand().ExecuteDbDataReaderAsync(
                CommandBehavior.Default,
                GaxPreconditions.CheckNotNull(singleUseReadSettings, nameof(singleUseReadSettings)),
                cancellationToken);

        /// <inheritdoc />
        public override Task<int> ExecuteNonQueryAsync(CancellationToken cancellationToken) =>
            CreateExecutableCommand().ExecuteNonQueryAsync(cancellationToken);

        /// <inheritdoc />
        public override object ExecuteScalar() =>
            Task.Run(() => ExecuteScalarAsync(_synchronousCancellationTokenSource.Token)).ResultWithUnwrappedExceptions();

        /// <summary>
        /// Executes the query and returns the first column of the first row in the result set returned by the query.
        /// All other columns and rows are ignored. The return value is converted to type T if possible.
        /// This method is thread safe.
        /// </summary>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <typeparam name="T">The expected return type. If possible the return type will be converted to this type.
        /// If conversion is requested between incompatible types, an <see cref="InvalidOperationException"/>
        /// will be thrown.
        /// If the conversion fails due to the contents returned (for example a string representing a
        /// boolean does not have either 'true' or 'false') then a <see cref="FormatException"/> exception will be
        /// thrown as documented by the <see cref="Convert"/> class.</typeparam>
        /// <returns>The first column of the first row resulting from execution of the query.</returns>
        public Task<T> ExecuteScalarAsync<T>(CancellationToken cancellationToken = default) =>
            CreateExecutableCommand().ExecuteScalarAsync<T>(cancellationToken);

        /// <inheritdoc />
        public override Task<object> ExecuteScalarAsync(CancellationToken cancellationToken) =>
            ExecuteScalarAsync<object>(cancellationToken);

        /// <inheritdoc />
        public override void Prepare()
        {
            //Spanner does not support preoptimized queries nor 2 phase commit transactions.
        }

        /// <inheritdoc />
        protected override DbParameter CreateDbParameter() => new SpannerParameter();

        /// <inheritdoc />
        protected override void Dispose(bool disposing) { }

        /// <summary>
        /// Creates a set of <see cref="CommandPartition"/> objects that are used to execute a query
        /// operation in parallel.  Each of the returned command partitions are used
        /// by <see cref="SpannerConnection.CreateCommandWithPartition"/> to create a new <see cref="SpannerCommand"/>
        /// that returns a subset of data.
        /// </summary>
        /// <param name="maxPartitions">
        /// The desired maximum number of partitions to return.  For example, this may
        /// be set to the number of workers available.  The default for this option
        /// is currently 10,000. The maximum value is currently 200,000.  This is only
        /// a hint.  The actual number of partitions returned may be smaller or larger than
        /// this maximum count request.
        /// </param>
        /// <param name="partitionSizeBytes">
        /// The desired data size for each partition generated.  The default for this
        /// option is currently 1 GiB.  This is only a hint. The actual size of each
        /// partition may be smaller or larger than this size request.
        /// </param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>The list of partitions that can be used to create <see cref="SpannerCommand"/>
        /// objects.</returns>
        public Task<IReadOnlyList<CommandPartition>> GetReaderPartitionsAsync(
            long? partitionSizeBytes = null,
            long? maxPartitions = null,
            CancellationToken cancellationToken = default) =>
            CreateExecutableCommand().GetReaderPartitionsAsync(partitionSizeBytes, maxPartitions, cancellationToken);

        /// <summary>
        /// Sends the command to Cloud Spanner and builds a <see cref="SpannerDataReader"/>.
        /// </summary>
        /// <returns>An asynchronous <see cref="Task"/> that produces a <see cref="SpannerDataReader"/>.</returns>
        public new Task<SpannerDataReader> ExecuteReaderAsync() =>
            ExecuteReaderAsync(CommandBehavior.Default, CancellationToken.None);

        /// <summary>
        /// Sends the command to Cloud Spanner and builds a <see cref="SpannerDataReader"/>.
        /// </summary>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>An asynchronous <see cref="Task"/> that produces a <see cref="SpannerDataReader"/>.</returns>
        public new Task<SpannerDataReader> ExecuteReaderAsync(CancellationToken cancellationToken) =>
            ExecuteReaderAsync(CommandBehavior.Default, cancellationToken);

        /// <summary>
        /// Sends the command to Cloud Spanner and builds a <see cref="SpannerDataReader"/>.
        /// </summary>
        /// <param name="behavior">Options for statement execution and data retrieval.</param>
        /// <returns>An asynchronous <see cref="Task"/> that produces a <see cref="SpannerDataReader"/>.</returns>
        public new Task<SpannerDataReader> ExecuteReaderAsync(CommandBehavior behavior) =>
            ExecuteReaderAsync(behavior, CancellationToken.None);

        /// <summary>
        /// Sends the command to Cloud Spanner and builds a <see cref="SpannerDataReader"/>.
        /// </summary>
        /// <param name="behavior">Options for statement execution and data retrieval.</param>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>An asynchronous <see cref="Task"/> that produces a <see cref="SpannerDataReader"/>.</returns>
        public new async Task<SpannerDataReader> ExecuteReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken) =>
            (SpannerDataReader) await ExecuteDbDataReaderAsync(behavior, cancellationToken).ConfigureAwait(false);

        /// <inheritdoc />
        protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior) =>
            Task.Run(() => CreateExecutableCommand().ExecuteDbDataReaderAsync(behavior, null, _synchronousCancellationTokenSource.Token)).ResultWithUnwrappedExceptions();

        /// <inheritdoc />
        protected override Task<DbDataReader> ExecuteDbDataReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken) =>
            CreateExecutableCommand().ExecuteDbDataReaderAsync(behavior, null, cancellationToken);

        /// <summary>
        /// Executes this command as a partitioned update. The command must be a generalized DML command;
        /// <see cref="SpannerConnection.CreateDmlCommand(string, SpannerParameterCollection)"/> for details.
        /// </summary>
        /// <remarks>
        /// The command is executed in parallel across multiple partitions, and automatically committed as it executes.
        /// This operation is not atomic: if it is cancelled part way through, the data that has already been updated will
        /// remain updated. Additionally, it is performed "at least once" in each partition; if the statement is non-idempotent
        /// (for example, incrementing a column) then the update may be performed more than once on a given row. 
        /// This command must not be part of any other transaction.
        /// </remarks>
        /// <returns>A lower bound for the number of rows affected.</returns>
        public long ExecutePartitionedUpdate() =>
            Task.Run(() => ExecutePartitionedUpdateAsync(_synchronousCancellationTokenSource.Token)).ResultWithUnwrappedExceptions();

        /// <summary>
        /// Executes this command as a partitioned update. The command must be a generalized DML command;
        /// <see cref="SpannerConnection.CreateDmlCommand(string, SpannerParameterCollection)"/> for details.
        /// </summary>
        /// <remarks>
        /// The command is executed in parallel across multiple partitions, and automatically committed as it executes.
        /// This operation is not atomic: if it is cancelled part way through, the data that has already been updated will
        /// remain updated. Additionally, it is performed "at least once" in each partition; if the statement is non-idempotent
        /// (for example, incrementing a column) then the update may be performed more than once on a given row. 
        /// This command must not be part of any other transaction.
        /// </remarks>
        /// <param name="cancellationToken">An optional token for canceling the call.</param>
        /// <returns>A task whose result is a lower bound for the number of rows affected.</returns>
        public Task<long> ExecutePartitionedUpdateAsync(CancellationToken cancellationToken = default) =>
            CreateExecutableCommand().ExecutePartitionedUpdateAsync(cancellationToken);

        /// <summary>
        /// Creates an executable command that captures all the necessary information from this command.
        /// </summary>
        private ExecutableCommand CreateExecutableCommand() => new ExecutableCommand(this);
    }
}
