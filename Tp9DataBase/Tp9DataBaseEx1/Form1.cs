using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp9DataBaseEx1
{
    public partial class Form1 : Form
    {
        SqlConnection connexion;
        public Form1()
        {
            InitializeComponent();

            String strConn = "Data Source=localhost; Initial Catalog=gestion_etudiant; " +
                "User Id=java; Password=anas/1997; Integrated Security=true";

            connexion =new SqlConnection();
            connexion.ConnectionString = strConn;
            connexion.Open();

            MessageBox.Show("Connexion etablie");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String filiere = filiereTextBox.Text;
            SqlCommand commande = new SqlCommand();
            commande.Connection = connexion;
            commande.CommandText = "INSERT INTO filiere(nom_filiere) VALUES(@nom_filiere)";
            SqlParameter nom_filiere = new SqlParameter("@nom_filiere", filiere);
            commande.Parameters.Add(nom_filiere);
            commande.ExecuteNonQuery();
        }
    }
}
