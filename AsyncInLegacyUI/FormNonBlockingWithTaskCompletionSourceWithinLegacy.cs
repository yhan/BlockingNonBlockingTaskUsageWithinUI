using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NUnit.Framework;

namespace AsyncInLegacyUI
{
    public partial class FormNonBlockingWithTaskCompletionSourceWithinLegacy : Form
    {
        private readonly GoogleClient _googleClient;

        public FormNonBlockingWithTaskCompletionSourceWithinLegacy()
        {
            InitializeComponent();
            _googleClient = new GoogleClient();
        }

        /*
         * 1 : Button clicked, fire task
           1 : Before blocking waiting
           3 : Running task
           4 : HTTP Sending 
           1 : After blocking waiting, timeout?=True
           10 : HTTP Got response, Before setting result
           10 : Result set
           1 : End of story
            ================================================
         */
        private async void btnHttpGet_Click(object sender, EventArgs e)
        {
            var httpTask = _googleClient.GetResponseFromGoogle();
            var responseText = await httpTask.ConfigureAwait(true);
            this.textboxResponse.Text = responseText;

            //******************************************************************************************************************************
            //var taskReady = new TaskCompletionSource<string>();

            //Dump("Button clicked, fire task");

            //var task = Task.Run<string>(async () =>
            //{
            //    Dump("Running task");

            //    Dump("HTTP Sending ");
            //    var responseText = await _googleClient.GetResponseFromGoogle();

            //    Dump("HTTP Got response, Before setting result");

            //    taskReady.SetResult(responseText.Substring(0, 10));

            //    Dump("Result set");

            //    return taskReady.Task.Result;
            //});

            //Dump("Before blocking waiting");
            //await task.ConfigureAwait(continueOnCapturedContext: true /*SHOULD ABSOLUTELY BE TRUE, TO CAPTURE UI CONTEXT, SO THAT AFTER AWAITING, 
            //                                                            EXECUTION CAN COME BACK TO UI THREAD
            //                                                             */);

            ////Dump($"After blocking waiting, timeout?={timeout}");

            //this.textboxResponse.Text = taskReady.Task.Result;
            //Dump("End of story");

            //******************************************************************************************************************************

            //var taskReady = new TaskCompletionSource<string>();

            //Dump("Button clicked, fire task");

            //var task = Task.Run<string>(async () =>
            //{
            //    Dump("Running task");
            //    await Task.Delay(TimeSpan.FromSeconds(10));

            //    Dump("HTTP Sending ");
            //    var responseText = await _googleClient.GetResponseFromGoogle();

            //    Dump("HTTP Got response, Before setting result");

            //    taskReady.SetResult(responseText.Substring(0, 10));

            //    Dump("Result set");

            //    return taskReady.Task.Result;
            //});

            //Dump("Before blocking waiting");
            //var timeout = !task.Wait(TimeSpan.FromSeconds(5));
            //Dump($"After blocking waiting, timeout?={timeout}");

            //this.textboxResponse.Text = taskReady.Task.Result;
            //Dump("End of story");
        }


        private static void Dump(string message)
        {
            Debug.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {message}");
        }

    }
}
