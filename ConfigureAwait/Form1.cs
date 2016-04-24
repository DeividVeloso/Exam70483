using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigureAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            string content = await httpClient.GetStringAsync("http://www.microsoft.com").ConfigureAwait(true);
            //Output.Content = content;
            //this.label1.Text = content;
            Thread.Sleep(3000);
            using (FileStream sourceStream = new FileStream("temp.html",FileMode.Create, FileAccess.Write, FileShare.None, 4096, useAsync: true))
            {
                byte[] encodedText = Encoding.Unicode.GetBytes(content);
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length)
                .ConfigureAwait(true);
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text = "trocou";
        }
    }
}
