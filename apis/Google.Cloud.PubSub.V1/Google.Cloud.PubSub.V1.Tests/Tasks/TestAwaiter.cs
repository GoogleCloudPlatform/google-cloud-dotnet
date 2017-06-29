﻿// Copyright 2017, Google Inc. All rights reserved.
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

using Google.Cloud.PubSub.V1.Tasks;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1.Tests.Tasks
{
    internal class TestAwaiter : ITaskAwaiter
    {
        public TestAwaiter(Task task, TaskScheduler taskScheduler)
        {
            _task = task;
            _taskScheduler = taskScheduler;
        }

        private Task _task;
        private TaskScheduler _taskScheduler;

        public void OnCompleted(Action continuation) =>
            _task.ContinueWith(_ => continuation(), CancellationToken.None, TaskContinuationOptions.DenyChildAttach, _taskScheduler);
        public void UnsafeOnCompleted(Action continuation) =>
            _task.ContinueWith(_ => continuation(), CancellationToken.None, TaskContinuationOptions.DenyChildAttach, _taskScheduler);
        public bool IsCompleted => _task.IsCompleted;
        public void GetResult()
        {
            switch (_task.Status)
            {
                case TaskStatus.RanToCompletion: return;
                case TaskStatus.Canceled: throw new TaskCanceledException(_task);
                case TaskStatus.Faulted: throw _task.Exception.InnerException;
                default: throw new InvalidOperationException();
            }
        }
    }

    internal class TestAwaiter<T> : ITaskAwaiter<T>
    {
        public TestAwaiter(Task<T> task, TaskScheduler taskScheduler)
        {
            _task = task;
            _taskScheduler = taskScheduler;
        }

        private Task<T> _task;
        private TaskScheduler _taskScheduler;

        public void OnCompleted(Action continuation) =>
            _task.ContinueWith(_ => continuation(), CancellationToken.None, TaskContinuationOptions.DenyChildAttach, _taskScheduler);
        public void UnsafeOnCompleted(Action continuation) =>
            _task.ContinueWith(_ => continuation(), CancellationToken.None, TaskContinuationOptions.DenyChildAttach, _taskScheduler);
        public bool IsCompleted => _task.IsCompleted;
        public T GetResult()
        {
            switch (_task.Status)
            {
                case TaskStatus.RanToCompletion: return _task.Result;
                case TaskStatus.Canceled: throw new TaskCanceledException(_task);
                case TaskStatus.Faulted: throw _task.Exception.InnerException;
                default: throw new InvalidOperationException();
            }
        }
    }
}
