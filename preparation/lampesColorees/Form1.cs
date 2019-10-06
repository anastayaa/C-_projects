using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lampesColorees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frequenceTrackBar.Minimum = 0;
            frequenceTrackBar.Maximum = 10;
            frequenceTrackBar.TickFrequency = 1;
            frequenceTrackBar.Enabled = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (frequenceTrackBar.Value != frequenceTrackBar.Minimum)
            {
                timer1.Start();
            }
            stopButton.Enabled = true;
            playButton.Enabled = false;
            frequenceTrackBar.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (RRadioButton.Checked)
            {
                this.BackColor = Color.Red;
                VRadioButton.Checked = true;
                RRadioButton.Checked = false;
            }
            else if (VRadioButton.Checked)
            {
                this.BackColor = Color.Green;
                BRadioButton.Checked = true;
                VRadioButton.Checked = false;
            }
            else if (BRadioButton.Checked)
            {
                this.BackColor = Color.Blue;
                RRadioButton.Checked = true;
                BRadioButton.Checked = false;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            playButton.Enabled = true;
            frequenceTrackBar.Enabled = false;
            timer1.Stop();
            this.BackColor = DefaultBackColor;
        }

        private void frequenceTrackBar_Scroll(object sender, EventArgs e)
        {
            timer1.Stop();
            if (frequenceTrackBar.Value != frequenceTrackBar.Minimum)
            {
                timer1.Interval = frequenceTrackBar.Value * 100;
                timer1.Start();
            }
        }

    }
}
