using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace athentificationDelai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar=true;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void connexionButton_Click(object sender, EventArgs e)
        {
            String login = loginTextBox.Text;
            String password = passwordTextBox.Text;

            if(login.Equals("login") && password.Equals("password"))
            {
                timer1.Stop();
                MessageBox.Show("Bienvenu", "Accès autorisé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect", "Accès non autorisé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int chrono = Convert.ToInt32(chronoLabel.Text);
            chrono++;
            chronoLabel.Text = chrono + "";
            if (chrono == 30)
            {
                timer1.Stop();
                MessageBox.Show("Temps depasse", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
            
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            loginTextBox.Text = "";
            passwordTextBox.Text = "";
            loginTextBox.Select();
        }
    }
}
