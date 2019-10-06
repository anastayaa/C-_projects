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
    public partial class Form2 : Form
    {
        SqlConnection connexion;
        DataSet ds;
        DataTable dt;
        SqlDataAdapter dap;
        SqlCommand commande;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            String strConn = "Data Source=localhost; Initial Catalog=gestion_etudiant; " +
                "User Id=java; Password=anas/1997; Integrated Security=true";
            connexion = new SqlConnection();
            connexion.ConnectionString = strConn;

            ds = new DataSet();
            dt = new DataTable();
            commande = new SqlCommand();
            commande.Connection = connexion;
            commande.CommandText = "SELECT e.cne, e.nom, e.prenom, f.Nom_filiere FROM etudiant e, filiere f where e.id_fil = f.Id_filiere";
            dap = new SqlDataAdapter();
            dap.SelectCommand = commande;
            dap.Fill(dt);
            ds.Tables.Add(dt);

            foreach (DataRow row in dt.Rows)
            {
                cneComboBox.Items.Add(row["cne"]);
            }
            cneComboBox.SelectedIndex = 0;
        }

        private void chercherButton_Click(object sender, EventArgs e)
        {
            String cne = cneComboBox.Text;
            if (cne != "")
            {
                /*String req = "SELECT e.nom, e.prenom, f.Nom_filiere FROM etudiant e, filiere f where e.id_fil = f.Id_filiere and e.cne = @cne";
                commande.CommandText = req;
                SqlParameter cneParameter = new SqlParameter("@cne", cne);
                commande.Parameters.Clear();
                commande.Parameters.Add(cneParameter);
                dap = new SqlDataAdapter();
                dap.SelectCommand = commande;
                dt = new DataTable();
                dap.Fill(dt);
                ds.Reset();
                ds.Tables.Add(dt);
                nomTextBox.Text = dt.Rows[0][0].ToString();
                prenomTetBox.Text = dt.Rows[0][1].ToString();
                filiereTextBox.Text = dt.Rows[0][2].ToString();
                */
                int indice = cneComboBox.SelectedIndex;
                if (indice != -1)
                {
                    nomTextBox.Text = dt.Rows[indice][1].ToString();
                    prenomTetBox.Text = dt.Rows[indice][2].ToString();
                    filiereTextBox.Text = dt.Rows[indice][3].ToString();
                }
                
            }
            else
            {
                MessageBox.Show("Il faut selectionner un cne!!!");
            }
        }

        private void cneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cneComboBox.SelectedIndex;
            nomTextBox.Text = dt.Rows[indice][1].ToString();
            prenomTetBox.Text = dt.Rows[indice][2].ToString();
            filiereTextBox.Text = dt.Rows[indice][3].ToString();
        }
    }
}
