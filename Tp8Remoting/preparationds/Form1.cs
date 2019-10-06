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

namespace preparationds
{
    public partial class Form1 : Form
    {
        SqlConnection connexion;
        DataSet ds;
        DataTable dt;
        SqlDataAdapter dap;
        SqlCommand commande;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            if (dt!=null && dt.Rows.Count>0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    cneComboBox.Items.Add(row["cne"]);
                }
                //cneComboBox.SelectedIndex = 0;
            }
        }

        private void cneComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cne = cneComboBox.Text;
            if (cne != null)
            {
                int indice = cneComboBox.SelectedIndex;
                if (indice != -1)
                {
                    nomTextBox.Text = dt.Rows[indice][1].ToString();
                    prenomTetBox.Text = dt.Rows[indice][2].ToString();
                    filiereComboBox.Items.Clear();
                    filiereComboBox.Items.Add(dt.Rows[indice][3].ToString());
                    if (filiereComboBox.Items.Count > 0)
                    {
                        filiereComboBox.SelectedIndex = 0;
                    }
                }

            }
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            nomTextBox.Text = "";
            prenomTetBox.Text = "";
            filiereComboBox.Items.Clear();
            dt.Clear();

            /* Mode deconnecte
            commande.CommandText = "SELECT Nom_filiere FROM filiere";
            dap.SelectCommand = commande;
            dap.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    filiereComboBox.Items.Add(row["Nom_filiere"]);
                }
                filiereComboBox.SelectedIndex = 0;
            }
            */

            /* Mode connecte
            connexion.Open();
            commande.CommandText = "SELECT Nom_filiere FROM filiere";
            SqlDataReader line = commande.ExecuteReader();
            if (line.HasRows)
            {
                 while (line.Read())
                 {
                    filiereComboBox.Items.Add(line[0]);
                 }
                filiereComboBox.SelectedIndex = 0;
                connexion.Close();
            }
            */
        }

        private void validerAjoutButton_Click(object sender, EventArgs e)
        {
            String filiere = filiereComboBox.SelectedItem.ToString();
            String id_filiere="";
            connexion.Open();
            commande.CommandText = "SELECT * FROM filiere where Nom_filiere=@Nom_filiere";
            commande.Parameters.Clear();
            commande.Parameters.AddWithValue("@Nom_filiere", filiere);
            SqlDataReader line = commande.ExecuteReader();
            if (line.HasRows)
            {
                while (line.Read())
                {
                    id_filiere = line["id_filiere"].ToString();
                    break;
                }
            }
            line.Close();
            if (id_filiere != "")
            {
                DateTime date = Convert.ToDateTime(dateNaissanceDateTime.Text);
                String dateNaissance = date.ToString("yyyy-MM-dd");
                commande.CommandText = "INSERT INTO etudiant(cne, nom, prenom, sexe, date_naiss, id_fil) VALUES(@cne, @nom, @prenom, @sexe, @date_naiss, @id_fil)";
                commande.Parameters.AddWithValue("@cne", 123456565);
                commande.Parameters.AddWithValue("@nom", "TAYAA");
                commande.Parameters.AddWithValue("@prenom", "Anas");
                commande.Parameters.AddWithValue("@sexe", 'H');
                commande.Parameters.AddWithValue("@date_naiss", dateNaissance);
                commande.Parameters.AddWithValue("@id_fil", id_filiere);
                try
                {
                    commande.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    commande.Dispose();
                    connexion.Close();
                }
            }
            else
            {
                MessageBox.Show("filiere non trouvee");
            }
            line.Close();
        }

        private void modifierButton_Click(object sender, EventArgs e)
        {
            String cne = cneComboBox.Text;
            if (cne != "")
            {
                connexion.Open();
                commande = new SqlCommand();
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
                }
                if (!line.HasRows)
                {
                    MessageBox.Show("L'etudiant avec cet cne n'existe pas!!!");
                }
                line.Close();
                connexion.Close();

                filiereComboBox.Items.Clear();
                connexion.Open();
                commande.CommandText = "SELECT Nom_filiere FROM filiere";
                line = commande.ExecuteReader();
                if (line.HasRows)
                {
                    while (line.Read())
                    {
                        filiereComboBox.Items.Add(line[0]);
                    }
                    filiereComboBox.SelectedIndex = 0;
                    connexion.Close();
                }
            }
        }
    }
}
