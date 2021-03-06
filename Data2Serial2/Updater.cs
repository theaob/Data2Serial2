﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Data2Serial2
{
    public partial class Updater : Form
    {
        private String onlineVersion;
        private String changeLogLink;
        private String downloadLink;

        private String thisVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

        private System.Net.WebClient wc = new System.Net.WebClient();

        String updateURL = "http://theaob.github.com/Data2Serial2/update";
        String updateString;

        public Updater()
        {
            InitializeComponent();
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            try
            {
                wc.DownloadStringCompleted += new System.Net.DownloadStringCompletedEventHandler(downloadCompleteHandler);
                wc.DownloadStringAsync(new Uri(updateURL), updateString);
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("There was an error caused by your internet connection. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
                return;
            }
            catch (System.NotSupportedException)
            {
                MessageBox.Show("There was an error caused by your internet connection. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
                return;
            }
            
        }

        private void downloadCompleteHandler(object sender, System.Net.DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error,MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
                return;
            }
            updateString = e.Result;

            processUpdateString();
        }

        private void processUpdateString()
        {
            if (String.IsNullOrEmpty(updateString))
            {
                MessageBox.Show("File was corrupt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
                return;
            }

            String[] lines = updateString.Split(new String[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            onlineVersion = lines[0];
            changeLogLink = lines[1];
            downloadLink = lines[2];

            if (String.IsNullOrEmpty(onlineVersion) || String.IsNullOrEmpty(changeLogLink) || String.IsNullOrEmpty(downloadLink))
            {
                MessageBox.Show("File was corrupt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
                return;
            }

            label1.Text = label1.Text.Replace("{{yourversion}}", thisVersion);
            label1.Text = label1.Text.Replace("{{newversion}}", onlineVersion);

            System.Version thisVersionZ = new Version(thisVersion);
            System.Version onlineVersionZ = new Version(onlineVersion);

            if (thisVersionZ < onlineVersionZ)
            {

                System.Net.WebClient wc2 = new System.Net.WebClient();
                wc2.DownloadStringCompleted += new System.Net.DownloadStringCompletedEventHandler(wc2_DownloadStringCompleted);
                wc2.DownloadStringAsync(new Uri(changeLogLink));
            }
            else
            {
                MessageBox.Show("You have the latest version installed", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
                this.Dispose();
            }
        }

        void wc2_DownloadStringCompleted(object sender, System.Net.DownloadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
                return;
            }
            textBox1.Text = e.Result.Replace("\n","\r\n");

            textBox1.Select(0, 0);

            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Updater_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("Data2Serial2Update.exe"))
            {
                MessageBox.Show("In order to download the update again, you have to delete it manually. There will be an explorer window opening for this purpose.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
                System.Diagnostics.Process.Start("explorer.exe", "/select," + "Data2Serial2Update.exe");
            }
            else
            {
                System.Net.WebClient wc3 = new System.Net.WebClient();
                wc3.DownloadProgressChanged += new System.Net.DownloadProgressChangedEventHandler(wc3_DownloadProgressChanged);
                wc3.DownloadFileCompleted += new AsyncCompletedEventHandler(wc3_DownloadFileCompleted);
                wc3.DownloadFileAsync(new Uri(downloadLink), "Data2Serial2Update.exe");
            }
        }

        void wc3_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download finished!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
            Application.Exit();
            System.Diagnostics.Process.Start("Data2Serial2Update.exe");
            //throw new NotImplementedException();
        }

        void wc3_DownloadProgressChanged(object sender, System.Net.DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            progressBar1.PerformStep();
            progressBar1.Refresh();
        }
    }
}
