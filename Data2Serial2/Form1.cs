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

        private System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

        private Color cancelButtonColor = Settings1.Default.cancelButtonColor;
        private Color sendButtonColor = Settings1.Default.sendButtonColor;
        private Color sendButtonTextColor = Settings1.Default.sendButtonTextColor;
        private Color cancelButtonTextColor = Settings1.Default.cancelButtonTextColor;

        String updateFile = "";

        Updater updateDialog = new Updater();
        //Used Variables

        private int manualRepeat = 1;
        public Form1()
        {
            InitializeComponent();
            changeTitle(version);
            addToList("Application ("+version+") opened");
            colorizeButtons();
            refreshColors();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                tabControl1.SelectedIndex = 0;
                return;
            }

            linesRead.Clear();
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            
            String filename = openFileDialog1.FileName;
            if (filename.Length < 2)
            {
                return;
            }

            String shortName = filename.Substring(filename.LastIndexOf('\\') + 1);
            changeTitle(shortName);
            button1.Text = shortName;
            addToList("Selected " + shortName);

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
            if (Settings1.Default.howToScroll)
            {
                listBox1.SetSelected(listBox1.Items.Count - 1, true);
            }
            //listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (!port.IsOpen)
            {
                tabControl1.SelectedIndex = 0;
                return;
            }

            if ((sendAsByteRadioButton.Checked || sendAsStringRadioButton.Checked) == false)
            {
                addToList("Select file send mode!");
                return;
            }

            if (fileDumpThread.IsBusy)
            {
                fileDumpThread.CancelAsync();
                stopwatch.Stop();
                //button2.Text = "Send";
                //buttonTextyColorChange(button2);
            }
            else
            {
                groupBox2.Enabled = false;
                button1.Enabled = false;
                groupBox8.Enabled = false;
                textBox1.Enabled = false;
                int delay = 0;
                if (IsItAPositiveNumber(textBox1.Text, out delay))
                {
                    fileDumpThread.RunWorkerAsync(delay);

                }
                else
                {
                    fileDumpThread.RunWorkerAsync();
                }
                buttonTextyColorChange(button2);
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
                progressBar2.Value = 0;
                manualSendThread.RunWorkerAsync(sendThis);
                groupBox1.Enabled = false;
                groupBox3.Enabled = false;
                SpaceStripCheckBox.Enabled = false;
                manualSendCommandBox.Enabled = false;
                manualSendRepeatBox.Enabled = false;
                //button3.Text = "Cancel";
                //button3.BackColor = Color.Red;
                buttonTextyColorChange(button3);
            }
            else
            {
                manualSendThread.CancelAsync();
                //button3.Text = "Send";
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
            if(manualSendThread.IsBusy || fileDumpThread.IsBusy || receiveThread.IsBusy || autoUpdateThread.IsBusy)
            {
                showError("Port is busy");
                return;
            }
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
                //baudRateComboBox.SelectedItem.ToString()
                if (IsItAPositiveNumber(baudRateComboBox.Text, out baudRate))
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

                try
                {
                    port.Open();
                }
                catch (IOException)
                {
                    showError("Please select valid port settings");
                    return;
                }

                Settings1.Default.dataBitIndex = dataBitsComboBox.SelectedIndex;
                Settings1.Default.stopBitIndex = stopBitsComboBox.SelectedIndex;
                Settings1.Default.parityIndex = parityComboBox.SelectedIndex;


                System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("en-US");
                String baudRateToCheck = port.BaudRate.ToString(ci);

                if (!Settings1.Default.baudRates.Contains(baudRateToCheck))
                {
                    Settings1.Default.baudRates.Add(baudRateToCheck);
                    Settings1.Default.lastBaudRateIndex = baudRateComboBox.Items.Count;
                    Settings1.Default.Save();
                }
                else
                {
                    Settings1.Default.lastBaudRateIndex = baudRateComboBox.SelectedIndex;
                    Settings1.Default.Save();
                }

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
            foreach (String rate in Settings1.Default.baudRates)
            {
                baudRateComboBox.Items.Add(rate);
            }

            loadPortsIntoCombobox();
            baudRateComboBox.SelectedIndex = Settings1.Default.lastBaudRateIndex;
            stopBitsComboBox.SelectedIndex = Settings1.Default.stopBitIndex;
            dataBitsComboBox.SelectedIndex = Settings1.Default.dataBitIndex;
            parityComboBox.SelectedIndex = Settings1.Default.parityIndex;

            checkBox1.Checked = Settings1.Default.howToScroll;
            checkBox2.Checked = Settings1.Default.autoUpdate;

            if (Settings1.Default.autoUpdate && !autoUpdateThread.IsBusy)
            {
                autoUpdateThread.RunWorkerAsync();
            }
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

            Invoke((MethodInvoker)(() =>
            {
                progressBar2.Maximum = manualRepeat;
            }));
            int progress = 0;
            for (int i = 0; i < manualRepeat; i++)
            {
                if (manualSendThread.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                addToListSecure(e.Argument.ToString());
                dropStringOnLine(e.Argument.ToString());
                manualSendThread.ReportProgress(progress++);
            }
        }

        private void fileDumpThread_DoWork(object sender, DoWorkEventArgs e)
        {
            int progress = 0;
            int delay = 0;
            if (e.Argument != null)
            {
                delay = (int)e.Argument;
            }
            if (sendAsStringRadioButton.Checked == true)
            {
                stopwatch.Reset();
                stopwatch.Start();
                foreach (String sendThis in linesRead)
                {
                    if (fileDumpThread.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }
                    while (true)
                    {
                        if (fileDumpThread.CancellationPending == true)
                        {
                            e.Cancel = true;
                            break;
                        }
                        if (stopwatch.ElapsedMilliseconds == delay)
                        {
                            port.Write(sendThis);
                            addToListSecure("Sent : " + sendThis);
                            fileDumpThread.ReportProgress(progress++);
                            stopwatch.Reset();
                            stopwatch.Start();
                            break;
                        }
                    }
                }
            }
            else if (sendAsByteRadioButton.Checked == true)
            {
                stopwatch.Reset();
                stopwatch.Start();
                foreach (byte[] sendThis in byteLines)
                {
                    if (fileDumpThread.CancellationPending == true)
                    {
                        e.Cancel = true;
                        return;
                    }
                    while (true)
                    {
                        if (fileDumpThread.CancellationPending == true)
                        {
                            e.Cancel = true;
                            break;
                        }
                        if (stopwatch.ElapsedMilliseconds == delay)
                        {
                            //port.Write(sendThis);
                            port.Write(sendThis, 0, sendThis.Length);
                            addToListSecure("Sent : " + ++progress);
                            fileDumpThread.ReportProgress(progress);
                            stopwatch.Reset();
                            stopwatch.Start();
                            break;
                        }
                    }
                }
            }
            else
            {
                addToListSecure("Select file send mode!");
            }
        }

        private void fileDumpThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            progressBar1.PerformStep();
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

        private void manualSendThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
            progressBar2.PerformStep();
        }

        private void manualSendThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox3.Enabled = true;
            SpaceStripCheckBox.Enabled = true;
            manualSendCommandBox.Enabled = true;
            manualSendRepeatBox.Enabled = true;
            //button3.Text = "Send";
            buttonTextyColorChange(button3);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void fileDumpThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            groupBox2.Enabled = true;
            button1.Enabled = true;
            groupBox8.Enabled = true;
            textBox1.Enabled = true;
            //button2.Text = "Send";
            buttonTextyColorChange(button2);
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Delay")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                textBox1.Text = "Delay";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (receiveThread.IsBusy)
            {
                receiveThread.CancelAsync();
            }
            else
            {
                receiveThread.RunWorkerAsync();
            }
        }

        private void receiveThread_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (receiveThread.CancellationPending == true)
                {
                    e.Cancel = true;
                    return;
                }
                String read = port.ReadLine();
                if (!String.IsNullOrEmpty(read))
                {
                    addToListSecure(read);
                }
            }
        }

        private void buttonTextyColorChange(Button button)
        {
            if (button.Text == "Send")
            {
                button.Text = "Cancel";
                button.BackColor = cancelButtonColor;
                button.ForeColor = cancelButtonTextColor;
            }
            else
            {
                button.Text = "Send";
                button.BackColor = sendButtonColor;
                button.ForeColor = sendButtonTextColor;
            }
        }

        private void colorizeButtons()
        {
            button2.BackColor = sendButtonColor;
            button2.ForeColor = sendButtonTextColor;
            button3.BackColor = sendButtonColor;
            button3.ForeColor = sendButtonTextColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //if(updateDialog.DialogResult
            try
            {
                updateDialog.ShowDialog();
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("You have the latest version installed!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You have the latest version installed!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
            }
            
            
        }

        private void refreshColors()
        {
            linkLabel1.LinkColor = Settings1.Default.clearLinkForecolor;
            linkLabel1.BackColor = Settings1.Default.terminalBackcolor;
            listBox1.ForeColor = Settings1.Default.terminalForecolor;
            listBox1.BackColor = Settings1.Default.terminalBackcolor;
            listBox1.Font = Settings1.Default.terminalFont;
            sendButtonColor = Settings1.Default.sendButtonColor;
            sendButtonTextColor = Settings1.Default.sendButtonTextColor;
            cancelButtonColor = Settings1.Default.cancelButtonColor;
            cancelButtonTextColor = Settings1.Default.cancelButtonTextColor;

            checkBox1.Checked = Settings1.Default.howToScroll;
            checkBox2.Checked = Settings1.Default.autoUpdate;
            colorizeButtons();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (IsTerminalBusy())
            {
                showError("You cannot change settings while sending data");
                return;
            }
            else
            {
                ColorForm cf = new ColorForm();
                cf.ShowDialog();
                refreshColors();
            }
        }


        private bool IsTerminalBusy()
        {
            if (manualSendThread.IsBusy || fileDumpThread.IsBusy || receiveThread.IsBusy)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (IsTerminalBusy())
            {
                showError("You cannot reset settings while using terminal!");
            }else{
                DialogResult reply = MessageBox.Show("Are you sure?", "Reset Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
                if (reply == DialogResult.Yes)
                {
                    Settings1.Default.baudRates.Clear();
                    Settings1.Default.baudRates.Add("115200");
                    Settings1.Default.baudRates.Add("57600");
                    Settings1.Default.baudRates.Add("38400");
                    Settings1.Default.baudRates.Add("19200");
                    Settings1.Default.baudRates.Add("9600");
                    Settings1.Default.baudRates.Add("1200");
                    Settings1.Default.baudRates.Add("300");
                    Settings1.Default.baudRates.Add("921600");
                    Settings1.Default.baudRates.Add("460800");
                    Settings1.Default.baudRates.Add("230400");
                    Settings1.Default.baudRates.Add("4800");
                    Settings1.Default.baudRates.Add("2400");
                    Settings1.Default.baudRates.Add("150");
                    Settings1.Default.baudRates.Add("110");

                    Settings1.Default.lastBaudRateIndex = 0;

                    Settings1.Default.cancelButtonColor = Color.Red;
                    Settings1.Default.cancelButtonTextColor = Color.White;
                    Settings1.Default.clearLinkForecolor = Color.White;
                    Settings1.Default.sendButtonColor = Color.Green;
                    Settings1.Default.sendButtonTextColor = Color.White;

                    Settings1.Default.terminalBackcolor = Color.Black;
                    Settings1.Default.terminalForecolor = Color.Lime;

                    Settings1.Default.autoUpdate = false;
                    Settings1.Default.howToScroll = false;

                    Settings1.Default.terminalFont = new Font(FontFamily.GenericMonospace, (float)8.0);

                    Settings1.Default.Save();

                    refreshColors();
                }
                else
                {
                    return;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                showError("BEWARE: Instantaneous scrolling slows down sending data");
            }
            Settings1.Default.howToScroll = checkBox1.Checked;
            Settings1.Default.Save();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Settings1.Default.autoUpdate = checkBox2.Checked;
            Settings1.Default.Save();
        }

        private void autoUpdateThread_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Net.WebClient client = new System.Net.WebClient();

            try
            {
                updateFile = client.DownloadString("http://theaob.github.com/Data2Serial2/update");
                updateFile = updateFile.Substring(0, updateFile.IndexOf("\n", StringComparison.CurrentCulture));

                System.Version onlineVersion = new Version(updateFile);
                System.Version thisVersion = new Version(version);
                //System.Reflection.AssemblyVersionAttribute thisVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

                if (onlineVersion > thisVersion)
                {
                    DialogResult reply = MessageBox.Show("Do you want to update now?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);

                    if (reply == DialogResult.Yes)
                    {
                        //button5_Click(sender, e);
                        updateDialog.ShowDialog();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (System.Net.WebException)
            {
            }
            catch (System.NotSupportedException)
            {
            }
        }
    }
}
