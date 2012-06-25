namespace Data2Serial2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabPage sendTab;
            System.Windows.Forms.TabPage settingsTab;
            System.Windows.Forms.TabPage comPortTab;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.sendAsByteRadioButton = new System.Windows.Forms.RadioButton();
            this.sendAsStringRadioButton = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.SpaceStripCheckBox = new System.Windows.Forms.CheckBox();
            this.manualSendRepeatBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LFCheckBox = new System.Windows.Forms.CheckBox();
            this.CRCheckBox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.manualSendCommandBox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.openPortButton = new System.Windows.Forms.Button();
            this.scanPortButton = new System.Windows.Forms.Button();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.manualSendThread = new System.ComponentModel.BackgroundWorker();
            this.fileDumpThread = new System.ComponentModel.BackgroundWorker();
            this.receiveThread = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button6 = new System.Windows.Forms.Button();
            sendTab = new System.Windows.Forms.TabPage();
            settingsTab = new System.Windows.Forms.TabPage();
            comPortTab = new System.Windows.Forms.TabPage();
            sendTab.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            settingsTab.SuspendLayout();
            comPortTab.SuspendLayout();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendTab
            // 
            sendTab.Controls.Add(this.splitContainer2);
            sendTab.Location = new System.Drawing.Point(4, 22);
            sendTab.Name = "sendTab";
            sendTab.Size = new System.Drawing.Size(345, 128);
            sendTab.TabIndex = 3;
            sendTab.Text = "Send";
            sendTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(345, 128);
            this.splitContainer2.SplitterDistance = 171;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dump File to Port";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(113, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Delay";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(3, 89);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(165, 13);
            this.progressBar1.TabIndex = 6;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.sendAsByteRadioButton);
            this.groupBox8.Controls.Add(this.sendAsStringRadioButton);
            this.groupBox8.Location = new System.Drawing.Point(6, 48);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(101, 40);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Send As";
            // 
            // sendAsByteRadioButton
            // 
            this.sendAsByteRadioButton.AutoSize = true;
            this.sendAsByteRadioButton.Location = new System.Drawing.Point(55, 18);
            this.sendAsByteRadioButton.Name = "sendAsByteRadioButton";
            this.sendAsByteRadioButton.Size = new System.Drawing.Size(46, 17);
            this.sendAsByteRadioButton.TabIndex = 2;
            this.sendAsByteRadioButton.TabStop = true;
            this.sendAsByteRadioButton.Text = "Byte";
            this.sendAsByteRadioButton.UseVisualStyleBackColor = true;
            // 
            // sendAsStringRadioButton
            // 
            this.sendAsStringRadioButton.AutoSize = true;
            this.sendAsStringRadioButton.Location = new System.Drawing.Point(6, 18);
            this.sendAsStringRadioButton.Name = "sendAsStringRadioButton";
            this.sendAsStringRadioButton.Size = new System.Drawing.Size(52, 17);
            this.sendAsStringRadioButton.TabIndex = 4;
            this.sendAsStringRadioButton.TabStop = true;
            this.sendAsStringRadioButton.Text = "String";
            this.sendAsStringRadioButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(3, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(116, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.SpaceStripCheckBox);
            this.groupBox2.Controls.Add(this.manualSendRepeatBox);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.manualSendCommandBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 128);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send Manually";
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(64, 56);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.TabIndex = 6;
            // 
            // SpaceStripCheckBox
            // 
            this.SpaceStripCheckBox.AutoSize = true;
            this.SpaceStripCheckBox.Location = new System.Drawing.Point(63, 85);
            this.SpaceStripCheckBox.Name = "SpaceStripCheckBox";
            this.SpaceStripCheckBox.Size = new System.Drawing.Size(86, 17);
            this.SpaceStripCheckBox.TabIndex = 5;
            this.SpaceStripCheckBox.Text = "Strip Spaces";
            this.SpaceStripCheckBox.UseVisualStyleBackColor = true;
            // 
            // manualSendRepeatBox
            // 
            this.manualSendRepeatBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.manualSendRepeatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manualSendRepeatBox.Location = new System.Drawing.Point(6, 105);
            this.manualSendRepeatBox.Name = "manualSendRepeatBox";
            this.manualSendRepeatBox.Size = new System.Drawing.Size(77, 20);
            this.manualSendRepeatBox.TabIndex = 4;
            this.manualSendRepeatBox.Text = "Repeats (0)";
            this.manualSendRepeatBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.manualSendRepeatBox.Leave += new System.EventHandler(this.manualSendRepeatBox_Leave);
            this.manualSendRepeatBox.Enter += new System.EventHandler(this.manualSendRepeatBox_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.LFCheckBox);
            this.groupBox3.Controls.Add(this.CRCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(51, 61);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EOL";
            // 
            // LFCheckBox
            // 
            this.LFCheckBox.AutoSize = true;
            this.LFCheckBox.Location = new System.Drawing.Point(6, 38);
            this.LFCheckBox.Name = "LFCheckBox";
            this.LFCheckBox.Size = new System.Drawing.Size(38, 17);
            this.LFCheckBox.TabIndex = 1;
            this.LFCheckBox.Text = "LF";
            this.LFCheckBox.UseVisualStyleBackColor = true;
            // 
            // CRCheckBox
            // 
            this.CRCheckBox.AutoSize = true;
            this.CRCheckBox.Location = new System.Drawing.Point(6, 19);
            this.CRCheckBox.Name = "CRCheckBox";
            this.CRCheckBox.Size = new System.Drawing.Size(41, 17);
            this.CRCheckBox.TabIndex = 0;
            this.CRCheckBox.Text = "CR";
            this.CRCheckBox.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(89, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // manualSendCommandBox
            // 
            this.manualSendCommandBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.manualSendCommandBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manualSendCommandBox.Location = new System.Drawing.Point(6, 21);
            this.manualSendCommandBox.Name = "manualSendCommandBox";
            this.manualSendCommandBox.Size = new System.Drawing.Size(158, 20);
            this.manualSendCommandBox.TabIndex = 0;
            // 
            // settingsTab
            // 
            settingsTab.Controls.Add(this.button6);
            settingsTab.Controls.Add(this.button5);
            settingsTab.Location = new System.Drawing.Point(4, 22);
            settingsTab.Name = "settingsTab";
            settingsTab.Size = new System.Drawing.Size(345, 128);
            settingsTab.TabIndex = 2;
            settingsTab.Text = "Settings";
            settingsTab.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(229, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Check For Updates";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comPortTab
            // 
            comPortTab.Controls.Add(this.splitContainer3);
            comPortTab.Location = new System.Drawing.Point(4, 22);
            comPortTab.Name = "comPortTab";
            comPortTab.Size = new System.Drawing.Size(345, 128);
            comPortTab.TabIndex = 1;
            comPortTab.Text = "COM Port";
            comPortTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox7);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer3.Size = new System.Drawing.Size(345, 128);
            this.splitContainer3.SplitterDistance = 70;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.openPortButton);
            this.groupBox4.Controls.Add(this.scanPortButton);
            this.groupBox4.Controls.Add(this.portComboBox);
            this.groupBox4.Controls.Add(this.baudRateComboBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 70);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // openPortButton
            // 
            this.openPortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openPortButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.openPortButton.Location = new System.Drawing.Point(262, 41);
            this.openPortButton.Name = "openPortButton";
            this.openPortButton.Size = new System.Drawing.Size(75, 23);
            this.openPortButton.TabIndex = 5;
            this.openPortButton.Text = "Open Port";
            this.openPortButton.UseVisualStyleBackColor = true;
            this.openPortButton.Click += new System.EventHandler(this.openPortButton_Click);
            // 
            // scanPortButton
            // 
            this.scanPortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scanPortButton.Location = new System.Drawing.Point(262, 11);
            this.scanPortButton.Name = "scanPortButton";
            this.scanPortButton.Size = new System.Drawing.Size(75, 23);
            this.scanPortButton.TabIndex = 4;
            this.scanPortButton.Text = "Scan Ports";
            this.scanPortButton.UseVisualStyleBackColor = true;
            this.scanPortButton.Click += new System.EventHandler(this.scanPortButton_Click);
            // 
            // portComboBox
            // 
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(75, 43);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 21);
            this.portComboBox.TabIndex = 3;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(75, 13);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.baudRateComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baud Rate:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.stopBitsComboBox);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox7.Location = new System.Drawing.Point(242, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(104, 54);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Stop Bits";
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Items.AddRange(new object[] {
            "None",
            "1 bit",
            "1.5 bits",
            "2 bits"});
            this.stopBitsComboBox.Location = new System.Drawing.Point(6, 19);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(92, 21);
            this.stopBitsComboBox.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataBitsComboBox);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Location = new System.Drawing.Point(132, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(110, 54);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data Bits";
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Items.AddRange(new object[] {
            "8 bits",
            "7 bits",
            "6 bits",
            "5 bits"});
            this.dataBitsComboBox.Location = new System.Drawing.Point(6, 19);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(98, 21);
            this.dataBitsComboBox.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.parityComboBox);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(132, 54);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parity";
            // 
            // parityComboBox
            // 
            this.parityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.parityComboBox.Location = new System.Drawing.Point(5, 19);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(121, 21);
            this.parityComboBox.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(353, 406);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Black;
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(301, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(31, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clear";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 248);
            this.listBox1.TabIndex = 0;
            this.listBox1.UseTabStops = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(comPortTab);
            this.tabControl1.Controls.Add(sendTab);
            this.tabControl1.Controls.Add(settingsTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 154);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(345, 128);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Receive";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button4);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(0, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(345, 128);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Options";
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.Location = new System.Drawing.Point(3, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(339, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Start Listening";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text File (.txt)|*.txt|Log File (.log)|*.log|Other|*.*";
            // 
            // manualSendThread
            // 
            this.manualSendThread.WorkerReportsProgress = true;
            this.manualSendThread.WorkerSupportsCancellation = true;
            this.manualSendThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.manualSendThread_DoWork);
            this.manualSendThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.manualSendThread_RunWorkerCompleted);
            this.manualSendThread.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.manualSendThread_ProgressChanged);
            // 
            // fileDumpThread
            // 
            this.fileDumpThread.WorkerReportsProgress = true;
            this.fileDumpThread.WorkerSupportsCancellation = true;
            this.fileDumpThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.fileDumpThread_DoWork);
            this.fileDumpThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.fileDumpThread_RunWorkerCompleted);
            this.fileDumpThread.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.fileDumpThread_ProgressChanged);
            // 
            // receiveThread
            // 
            this.receiveThread.WorkerSupportsCancellation = true;
            this.receiveThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.receiveThread_DoWork);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Colors";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 406);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data2Serial2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            sendTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            settingsTab.ResumeLayout(false);
            comPortTab.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox manualSendCommandBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox LFCheckBox;
        private System.Windows.Forms.CheckBox CRCheckBox;
        private System.Windows.Forms.TextBox manualSendRepeatBox;
        private System.Windows.Forms.CheckBox SpaceStripCheckBox;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Button openPortButton;
        private System.Windows.Forms.Button scanPortButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.ComponentModel.BackgroundWorker manualSendThread;
        private System.ComponentModel.BackgroundWorker fileDumpThread;
        private System.ComponentModel.BackgroundWorker receiveThread;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton sendAsByteRadioButton;
        private System.Windows.Forms.RadioButton sendAsStringRadioButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button6;


    }
}

