using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex4TP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            nombreTimer.Start();
            nombreTimer.Stop();*/

        }

        private void numberTimer_Tick(object sender, EventArgs e)
        {
            int nombre = int.Parse(nombreLabel.Text);
            nombreLabel.Text = nombre + 1+"";
        }

        private void textLabel_Click(object sender, EventArgs e)
        {

        }

        private void startStopButton_Click(object sender, EventArgs e)
        {
            if(startStopButton.Text == "Start")
            {
                nombreTimer.Enabled=true;
                startStopButton.Text = "Stop";
            }
            else
            {
                nombreTimer.Enabled=false;
                startStopButton.Text = "Start";
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
