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
    public partial class Form1 : Form
    {
        DataClasses1DataContext ct;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ct = new DataClasses1DataContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!filiereTextBox.Text.Equals("")){
                Filiere filiere = new Filiere();
                filiere.Nom_filiere = filiereTextBox.Text;
                ct.Filiere.InsertOnSubmit(filiere);
                ct.SubmitChanges();
                MessageBox.Show("Filiere ajoutee");
            }
            else
            {
                MessageBox.Show("champ vide");
            }
        }
    }
}
