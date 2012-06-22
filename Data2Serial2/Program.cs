using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Data2Serial2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String path = Application.ExecutablePath;
            if (path.Substring(path.IndexOf('\\')) == "Data2Serial2Update.exe")
            {
                MessageBox.Show("Update file");
            }
            else
            {
                MessageBox.Show("Old file");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
