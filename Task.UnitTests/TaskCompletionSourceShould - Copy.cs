using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace Tasks.UnitTests
{
    public class TaskCompletionSourceShould2
    {

        // Creates a new task on the thread pool and waits for it.
        // This method will deadlock if called in a free-threaded context.


        /*
         * (UNIT TEST)        
           13 : Button clicked, fire task
           13 : Before blocking waiting
           10 : Running task
           10 : HTTP Sending 
           5 : HTTP Got response, Before setting result
           5 : Result set
           13 : After blocking waiting, timeout?=True
           13 : End of story        */

        static async Task<string> Test()
        {
            // Indicates the task has been started and is ready.
            var taskReady = new TaskCompletionSource<string>();
            var googleClient = new GoogleClient();


            // Start the task, running on a thread pool thread.
            var task = Task.Run<string>(async () =>
            {

                // Spend a bit of time getting ready.
                await Task.Delay(TimeSpan.FromSeconds(0.5));

                // Let the Test method know we've been started and are ready.

                var responseOfGoogle = await googleClient.GetResponseFromGoogle();

                taskReady.SetResult(responseOfGoogle);
                return responseOfGoogle;

            });
           
            Dump("Before blocking waiting");
            // Wait for the task to be started and ready.
            await taskReady.Task;

            //Dump($"After blocking waiting, timeout?={timeout}");

            // Block until the task is completed.
            return task.Result;
        }

        private static void Dump(string message)
        {
            TestContext.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {message}");
        }


        [Test]
        public async Task DeadLock()
        {
            //The deadlock is due to an optimization in the implementation of await:
            //an async method’s continuation is scheduled with TaskContinuationOptions.ExecuteSynchronously.
            Task<string> test = Test();

            var taskAwaiter = test.GetAwaiter();

            var notTimeout = test.Wait(TimeSpan.FromSeconds(1));

            Check.That(notTimeout).IsFalse();
            Check.That(taskAwaiter.IsCompleted).IsFalse();

            Dump("End of story");
        }
    }
}