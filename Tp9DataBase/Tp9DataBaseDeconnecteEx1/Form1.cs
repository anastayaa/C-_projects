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
    public partial class Form1 : Form
    {
        SqlConnection connexion;
        DataSet ds;
        DataTable dt;
        SqlDataAdapter dap;

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
            SqlCommand commande = new SqlCommand();
            commande.Connection = connexion;
            commande.CommandText = "SELECT * FROM filiere";
            dap = new SqlDataAdapter();
            dap.SelectCommand = commande;
            dap.Fill(dt);
            ds.Tables.Add(dt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String filiere = filiereTextBox.Text;
            DataRow dr = dt.NewRow();
            dr["nom_filiere"] = filiere;
            dt.Rows.Add(dr);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder();
            cmdBuilder.DataAdapter = dap;
            dap.Update(dt);
        }
    }
}
