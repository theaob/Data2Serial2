using System;
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
        private String changeLog;
        private String downloadLink;

        private System.Net.WebClient wc = new System.Net.WebClient();

        public Updater()
        {
            InitializeComponent();
        }

        private void Updater_Load(object sender, EventArgs e)
        {
            try
            {
                if (checkForUpdates(Form1.version))
                {
                    //MessageBox.Show("A new update is available!\r\nYour Version is: " + Form1.version);
                    textBox1.Text = getChangeLog();
                }
            }
            catch (System.NotSupportedException)
            {
                MessageBox.Show("Your computer does not support this function!", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Dispose();
            }
            catch (System.Net.WebException we)
            {
                MessageBox.Show(we.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.Dispose();
            }
        }

        private bool checkForUpdates(String yourVersion)
        {
            var lines = getDataLines();

            if (lines[0] != yourVersion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private string getUpdateInfo()
        {
            System.Net.WebClient wcS = new System.Net.WebClient();

            return wcS.DownloadString("http://theaob.github.com/Data2Serial2/update");
        }

        private String[] getDataLines()
        {
            String data = getUpdateInfo();

            return data.Split(new String[]{ "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        private String getChangeLog()
        {
            return wc.DownloadString(getDataLines()[1]);
        }
    }
}
