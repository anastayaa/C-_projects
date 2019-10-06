using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp8RemotingEx1Object;

namespace Tp8RemotingEx1Client
{
    public partial class Form1 : Form
    {
        private Class1 class1;

        public Form1()
        {
            InitializeComponent();

            /*
             * mode activation singleton ou singlcall
             */
            RemotingConfiguration.RegisterWellKnownClientType(typeof(Tp8RemotingEx1Object.Class1), "tcp://localhost:8085/calculator");
            class1 = new Class1();


            /*
             * mode activation par le client
             */
            //RemotingConfiguration.RegisterActivatedClientType(typeof(Tp8RemotingEx1Object.Class1), "tcp://localhost:8085");
            //class1 = new Tp8RemotingEx1Object.Class1();


            /*
            * A travers un fichier de configuration
            */
            //RemotingConfiguration.Configure(@"..\..\Tp8RemotingEx1Client.config", false);
            //class1 = new Tp8RemotingEx1Object.Class1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            operationComboBox.Items.Add("+");
            operationComboBox.Items.Add("*");
        }

        private void calculButton_Click(object sender, EventArgs e)
        {
            int nombre1 = Convert.ToInt32(nombre1TextBox.Text);
            int nombre2 = Convert.ToInt32(nombre2TextBox.Text);
            String operation = Convert.ToString(operationComboBox.SelectedItem);

            if (operation == "+")
            {
                resultatTextBox.Text=class1.Addition(nombre1, nombre2)+ "";
            }
            else if(operation == "*")
            {
                resultatTextBox.Text = class1.Multiplication(nombre1, nombre2) + "";
            }
        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
            int nbIncrement = Convert.ToInt32(nombreIncrementTextBox.Text);
            nombreIncrementTextBox.Text = class1.Incrementation(nbIncrement) +"";
        }
    }
}
