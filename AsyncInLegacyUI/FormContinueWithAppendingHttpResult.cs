using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncInLegacyUI
{
    public partial class FormContinueWithAppendingHttpResult : Form
    {
        public FormContinueWithAppendingHttpResult()
        {
            InitializeComponent();
        }

        private void btnHttpGet_Click(object sender, EventArgs e)
        {
            var list = new List<string>();
            list.Add("Hello world");

            Construct(list);
            foreach (var item in list)
            {
                this.textBoxResponse.Text = $"{this.textBoxResponse.Text}{Environment.NewLine}{item}";
            }
        }

        public void Construct(List<string> initialList)
        {
            var googleClient = new GoogleClient();

            var task = Task.Run<string>(async () =>
            {
                //await Task.Delay(TimeSpan.FromSeconds(5));

                return await googleClient.GetResponseFromGoogle();
            });

            initialList.Add(task.Result);

            task.Wait();


            //var task = Task.Run<string>(() =>
            //    {
            //        //Task.Delay(TimeSpan.FromSeconds(5));

            //        return googleClient.GetResponseFromGoogle();
            //    })
            //    .ContinueWith(t =>
            //    {
            //        initialList.Add(t.Result);
            //        foreach (var item in initialList)
            //        {
            //            this.textBoxResponse.Text = $"{this.textBoxResponse.Text}{Environment.NewLine}{item}";
            //        }
            //    }, TaskScheduler.FromCurrentSynchronizationContext());


            //var task = Task.Run<string>(async () =>
            //    {
            //        await Task.Delay(TimeSpan.FromSeconds(5));
            //        var googleClient = new GoogleClient();

            //        return await googleClient.GetResponseFromGoogle();
            //    })
            //.ContinueWith(t =>
            //{
            //    //  This works

            //    initialList.Add(t.Result);
            //}, TaskScheduler.Current);

            //task.Wait();
        }
    }
}
