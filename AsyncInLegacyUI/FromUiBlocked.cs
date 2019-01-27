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
    public partial class FromUiBlocked : Form
    {
        public FromUiBlocked()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            var googleClient = new GoogleClient();
            /*OK => */
            this.txtboxResponse.Text = await googleClient.GetResponseFromGoogle(TimeSpan.FromSeconds(5));

            //var result = Task.Run<string>(() => { return googleClient.GetResponseFromGoogle(TimeSpan.FromSeconds(5)); })
            //    .Result;

            //txtboxResponse.Text = result;
        }


        public async Task<string> GetResponseFromGoogle()
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://www.google.com")
            };

            await Task.Delay(TimeSpan.FromSeconds(5));
            var response = await httpClient.GetAsync("");
            var content = await response.Content.ReadAsStringAsync();

            return content;
        }

        public void Construct(List<string> initialList)
        {
            var item = Task.Run<string>(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(5));
                return await GetResponseFromGoogle();
            }).Result;
            initialList.Add(item);
        }

        private void btnClearResponse_Click(object sender, EventArgs e)
        {
            this.txtboxResponse.Clear();
        }
    }
}
