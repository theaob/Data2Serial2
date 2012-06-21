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
        private LinkedList<byte[]> byteLines = new LinkedList<byte[]>();
        private String version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();


        //Used Variables

        private int manualRepeat = 1;
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
                    byteLines.AddLast(StringToByteArray(line));
                }

                tr.Close();

                progressBar1.Maximum = linesRead.Count;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                tabControl1.SelectedIndex = 0;
                return;
            }

            if (fileDumpThread.IsBusy)
            {
                fileDumpThread.CancelAsync();
            }
            else
            {
                fileDumpThread.RunWorkerAsync();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                tabControl1.SelectedIndex = 0;
                return;
            }
            
            String sendThis = manualSendCommandBox.Text;
            if (sendThis.Length < 1 || sendThis == null)
            {
                return;
            }

            if (CRCheckBox.Checked)
            {
                sendThis += "\r";
            }

            if (LFCheckBox.Checked)
            {
                sendThis += "\n";
            }

            if (SpaceStripCheckBox.Checked)
            {
                sendThis = sendThis.Replace(" ", "");
            }

            if (!manualSendThread.IsBusy)
            {
                manualSendThread.RunWorkerAsync(sendThis);
            }
        }

        private void manualSendRepeatBox_Enter(object sender, EventArgs e)
        {
            if (manualSendRepeatBox.Text == "Repeats (0)" || manualSendRepeatBox.Text == "Integer Only")
            {
                manualSendRepeatBox.Text = "";
            }
        }

        private void manualSendRepeatBox_Leave(object sender, EventArgs e)
        {
            if (manualSendRepeatBox.Text.Trim().Length < 1)
            {
                manualSendRepeatBox.Text = "Repeats (0)";
            }
            else
            {
                if (!IsItAPositiveNumber(manualSendRepeatBox.Text, out manualRepeat))
                {
                    manualSendRepeatBox.Text = "Integer Only";
                }
            }
        }

        private void addToListSecure(String text)
        {
            Invoke((MethodInvoker)(() =>
                        {
                            addToList(text);
                        }));
        }

        private static bool IsItAPositiveNumber(String numberString, out int parseIntoThis)
        {
            try
            {
                parseIntoThis = int.Parse(numberString,null);
                if (parseIntoThis < 0)
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                parseIntoThis = 0;
                return false;
            }
            catch (OverflowException)
            {
                parseIntoThis = 0;
                return false;
            }
            catch (ArgumentNullException)
            {
                parseIntoThis = 0;
                return false;
            }
            return true;
        }

        private void openPortButton_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                port.Close();
                openPortButton.Text = "Open Port";
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
                groupBox7.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                baudRateComboBox.Enabled = true;
                portComboBox.Enabled = true;
                scanPortButton.Enabled = true;
                return;
            }

            try
            {

                int baudRate = 9600;
                if(IsItAPositiveNumber(baudRateComboBox.SelectedItem.ToString(),out baudRate))
                {
                    port.BaudRate = baudRate;
                }

                switch (parityComboBox.SelectedItem.ToString())
                {
                    case "None":
                        {
                            port.Parity = Parity.None;
                            break;
                        }
                    case "Odd":
                        {
                            port.Parity = Parity.Odd;
                            break;
                        }
                    case "Even":
                        {
                            port.Parity = Parity.Even;
                            break;
                        }
                    case "Mark":
                        {
                            port.Parity = Parity.Mark;
                            break;
                        }
                    case "Space":
                        {
                            port.Parity = Parity.Space;
                            break;
                        }
                }

                switch (dataBitsComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            port.DataBits = 8;
                            break;
                        }
                    case 1:
                        {
                            port.DataBits = 7;
                            break;
                        }
                    case 2:
                        {
                            port.DataBits = 6;
                            break;
                        }
                    case 3:
                        {
                            port.DataBits = 5;
                            break;
                        }
                }

                switch (stopBitsComboBox.SelectedIndex)
                {
                    case 0:
                        {
                            port.StopBits = StopBits.None;
                            break;
                        }
                    case 1: { port.StopBits = StopBits.One; break; }
                    case 2: { port.StopBits = StopBits.OnePointFive; break; }
                    case 3: { port.StopBits = StopBits.Two; break; }
                }

                port.PortName = portComboBox.SelectedItem.ToString();
            
                port.Open();
                openPortButton.Text = "Close Port";

                addToList(port.PortName + " is open!");
                //tabControl1.Enabled = false;
                //groupBox4.E
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                baudRateComboBox.Enabled = false;
                portComboBox.Enabled = false;
                scanPortButton.Enabled = false;
                //openPortButton.Enabled = true;
                tabControl1.SelectedIndex = 1;
            }
            catch (InvalidOperationException)
            {
                showError("Couldn't open port. Please check your settings.");
            }
            catch (ArgumentOutOfRangeException)
            {
                showError("Couldn't open port. Please check your settings.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPortsIntoCombobox();
            baudRateComboBox.SelectedIndex = 0;
            stopBitsComboBox.SelectedIndex = 1;
            dataBitsComboBox.SelectedIndex = 0;
            parityComboBox.SelectedIndex = 0;
            
        }

        private void loadPortsIntoCombobox()
        {
            portComboBox.Items.Clear();
            String[] ports = SerialPort.GetPortNames();
            foreach (String portString in ports)
            {
                try
                {
                    port.PortName = portString;
                    port.Open();
                    portComboBox.Items.Add(portString);
                    port.Close();
                }
                catch (UnauthorizedAccessException)
                {
                }
            }
            portComboBox.SelectedIndex = 0;
        }

        private void scanPortButton_Click(object sender, EventArgs e)
        {
            loadPortsIntoCombobox();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void dropStringOnLine(String output)
        {
            port.Write(output);
        }

        private void manualSendThread_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < manualRepeat; i++)
            {
                addToListSecure(e.Argument.ToString());
                dropStringOnLine(e.Argument.ToString());
            }
        }

        private void fileDumpThread_DoWork(object sender, DoWorkEventArgs e)
        {
            int progress = 0;
            foreach (String sendThis in linesRead)
            {
                if (fileDumpThread.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                port.Write(sendThis);
                addToListSecure("Sent : " + sendThis);
                fileDumpThread.ReportProgress(progress++);
            }
        }

        private void fileDumpThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            //progressBar1.PerformStep();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fileDumpThread.IsBusy)
            {
                fileDumpThread.CancelAsync();
            }
            else if (manualSendThread.IsBusy)
            {
                manualSendThread.CancelAsync();
            }
            else if (receiveThread.IsBusy)
            {
                receiveThread.CancelAsync();
            }
        }


    }
}
