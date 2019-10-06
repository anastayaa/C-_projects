using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp9DataBaseLinqToSQL
{
    public partial class Form2 : Form
    {
        DataClasses1DataContext dc;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs ev)
        {
            dc = new DataClasses1DataContext();
            var etudiants = from e in dc.etudiant select e;
            foreach (var etudiant in etudiants)
            {
                cneComboBox.Items.Add(etudiant.cne);
            }
        }

        private void chercherButton_Click(object sender, EventArgs ev)
        {
            if (cneComboBox.SelectedItem != null)
            {
                int cne = Convert.ToInt32(cneComboBox.SelectedItem.ToString());
                var etudiant = (from e in dc.etudiant where e.cne == cne select e).SingleOrDefault();
                nomTextBox.Text = etudiant.nom.ToString();
                prenomTetBox.Text = etudiant.prenom.ToString();
                filiereTextBox.Text = etudiant.Filiere.Nom_filiere.ToString();
            }
            else
            {
                MessageBox.Show("Selectionner un cne");
            }
        }
    }
}
