using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncInLegacyUI
{
    public partial class FormNonBlockingWithTaskCompletionSourceUsingAsync : Form
    {
        public FormNonBlockingWithTaskCompletionSourceUsingAsync()
        {
            InitializeComponent();
        }

        private async void btnGetResponse_Click(object sender, EventArgs e)
        {
            textBoxResponse.Text = (await Construct())[0];
        }

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


        public async Task<List<string>> Construct()
        {
            var resultList = new List<string>();

            var taskReady = new TaskCompletionSource<string>();

            var itemTask = Task.Run<string>(async () =>
            {
                await Task.Delay(5 * 1000);
                var result = await GetResponseFromGoogle();

                taskReady.SetResult(result);

                return result;
            }).ConfigureAwait(continueOnCapturedContext: true);

            var itemResult = await itemTask;

            resultList.Add(itemResult);

            return resultList;
        }
    }
}
