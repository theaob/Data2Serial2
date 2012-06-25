namespace Data2Serial2
{
    partial class ColorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backColorButton = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clearLinkColorBox = new System.Windows.Forms.PictureBox();
            this.terminalForeColorBox = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.sendButtonForecolorBox = new System.Windows.Forms.PictureBox();
            this.sendButtonBackColorBox = new System.Windows.Forms.PictureBox();
            this.cancelButtonBackcolorBox = new System.Windows.Forms.PictureBox();
            this.cancelButtonForecolorBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backColorButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearLinkColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminalForeColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendButtonForecolorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendButtonBackColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonBackcolorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonForecolorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.terminalForeColorBox);
            this.groupBox1.Controls.Add(this.clearLinkColorBox);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.backColorButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terminal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancelButtonBackcolorBox);
            this.groupBox2.Controls.Add(this.cancelButtonForecolorBox);
            this.groupBox2.Controls.Add(this.sendButtonBackColorBox);
            this.groupBox2.Controls.Add(this.sendButtonForecolorBox);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buttons";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send Button:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Back Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fore Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Clear Link Color:";
            // 
            // backColorButton
            // 
            this.backColorButton.Location = new System.Drawing.Point(96, 16);
            this.backColorButton.Name = "backColorButton";
            this.backColorButton.Size = new System.Drawing.Size(77, 13);
            this.backColorButton.TabIndex = 3;
            this.backColorButton.TabStop = false;
            this.backColorButton.Click += new System.EventHandler(this.backColorButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "This is your",
            "new color",
            "scheme",
            "for",
            "terminal"});
            this.listBox1.Location = new System.Drawing.Point(179, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(75, 91);
            this.listBox1.TabIndex = 4;
            // 
            // clearLinkColorBox
            // 
            this.clearLinkColorBox.Location = new System.Drawing.Point(96, 63);
            this.clearLinkColorBox.Name = "clearLinkColorBox";
            this.clearLinkColorBox.Size = new System.Drawing.Size(77, 13);
            this.clearLinkColorBox.TabIndex = 5;
            this.clearLinkColorBox.TabStop = false;
            this.clearLinkColorBox.Click += new System.EventHandler(this.clearLinkColorBox_Click);
            // 
            // terminalForeColorBox
            // 
            this.terminalForeColorBox.Location = new System.Drawing.Point(96, 39);
            this.terminalForeColorBox.Name = "terminalForeColorBox";
            this.terminalForeColorBox.Size = new System.Drawing.Size(77, 13);
            this.terminalForeColorBox.TabIndex = 6;
            this.terminalForeColorBox.TabStop = false;
            this.terminalForeColorBox.Click += new System.EventHandler(this.terminalForeColorBox_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(223, 94);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(31, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clear";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cancel Button:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(179, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // sendButtonForecolorBox
            // 
            this.sendButtonForecolorBox.Location = new System.Drawing.Point(96, 16);
            this.sendButtonForecolorBox.Name = "sendButtonForecolorBox";
            this.sendButtonForecolorBox.Size = new System.Drawing.Size(36, 13);
            this.sendButtonForecolorBox.TabIndex = 8;
            this.sendButtonForecolorBox.TabStop = false;
            this.sendButtonForecolorBox.Click += new System.EventHandler(this.sendButtonForecolorBox_Click);
            // 
            // sendButtonBackColorBox
            // 
            this.sendButtonBackColorBox.Location = new System.Drawing.Point(138, 16);
            this.sendButtonBackColorBox.Name = "sendButtonBackColorBox";
            this.sendButtonBackColorBox.Size = new System.Drawing.Size(35, 13);
            this.sendButtonBackColorBox.TabIndex = 9;
            this.sendButtonBackColorBox.TabStop = false;
            this.sendButtonBackColorBox.Click += new System.EventHandler(this.sendButtonBackColorBox_Click);
            // 
            // cancelButtonBackcolorBox
            // 
            this.cancelButtonBackcolorBox.Location = new System.Drawing.Point(138, 45);
            this.cancelButtonBackcolorBox.Name = "cancelButtonBackcolorBox";
            this.cancelButtonBackcolorBox.Size = new System.Drawing.Size(35, 13);
            this.cancelButtonBackcolorBox.TabIndex = 11;
            this.cancelButtonBackcolorBox.TabStop = false;
            this.cancelButtonBackcolorBox.Click += new System.EventHandler(this.cancelButtonBackcolorBox_Click);
            // 
            // cancelButtonForecolorBox
            // 
            this.cancelButtonForecolorBox.Location = new System.Drawing.Point(96, 45);
            this.cancelButtonForecolorBox.Name = "cancelButtonForecolorBox";
            this.cancelButtonForecolorBox.Size = new System.Drawing.Size(36, 13);
            this.cancelButtonForecolorBox.TabIndex = 10;
            this.cancelButtonForecolorBox.TabStop = false;
            this.cancelButtonForecolorBox.Click += new System.EventHandler(this.cancelButtonForecolorBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Font:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(96, 82);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Select";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Colors";
            this.Load += new System.EventHandler(this.ColorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backColorButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clearLinkColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminalForeColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendButtonForecolorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendButtonBackColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonBackcolorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelButtonForecolorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox backColorButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox terminalForeColorBox;
        private System.Windows.Forms.PictureBox clearLinkColorBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox cancelButtonBackcolorBox;
        private System.Windows.Forms.PictureBox cancelButtonForecolorBox;
        private System.Windows.Forms.PictureBox sendButtonBackColorBox;
        private System.Windows.Forms.PictureBox sendButtonForecolorBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button5;
    }
}