using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

[assembly: CLSCompliant(true)]
namespace Data2Serial2
{

    public partial class Form1 : Form
    {

        private SerialPort port = new SerialPort();

        private LinkedList<String> linesRead = new LinkedList<string>();
        private LinkedList<byte[]> hexLines = new LinkedList<byte[]>();
        private String version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public Form1()
        {
            InitializeComponent();
            changeTitle(version);
            addToList("Application ("+version+") opened");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            linesRead.Clear();
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            
            String filename = openFileDialog1.FileName;
            if (filename.Length < 2)
            {
                return;
            }

            String shortName = filename.Substring(filename.LastIndexOf('\\') + 1);
            addToFileList(shortName);
            changeTitle(shortName);

            try
            {
                TextReader tr = new StreamReader(filename);

                String line = "";

                while ((line = tr.ReadLine()) != null)
                {
                    linesRead.AddLast(line);
                    hexLines.AddLast(StringToByteArray(line));
                    addToList(line);
                }

                tr.Close();
            }

            catch (System.IO.IOException)
            {
                showError("Couldn't read selected file!");
            }
        }

        private static byte[] StringToByteArray(string hex)
        {
            try
            {
                System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
                return encoding.GetBytes(hex);
            }
            catch (ArgumentOutOfRangeException)
            {
                showError("Error in hex conversion!");
            }
            catch (ArgumentNullException)
            {
                showError("Error in hex conversion!");

            }
            catch (ArgumentException)
            {
                showError("Error in hex conversion!");
            }
            return null;
        }

        private static void showError(String message)
        {
            MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions) 0);
        }

        private void changeTitle(String text)
        {
            this.Text = "Data2Serial2 - " + text;
            //Form1.ActiveForm.Text 
        }

        private void addToList(String text)
        {
            //listBox1.Items.Add(DateTime.Now.ToString("HH:mm:ss:ff | " + text));
            //Following is faster
            listBox1.Items.Insert(listBox1.Items.Count, DateTime.Now.ToString("HH:mm:ss:ff",null) + " | " + text);
            //listBox1.SetSelected(listBox1.Items.Count - 1, true);
        }


        private void addToFileList(String text)
        {
            comboBox1.Items.Insert(comboBox1.Items.Count, text);
            comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
        }

        //private void addToListSecure(String text)
        //{
        //}
    }
}
