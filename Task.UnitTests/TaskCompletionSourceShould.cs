using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace Tasks.UnitTests
{

    /// <summary>
    /// References: https://blog.stephencleary.com/2012/12/dont-block-in-asynchronous-code.html
    /// </summary>
    public class TaskCompletionSourceShould
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

            Dump("Button clicked, fire task");

            // Start the task, running on a thread pool thread.
            var task = Task.Run<string>(async () =>
            {
                Dump("Running task");

                // Spend a bit of time getting ready.
                await Task.Delay(TimeSpan.FromSeconds(0.5));

                // Let the Test method know we've been started and are ready.
                Dump("HTTP Sending ");

                var response = await googleClient.GetResponseFromGoogle();

                Dump("HTTP Got response, Before setting result");
                taskReady.SetResult(response);
                Dump("Result set");
                return response;

            });
            // Block until the task is completed.
            Dump("Before blocking waiting");

            // Wait for the task to be started and ready.
            var responseOfGoogle = await taskReady.Task;
            Check.That(responseOfGoogle).IsNotEmpty();
            
            //Dump($"After blocking waiting, timeout?={timeout}");

            return responseOfGoogle;
        }

        private static void Dump(string message)
        {
            TestContext.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {message}");
        }


        [Test]
        public async Task Not_DeadLock()
        {
            //The deadlock is due to an optimization in the implementation of await:
            //an async method�s continuation is scheduled with TaskContinuationOptions.ExecuteSynchronously.
            
            var responseOfGoogle = await Test();
            Check.That(responseOfGoogle).StartsWith("<!doctype html>");

            Dump("End of story");
        }
    }


    public class GoogleClient
    {
        public async Task<string> GetResponseFromGoogle()
        {
            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http://www.google.com")
            };

            var response = await httpClient.GetAsync("");
            var content = await response.Content.ReadAsStringAsync();

            return content;
        }
    }
}