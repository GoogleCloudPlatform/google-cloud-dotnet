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
using System.Data;
using System.Linq;
using Xunit;

namespace Google.Cloud.Spanner.Data.Tests
{
    public class SpannerCommandTests
    {
        [Fact]
        public void CommandTypeSupportsOnlyCommandText()
        {
            var command = new SpannerCommand();
            Assert.Throws<NotSupportedException>(() => command.CommandType = CommandType.StoredProcedure);
            Assert.Throws<NotSupportedException>(() => command.CommandType = CommandType.TableDirect);
            command.CommandType = CommandType.Text;
            Assert.Equal(CommandType.Text, command.CommandType);
        }

        [Fact]
        public void UpdateRowSourceNotSupported()
        {
            var command = new SpannerCommand();
            Assert.Throws<NotSupportedException>(() => command.UpdatedRowSource = UpdateRowSource.Both);
            Assert.Throws<NotSupportedException>(() => command.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord);
            Assert.Throws<NotSupportedException>(() => command.UpdatedRowSource = UpdateRowSource.OutputParameters);
            command.UpdatedRowSource = UpdateRowSource.None;
            Assert.Equal(UpdateRowSource.None, command.UpdatedRowSource);
        }

        [Fact]
        public void PrepareNoop()
        {
            var command = new SpannerCommand();
            command.Prepare();
        }

        [Fact]
        public void CreatesSpannerParameter()
        {
            var command = new SpannerCommand();
            Assert.IsType<SpannerParameter>(command.CreateParameter());
        }

        [Fact]
        public void CloneQuery()
        {
            var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");
            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            var command2 = (SpannerCommand)command.Clone();
            Assert.Same(command.SpannerConnection, command2.SpannerConnection);
            Assert.Equal(command.CommandText, command2.CommandText);
        }

        [Fact]
        public void CloneUpdateWithParameters()
        {
            var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");
            var command = connection.CreateUpdateCommand(
                "T", new SpannerParameterCollection
                {
                    {"P1", SpannerDbType.String},
                    {"P2", SpannerDbType.Float64}
                });

            var command2 = (SpannerCommand)command.Clone();
            Assert.Same(command.SpannerConnection, command2.SpannerConnection);
            Assert.Equal(command.CommandText, command2.CommandText);
            Assert.Equal(command.Parameters.Count, command2.Parameters.Count);
            Assert.NotSame(command.Parameters, command2.Parameters);
            Assert.True(command.Parameters.SequenceEqual(command2.Parameters));
        }

        [Fact]
        public void CommandHasConnectionQueryOptions()
        {
            var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");
            var queryOptions = new QueryOptions{ OptimizerVersion = "1" };
            connection.QueryOptions = queryOptions;

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            Assert.Equal(queryOptions, command.QueryOptions);
        }

        [Fact]
        public void CommandHasOptimizerVersionFromEnvironment()
        {
            // Save existing value of environment variable.
            const string optimizerVersionVariable = "SPANNER_OPTIMIZER_VERSION";
            string savedOptimizerVersion = Environment.GetEnvironmentVariable(optimizerVersionVariable);
            const string envOptimizerVersion = "2";
            Environment.SetEnvironmentVariable(optimizerVersionVariable, envOptimizerVersion);

            var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");
            connection.QueryOptions = new QueryOptions{ OptimizerVersion = "1" };

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            // Optimizer version set through environment variable has higher
            // precedence than version set through connection.
            Assert.Equal(envOptimizerVersion, command.QueryOptions.OptimizerVersion);

            // Set the environment back.
            Environment.SetEnvironmentVariable(optimizerVersionVariable, savedOptimizerVersion);
        }

        [Fact]
        public void CommandHasOptimizerVersionSetOnCommand()
        {
            // Save existing value of environment variable.
            const string optimizerVersionVariable = "SPANNER_OPTIMIZER_VERSION";
            string savedOptimizerVersion = Environment.GetEnvironmentVariable(optimizerVersionVariable);
            const string envOptimizerVersion = "2";
            Environment.SetEnvironmentVariable(optimizerVersionVariable, envOptimizerVersion);

            var connection = new SpannerConnection("Data Source=projects/p/instances/i/databases/d");
            connection.QueryOptions = new QueryOptions{ OptimizerVersion = "1" };

            var command = connection.CreateSelectCommand("SELECT * FROM FOO");
            var commandOptimizerVersion = "3";
            command.QueryOptions = new QueryOptions{ OptimizerVersion = commandOptimizerVersion };
            // Optimizer version set at a command level has higher precedence
            // than version set through the connection or the environment
            // variable.
            Assert.Equal(commandOptimizerVersion, command.QueryOptions.OptimizerVersion);

            // Set the environment back.
            Environment.SetEnvironmentVariable(optimizerVersionVariable, savedOptimizerVersion);
        }

    }
}
