using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prixBillet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            typeListBox.Items.Add("Premiere classe");
            typeListBox.Items.Add("Deuxieme classe");
            reductionComboBox.Items.Add("Pas de reduction");
            reductionComboBox.Items.Add("Carte jeune");
            reductionComboBox.Items.Add("Carte adulte");
            reductionComboBox.Items.Add("Carte famille");
            reductionComboBox.SelectedIndex = 0;
            prixHTTextBox.Enabled = false;
            TVATextBox.Enabled = false;
            prixTCCTextBox.Enabled = false;
        }

        private void calculerButton_Click(object sender, EventArgs e)
        {
            double prixBillet;
            if (prixTextBox.Text=="")
            {
                MessageBox.Show("Indiquer le prix de base SVP!", "vide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!double.TryParse(prixTextBox.Text, out prixBillet)){
                MessageBox.Show("Prix de base invalide", "invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (typeListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Indiquer le type de billet SVP!", "type de billet", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double prixHT;

                if (typeListBox.SelectedIndex == 1)
                {
                    // Premiere classe
                    prixHT = prixBillet;
                }
                else
                {
                    // Deuxieme classe
                    prixHT = prixBillet + prixBillet * 0.2;
                }

                if (reductionComboBox.SelectedIndex == 1)
                {
                    // reduction de 20%
                    prixHT -= prixHT * 0.2;
                }
                else if (reductionComboBox.SelectedIndex == 2)
                {
                    // reduction de 40%
                    prixHT -= prixHT * 0.4;
                }
                else if (reductionComboBox.SelectedIndex == 3)
                {
                    // reduction de 50%
                    prixHT -= prixHT * 0.5;
                }
                prixHTTextBox.Text = prixHT + "";
                prixTCCTextBox.Text = (prixHT + prixHT * 0.2).ToString();
                TVATextBox.Text = "20%";
            }
            
        }

        private void reinisialiserButton_Click(object sender, EventArgs e)
        {
            prixTextBox.Text = "";
            reductionComboBox.SelectedIndex = 0;
            typeListBox.ClearSelected();
            prixHTTextBox.Text = "";
            prixTCCTextBox.Text = "";
            TVATextBox.Text = "";
        }

        private void quiterButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
