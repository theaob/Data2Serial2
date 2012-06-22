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
        private String changeLogLink;
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
                getUpdateInfo();

                label1.Text = label1.Text.Replace("{{yourversion}}", Form1.version);
                label1.Text = label1.Text.Replace("{{newversion}}", onlineVersion);

                if (onlineVersion != Form1.version)
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

        private void getUpdateInfo()
        {
            String update = wc.DownloadString("http://theaob.github.com/Data2Serial2/update");
            String[] lines = update.Split(new String[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            onlineVersion = lines[0];
            changeLogLink = lines[1];
            downloadLink = lines[2];
        }

        private String getChangeLog()
        {
            return wc.DownloadString(changeLogLink);
        }
    }
}
