using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaceInscription
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //régler le masque de saisie  
            telephoneTextBox.Mask = "00 00 00 00 00";
            //beep à la saisie d'un caractère non autorisé
            telephoneTextBox.BeepOnError = true;
            //Limiter la sélection à une seule date
            monthCalendar.MaxSelectionCount = 1;
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            String nomComplet = nomPrenomTextBox.Text;
            DateTime date = monthCalendar.SelectionRange.Start;
            String adresse = adresseRichTextBox.Text;
            String telephone = telephoneTextBox.Text;
            DateTime now = DateTime.Today;

            if(nomComplet.Length!=0 && date<=now && adresse.Length!=0)
            {
                DialogResult result = MessageBox.Show("voulez vous ajouter cette personne", "Ajout", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    personneListBox.Items.Add("Nom et prenom: " + nomComplet);
                    personneListBox.Items.Add("Date inscription: " + date.ToString("dd/MM/yyyy"));
                    personneListBox.Items.Add("--------------------------");
                    MessageBox.Show("personne ajoutee");
                }
                else
                {
                    MessageBox.Show("personne no ajoutee");
                }
            }
            else if(telephoneTextBox.MaskFull == false)
            {
                MessageBox.Show("Téléphone invalide", "invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void annulerButton_Click(object sender, EventArgs e)
        {
            nomPrenomTextBox.Text = "";
            monthCalendar.SetDate(DateTime.Now.Date);       
            adresseRichTextBox.Text = "";
            telephoneTextBox.Text = "";
        }

        private void viderButton_Click(object sender, EventArgs e)
        {
            if (personneListBox.Items.Count != 0)
            {
                DialogResult result = MessageBox.Show("voulez vous vraiment vider la liste", "Suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    personneListBox.Items.Clear();
                }
            }
        }
    }
}
