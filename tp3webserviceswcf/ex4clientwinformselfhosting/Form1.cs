using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace ex4clientwinformselfhosting
{
    public partial class Form1 : Form
    {
        ServiceHost host;

        public Form1()
        {
            InitializeComponent();
        }

        private void demarrer_button_Click(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(ex1servicewcf.BonjourService));
            host.Open();
        }

        private void arreterbutton_Click(object sender, EventArgs e)
        {
            host.Close();
        }
    }
}
