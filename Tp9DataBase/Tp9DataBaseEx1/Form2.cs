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
    public partial class Form2 : Form
    {
        SqlConnection connexion;

        public Form2()
        {
            InitializeComponent();

            String strConn = "Data Source=localhost; Initial Catalog=gestion_etudiant; " +
                "User Id=java; Password=anas/1997; Integrated Security=true";

            connexion = new SqlConnection();
            connexion.ConnectionString = strConn;
            connexion.Open();

            SqlCommand commande = new SqlCommand();
            commande.Connection = connexion;
            commande.CommandText = "SELECT cne FROM etudiant";
            SqlDataReader line = commande.ExecuteReader();
            
            while (line.Read())
            {
                cneComboBox.Items.Add(line[0]);
            }
            connexion.Close();
        }

        private void chercherButton_Click(object sender, EventArgs e)
        {

            String cne = cneComboBox.Text;
            if (cne != "")
            {
                connexion.Open();
                SqlCommand commande = new SqlCommand();
                commande.Connection = connexion;
                String req = "SELECT e.nom, e.prenom, f.Nom_filiere FROM etudiant e, filiere f where e.id_fil = f.Id_filiere and e.cne = @cne";
                commande.CommandText = req;

                SqlParameter sqlParameter = new SqlParameter("@cne", cne);
                commande.Parameters.Add(sqlParameter);

                SqlDataReader line = commande.ExecuteReader();
                while (line.Read())
                {
                    nomTextBox.Text = line[0].ToString();
                    prenomTetBox.Text = line[1].ToString();
                    filiereTextBox.Text = line[2].ToString();
                }
                if (!line.HasRows)
                {
                    MessageBox.Show("L'etudiant avec cet cne n'existe pas!!!");
                }
                connexion.Close();
            }
            else
            {
                MessageBox.Show("Il faut selectionner un cne!!!");
            }
        }
    }
}
