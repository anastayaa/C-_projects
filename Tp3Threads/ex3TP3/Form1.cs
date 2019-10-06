using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3TP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool estPremier(int nb)
        {
            for(int i=2; i<nb; i++)
            {
                if (nb % i == 0)
                    return false;
            }
            return true;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            nombrePremierListBox.Items.Clear();
            try
            {
                int nombre = int.Parse(nombreTextBox.Text);
                for (int i = 1; i <= nombre; i++)
                {
                    if (estPremier(i))
                        nombrePremierListBox.Items.Add(i);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            nombreTextBox.Select();
        }

        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
