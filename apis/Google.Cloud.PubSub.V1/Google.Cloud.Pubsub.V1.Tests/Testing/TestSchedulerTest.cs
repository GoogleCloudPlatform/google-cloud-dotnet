﻿using Google.Cloud.PubSub.V1.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using static Google.Cloud.PubSub.V1.Tests.Testing.TestScheduler;

namespace Google.Cloud.PubSub.V1.Tests.Testing
{
    public class TestSchedulerTest
    {
#pragma warning disable CS1998
        // Deliberately testing an async method with no await
        private async Task<int> GetANumber1()
        {
            return 111;
        }
#pragma warning restore CS1998

        private Task<int> GetANumber2()
        {
            return Task.FromResult(222);
        }

        private async Task<int> WaitTest(TestScheduler sch, int i)
        {
            if (i < 10)
            {
                await sch.TaskHelper.ConfigureAwait(sch.Delay(TimeSpan.FromSeconds(i), CancellationToken.None));
            }
            return i;
        }

        private DateTime Dt(int seconds) => new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Utc) + TimeSpan.FromSeconds(seconds);

        // TODO: More testing required!

        [Fact]
        public void BasicFunctionality()
        {
            var scheduler = new TestScheduler();
            TaskHelper taskHelper = scheduler.TaskHelper;
            var number = scheduler.Run(async () =>
            {
                Assert.Equal(Dt(0), scheduler.Clock.GetCurrentDateTimeUtc());
                await taskHelper.ConfigureAwait(scheduler.Delay(TimeSpan.FromSeconds(10), CancellationToken.None));
                Assert.Equal(Dt(10), scheduler.Clock.GetCurrentDateTimeUtc());
                await taskHelper.ConfigureAwait(scheduler.Delay(TimeSpan.FromSeconds(10), CancellationToken.None));
                Assert.Equal(Dt(20), scheduler.Clock.GetCurrentDateTimeUtc());
                int n1 = await taskHelper.ConfigureAwait(GetANumber1());
                Assert.Equal(111, n1);
                int n2 = await taskHelper.ConfigureAwait(GetANumber2());
                Assert.Equal(222, n2);
                Task<int>[] tasks = new Task<int>[1000];
                for (int i = 0; i < tasks.Length; i++)
                {
                    tasks[i] = WaitTest(scheduler, i);
                }
                await taskHelper.ConfigureAwait(Task.WhenAll(tasks));
                return tasks.Sum(x => x.Result);
            });
            Assert.Equal(1000 * 999 / 2, number);
        }

        [Fact]
        public void WaitThreadDepletionDetection()
        {
            // Throws with 1 thread
            var scheduler1 = new TestScheduler(threadCount: 1);
            Assert.Throws<SchedulerException>(() =>
            {
                scheduler1.Run(() =>
                {
                    Task task = scheduler1.Delay(TimeSpan.FromHours(1), CancellationToken.None);
                    scheduler1.TaskHelper.Wait(task);
                });
            });

            // Does not throw (and completes) with 2 threads
            var scheduler2 = new TestScheduler(threadCount: 2);
            scheduler2.Run(() =>
            {
                Task task = scheduler2.Delay(TimeSpan.FromHours(1), CancellationToken.None);
                scheduler2.TaskHelper.Wait(task);
            });
        }
    }
}
