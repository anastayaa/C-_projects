using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;

namespace Tp8RemotingEx2Client
{
    public partial class Form1 : Form
    {
        Tp8RemotingEx2Jeu.Class1 jeu;

        public Form1()
        {
            //RemotingConfiguration.RegisterWellKnownClientType(typeof(Tp8RemotingEx2Jeu.Class1), "tcp://localhost:8085/jeu");
            RemotingConfiguration.RegisterActivatedClientType(typeof(Tp8RemotingEx2Jeu.Class1), "tcp://localhost:8085");
            jeu = new Tp8RemotingEx2Jeu.Class1();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DevinerButton_Click(object sender, EventArgs e)
        {
            int nombre = Convert.ToInt32(nombreTextBox.Text);
            String resultat = jeu.Jouer(nombre);
            resultatTextBox.Text = resultat;

            int nbTentatives = jeu.getNbTentatives();
            nbTentativesTextBox.Text = nbTentatives + "";
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            int score = jeu.score();
            scoreLabel.Text = score + "";
        }
    }
}
