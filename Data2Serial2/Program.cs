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
            path = path.Substring(path.LastIndexOf('\\')+1).ToLower();
            //MessageBox.Show(path);
            if (path == "data2serial2update.exe")
            {
                //This will delete the other file and rename itself
                System.IO.File.Copy("Data2Serial2Update.exe", "Data2Serial2.exe", true);
                Application.Exit();
                System.Diagnostics.Process.Start("Data2Serial2.exe");
                //MessageBox.Show("Update file");
            }
            else
            {
                if (System.IO.File.Exists("Data2Serial2Update.exe"))
                {
                    System.IO.File.Delete("Data2Serial2Update.exe");
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}
