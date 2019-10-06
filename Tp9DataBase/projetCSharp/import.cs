using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetCSharp
{
	public partial class import : Form
	{
        String fileName = "";
		public import()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.ShowDialog();
            ofd.Filter = "Excel files | *.xls";
            fileName = ofd.FileName;
            txt_file.Text = fileName;
        }

        private void btn_charger_Click(object sender, EventArgs e)
        {
            if (!fileName.Equals(""))
            {
                try
                {
                    DataTable data = RetrieveSourceData(fileName);
                    MessageBox.Show(data.TableName);
                    CopyData(data);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selectionner un fichier");
            }
        }

        public static DataTable RetrieveSourceData(String path)
        {
            string sourceConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path+ ";Extended Properties=\"Excel 12.0\";";
            DataTable sourceData = new DataTable();
            using (OleDbConnection conn =
                       new OleDbConnection(sourceConnString))
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand(@"SELECT * FROM [Sheet1$]", conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                adapter.Fill(sourceData);
                conn.Close();
            }
            return sourceData;
        }

        public static void CopyData(DataTable sourceData)
        {
            string destConnString = @"Data Source=.;Initial Catalog=gestion_etudiants_projet_csharp;Integrated Security=true;";
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destConnString))
            {
                bulkCopy.DestinationTableName = "etudiant";
                bulkCopy.ColumnMappings.Add("cne_etudiant", "cne_etudiant");
                bulkCopy.ColumnMappings.Add("nom_etudiant", "nom_etudiant");
                bulkCopy.ColumnMappings.Add("prenom_etudiant", "prenom_etudiant");
                bulkCopy.ColumnMappings.Add("sexe_etudiant", "sexe_etudiant");
                bulkCopy.ColumnMappings.Add("date_naissance_etudiant", "date_naissance_etudiant");
                bulkCopy.ColumnMappings.Add("adresse_etudiant", "adresse_etudiant");
                bulkCopy.ColumnMappings.Add("telephone_etudiant", "telephone_etudiant");
                bulkCopy.ColumnMappings.Add("id_filiere", "id_filiere");
                bulkCopy.WriteToServer(sourceData);
            }
        }
        
    }
}
