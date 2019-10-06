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

namespace Tp9DataBaseDeconnecteEx1
{
    public partial class Form3 : Form
    {
        SqlConnection connexion;
        DataSet ds;
        DataTable dt;
        SqlDataAdapter dap;
        SqlCommand commande;

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

            ds = new DataSet();
            dt = new DataTable();
            commande = new SqlCommand();
            commande.Connection = connexion;
            commande.CommandText = "SELECT * FROM compte";
            dap = new SqlDataAdapter();
            dap.SelectCommand = commande;
            dap.Fill(dt);
            ds.Tables.Add(dt);
        }

        private void soldeButton_Click(object sender, EventArgs e)
        {
            String client1 = client1TextBox.Text;
            String client2 = client2TextBox.Text;
            foreach (DataRow row in dt.Rows)
            {
                if (row["num"].ToString()==client1)
                {
                    soldeClient1TextBox.Text = row["solde"].ToString();
                }
                else if (row["num"].ToString() == client2)
                {
                    soldeClient2TextBox.Text = row["solde"].ToString();
                }
            }
        }

        private void virerButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                String client1 = client1TextBox.Text;
                String client2 = client1TextBox.Text;
                double soldeVirement = Convert.ToDouble(virementTextBox.Text);
                double soldeClient1 = Convert.ToDouble(soldeClient1TextBox.Text);
                double soldeClient2 = Convert.ToDouble(soldeClient2TextBox.Text);

                if (soldeClient1 > soldeVirement)
                {
                    DataRow[] tab = dt.Select("num=" + client2);
                    tab[0]["solde"] = soldeClient2 + soldeVirement;
                    SqlCommandBuilder cmdBuilder = new SqlCommandBuilder();
                    cmdBuilder.DataAdapter = dap;
                    dap.Update(dt);

                }
                else
                {
                    MessageBox.Show("Impossible");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}
