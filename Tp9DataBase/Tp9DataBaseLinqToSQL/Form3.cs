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
    public partial class Form3 : Form
    {
        CompteDataClassesDataContext ct;
        Compte client1, client2;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ct = new CompteDataClassesDataContext();
        }

        private void soldeButton_Click(object sender, EventArgs e)
        {
            int numClient1 = Convert.ToInt32(client1TextBox.Text);
            int numClient2 = Convert.ToInt32(client2TextBox.Text);

            client1 = (from c1 in ct.Compte where c1.Num == numClient1 select c1).SingleOrDefault();
            client2 = (from c2 in ct.Compte where c2.Num == numClient2 select c2).SingleOrDefault();
            if (client1 == null)
            {
                MessageBox.Show("Le compte du client1 n'existe pas");
            }
            else if (client2 == null)
            {
                MessageBox.Show("Le compte du client2 n'existe pas");
            }
            else
            {
                soldeClient1TextBox.Text = client1.solde+"";
                soldeClient2TextBox.Text = client2.solde+"";
            }
        }

        private void virerButton_Click(object sender, EventArgs e)
        {
            if(client1!=null && client2 != null)
            {
                if (!virementTextBox.Text.Equals("")){
                    int solde = Convert.ToInt32(virementTextBox.Text);
                    if (solde <= client1.solde)
                    {
                        ct.Connection.Open();
                        ct.Transaction = ct.Connection.BeginTransaction();
                        try
                        {
                            client1.solde = client1.solde - solde;
                            client2.solde = client2.solde + solde;
                            ct.SubmitChanges();
                            soldeClient1TextBox.Text = client1.solde + "";
                            soldeClient2TextBox.Text = client2.solde + "";
                            ct.Transaction.Commit();
                        }
                        catch(Exception ex)
                        {
                            ct.Transaction.Rollback();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le solde du client ne suffit pas");
                    }
                }
                else
                {
                    MessageBox.Show("Entrer un solde a virer");
                }
            }
            else
            {
                MessageBox.Show("Les comptes ne sont pas valides");
            }
        }
    }
}
