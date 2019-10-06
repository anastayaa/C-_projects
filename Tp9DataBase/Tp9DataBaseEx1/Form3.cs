using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Tp9DataBaseEx1
{
    public partial class Form3 : Form
    {
        SqlConnection connexion;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            String strConn = "Data Source=localhost; Initial Catalog=gestion_etudiant; " +
                "User Id=java; Password=anas/1997; Integrated Security=true";

            connexion = new SqlConnection();
            connexion.ConnectionString = strConn;

        }

        private void soldeButton_Click(object sender, EventArgs e)
        {
            String client1 = client1TextBox.Text;
            String client2 = client2TextBox.Text;

            connexion.Open();
            String solde1=getSolde(client1);
            soldeClient1TextBox.Text = solde1;
            connexion.Close();

            connexion.Open();
            String solde2 = getSolde(client2);
            soldeClient2TextBox.Text = solde2;
            connexion.Close();
        }

        private String getSolde(String id)
        {
            SqlCommand commande = new SqlCommand();
            commande.Connection = connexion;
            commande.CommandText = "SELECT solde FROM compte where num=@num";
            SqlParameter sqlParameter = new SqlParameter("@num", id);

            commande.Parameters.Add(sqlParameter);
            
            SqlDataReader line = commande.ExecuteReader();

            
            while (line.Read())
            {
                return line[0].ToString();
            }
            return "";
        }

        private void virerButton_Click(object sender, EventArgs e)
        {
            double soldeVirement = Convert.ToDouble(virementTextBox.Text);

            String client1 = client1TextBox.Text;
            connexion.Open();
            double soldeClient1 = Convert.ToDouble(getSolde(client1));
            connexion.Close();

            String client2 = client2TextBox.Text;
            connexion.Open();
            double soldeClient2 = Convert.ToDouble(getSolde(client2));
            connexion.Close();

            if (soldeClient1 >= soldeVirement)
            {
                
                connexion.Open();
                SqlCommand commande = new SqlCommand();
                SqlTransaction transaction = connexion.BeginTransaction();
                commande.Connection = connexion;
                commande.Transaction = transaction;
                try
                {
                    commande.CommandText = "UPDATE compte SET solde=@solde where num=@num";
                    SqlParameter soldeParameter = new SqlParameter("@solde", soldeClient2+soldeVirement);
                    SqlParameter numParameter = new SqlParameter("@num", client2);
                    commande.Parameters.Add(soldeParameter);
                    commande.Parameters.Add(numParameter);
                    commande.ExecuteNonQuery();

                    commande.CommandText = "UPDATE compte SET solde=@solde where num=@num";
                    commande.Parameters.Clear();
                    soldeParameter = new SqlParameter("@solde", soldeClient1 - soldeVirement);
                    numParameter = new SqlParameter("@num", client1);
                    commande.Parameters.Add(soldeParameter);
                    commande.Parameters.Add(numParameter);
                    commande.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
                connexion.Close();


                connexion.Open();
                String solde1 = getSolde(client1);
                soldeClient1TextBox.Text = solde1;
                connexion.Close();

                connexion.Open();
                String solde2 = getSolde(client2);
                soldeClient2TextBox.Text = solde2;
                connexion.Close();

            }
            else
            {
                MessageBox.Show("Impossible");
            }
        }
    }
}
