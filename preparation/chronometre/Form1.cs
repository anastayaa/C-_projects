using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chronometre
{
    public partial class Form1 : Form
    {
        int nbTour = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            minuteLabel.Text = "00";
            secondeLabel.Text = "00";
            centiemeSecondeLabel.Text = "00";
            timer1.Interval = 10;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int centiemeSeconde = Convert.ToInt32(centiemeSecondeLabel.Text);
            centiemeSeconde += 1;
            centiemeSecondeLabel.Text = centiemeSeconde + "";
            if (centiemeSeconde == 100)
            {
                int seconde= Convert.ToInt32(secondeLabel.Text);
                seconde += 1;
                centiemeSecondeLabel.Text = "00";
                secondeLabel.Text = seconde + "";
                if (seconde == 60)
                {
                    int minute= Convert.ToInt32(minuteLabel.Text);
                    minute += 1;
                    secondeLabel.Text = "00";
                    minuteLabel.Text = minute + "";
                }
            }
        }

        private void demarrerButton_Click(object sender, EventArgs e)
        {
            /**
             * Demarrer le timer
             * */
            timer1.Start();
        }

        private void arreterButton_Click(object sender, EventArgs e)
        {
            /**
             * Arreter le timer
             * */
            timer1.Stop();
        }

        private void tourButton_Click(object sender, EventArgs e)
        {
            tourListBox.Items.Add("Tour "+(++ nbTour)+":"+minuteLabel.Text+":"+secondeLabel.Text+":"+centiemeSecondeLabel.Text);
        }

        private void effacerButton_Click(object sender, EventArgs e)
        {
            tourListBox.Items.Clear();
        }
    }
}
