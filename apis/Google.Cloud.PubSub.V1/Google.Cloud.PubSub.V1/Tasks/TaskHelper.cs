﻿using System;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1.Tasks
{
    internal abstract class TaskHelper
    {
        private class DefaultTaskHelper : TaskHelper
        {
            public override TaskScheduler TaskScheduler => TaskScheduler.Default;
            public override Task<T> Run<T>(Func<Task<T>> function) => Task.Run(function);
            public override void Wait(Task task) => task.Wait();
            public override TaskAwaitable ConfigureAwait(Task task) => new TaskAwaitable(task, null);
            public override TaskAwaitable<T> ConfigureAwait<T>(Task<T> task) => new TaskAwaitable<T>(task, null);
        }

        public static TaskHelper Default { get; } = new DefaultTaskHelper();

        public virtual TaskScheduler TaskScheduler { get { throw new NotImplementedException(); } }
        public virtual Task<T> Run<T>(Func<Task<T>> function) { throw new NotImplementedException(); }
        public virtual void Wait(Task task) { throw new NotImplementedException(); }
        public virtual TaskAwaitable ConfigureAwait(Task task) { throw new NotImplementedException(); }
        public virtual TaskAwaitable<T> ConfigureAwait<T>(Task<T> task) { throw new NotImplementedException(); }
    }
}
