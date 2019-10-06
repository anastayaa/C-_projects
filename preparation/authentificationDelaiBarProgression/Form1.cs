using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace authentificationDelaiBarProgression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
            authProgressBar.Value = 0;
            authProgressBar.Minimum = 0;
            authProgressBar.Maximum = 30;
            authProgressBar.Step = 1;
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
                MessageBox.Show("Bienvenue", "Accès autorisé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect", "Accès non autorisé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //authProgressBar.Value += 1;
            authProgressBar.PerformStep(); //Faire progresser la barre d'un pas (1 step)

            if (authProgressBar.Value == authProgressBar.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Temps épuisé", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }

    }
}
