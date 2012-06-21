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
            System.Windows.Forms.TabPage tabPage1;
            System.Windows.Forms.TabPage tabPage5;
            System.Windows.Forms.TabPage tabPage4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SpaceStripCheckBox = new System.Windows.Forms.CheckBox();
            this.manualSendRepeatBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LFCheckBox = new System.Windows.Forms.CheckBox();
            this.CRCheckBox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.manualSendCommandBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabPage5 = new System.Windows.Forms.TabPage();
            tabPage4 = new System.Windows.Forms.TabPage();
            tabPage1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(this.splitContainer2);
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new System.Drawing.Size(345, 137);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Send";
            tabPage1.UseVisualStyleBackColor = true;
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
            this.splitContainer2.Size = new System.Drawing.Size(345, 137);
            this.splitContainer2.SplitterDistance = 171;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dump File to Port";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
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
            this.groupBox2.Controls.Add(this.SpaceStripCheckBox);
            this.groupBox2.Controls.Add(this.manualSendRepeatBox);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.manualSendCommandBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 137);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send Manually";
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
            this.manualSendRepeatBox.Location = new System.Drawing.Point(6, 110);
            this.manualSendRepeatBox.Name = "manualSendRepeatBox";
            this.manualSendRepeatBox.Size = new System.Drawing.Size(80, 20);
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
            this.groupBox3.Location = new System.Drawing.Point(6, 47);
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
            this.button3.Location = new System.Drawing.Point(92, 108);
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
            this.manualSendCommandBox.Size = new System.Drawing.Size(161, 20);
            this.manualSendCommandBox.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Location = new System.Drawing.Point(4, 22);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new System.Drawing.Size(345, 137);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Settings";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new System.Drawing.Point(4, 22);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new System.Drawing.Size(345, 137);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "COM Port";
            tabPage4.UseVisualStyleBackColor = true;
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
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(353, 399);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 0;
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
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(353, 232);
            this.listBox1.TabIndex = 0;
            this.listBox1.UseTabStops = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tabPage4);
            this.tabControl1.Controls.Add(tabPage1);
            this.tabControl1.Controls.Add(tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(353, 163);
            this.tabControl1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text File (.txt)|*.txt|Log File (.log)|*.log|Other|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 399);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Data2Serial2";
            tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
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


    }
}

