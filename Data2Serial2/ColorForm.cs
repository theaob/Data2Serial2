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
    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
        }

        private void ColorForm_Load(object sender, EventArgs e)
        {
            backColorButton.BackColor = Settings1.Default.terminalBackcolor;
            terminalForeColorBox.BackColor = Settings1.Default.terminalForecolor;
            clearLinkColorBox.BackColor = Settings1.Default.clearLinkForecolor;
            sendButtonBackColorBox.BackColor = Settings1.Default.sendButtonColor;
            sendButtonForecolorBox.BackColor = Settings1.Default.sendButtonTextColor;
            cancelButtonForecolorBox.BackColor = Settings1.Default.cancelButtonTextColor;
            cancelButtonBackcolorBox.BackColor = Settings1.Default.cancelButtonColor;

            fontDialog1.Font = Settings1.Default.terminalFont;

            refreshColors();

        }

        private void refreshColors()
        {

            listBox1.BackColor = backColorButton.BackColor;
            listBox1.ForeColor = terminalForeColorBox.BackColor;
            listBox1.Font = fontDialog1.Font;

            linkLabel1.BackColor = backColorButton.BackColor;
            linkLabel1.LinkColor = clearLinkColorBox.BackColor;

            button3.BackColor = sendButtonBackColorBox.BackColor;
            button3.ForeColor = sendButtonForecolorBox.BackColor;

            button4.BackColor = cancelButtonBackcolorBox.BackColor;
            button4.ForeColor = cancelButtonForecolorBox.BackColor;
            //button1.ForeColor = 
                
        }

        private void backColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = backColorButton.BackColor;
            colorDialog1.ShowDialog();
            backColorButton.BackColor = colorDialog1.Color;
            refreshColors();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings1.Default.clearLinkForecolor = clearLinkColorBox.BackColor;
            Settings1.Default.terminalForecolor = terminalForeColorBox.BackColor;
            Settings1.Default.terminalBackcolor = backColorButton.BackColor;
            Settings1.Default.cancelButtonColor = cancelButtonBackcolorBox.BackColor;
            Settings1.Default.cancelButtonTextColor = cancelButtonForecolorBox.BackColor;
            Settings1.Default.sendButtonColor = sendButtonBackColorBox.BackColor;
            Settings1.Default.sendButtonTextColor = sendButtonForecolorBox.BackColor;

            Settings1.Default.Save();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void terminalForeColorBox_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = terminalForeColorBox.BackColor;
            colorDialog1.ShowDialog();
            terminalForeColorBox.BackColor = colorDialog1.Color;
            refreshColors();
        }

        private void clearLinkColorBox_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = clearLinkColorBox.BackColor;
            colorDialog1.ShowDialog();
            clearLinkColorBox.BackColor = colorDialog1.Color;
            refreshColors();
        }

        private void sendButtonForecolorBox_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = sendButtonForecolorBox.BackColor;
            colorDialog1.ShowDialog();
            sendButtonForecolorBox.BackColor = colorDialog1.Color;
            refreshColors();
        }

        private void sendButtonBackColorBox_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = sendButtonBackColorBox.BackColor;
            colorDialog1.ShowDialog();
            sendButtonBackColorBox.BackColor = colorDialog1.Color;
            refreshColors();
        }

        private void cancelButtonForecolorBox_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = cancelButtonForecolorBox.BackColor;
            colorDialog1.ShowDialog();
            cancelButtonForecolorBox.BackColor = colorDialog1.Color;
            refreshColors();
        }

        private void cancelButtonBackcolorBox_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = cancelButtonBackcolorBox.BackColor;
            colorDialog1.ShowDialog();
            cancelButtonBackcolorBox.BackColor = colorDialog1.Color;
            refreshColors();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = Settings1.Default.terminalFont;
            fontDialog1.ShowDialog();
            if (fontDialog1.Font != listBox1.Font)
            {
                listBox1.Font = fontDialog1.Font;
                Settings1.Default.terminalFont = fontDialog1.Font;
            }
        }
    }
}
