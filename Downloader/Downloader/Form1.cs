using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoHttp;
namespace Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folder.SelectedPath;
            }
        }
        HttpDownloader downloader;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="")
            {
                MessageBox.Show("Select Your Path First!");
                return;
            }
            downloader = new HttpDownloader(textBox1.Text, $"{textBox2.Text}\\{Path.GetFileName(textBox1.Text)}");
            downloader.DownloadCompleted += Downloader_DownloadCompleted;
            downloader.ProgressChanged += Downloader_ProgressChanged;
            downloader.Start();
        }

        private void Downloader_ProgressChanged(object? sender, AltoHttp.ProgressChangedEventArgs e)
        {
            progressBar1.Value = (int)e.Progress;
            label4.Text = $"{e.Progress.ToString()}%";
            label7.Text = string.Format("{0}KB/s", (e.SpeedInBytes / 1024).ToString());
            label8.Text = string.Format("{0}MB/s", (downloader.TotalBytesReceived / 1024 / 1024).ToString());
            label3.Text = "Downlaoding..";
        }

        private void Downloader_DownloadCompleted(object? sender, EventArgs e)
        {
            this.Invoke(method: (MethodInvoker)delegate
            {
                label3.Text = "Upload completed";
                label4.Text = "100 %";
                MessageBox.Show("Upload completed Thanks for using this app");
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (downloader!=null)
            {
                downloader.Pause();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (downloader != null)
            {
                downloader.Resume();
            }
        }
    }
}
