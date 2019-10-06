using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp9DataBaseReporting
{
    public partial class Form1 : Form
    {
        EtudiantDataClassesDataContext etudiantData;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            etudiantData = new EtudiantDataClassesDataContext();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("cne");
            dt.Columns.Add("nom");
            dt.Columns.Add("prenom");

            /*dt.Columns.Add(
                new DataColumn()
                {
                    DataType = System.Type.GetType("System.String"),//or other type
                    ColumnName = "Name"      //or other column name
                }
            );
            */

            var etudiants = from etudiant in etudiantData.etudiant select etudiant;
            foreach(var etudiant in etudiants)
            {
                cneComboBox.Items.Add(etudiant.cne);

                var row = dt.NewRow();
                row["cne"] = etudiant.cne;
                row["nom"] = etudiant.nom;
                row["prenom"] = etudiant.prenom;
                dt.Rows.Add(row);
            }

            etudiant_datagridview.DataSource = etudiants;
            etudiant_datagridview.Sort(etudiant_datagridview.Columns["nom"], ListSortDirection.Ascending);

            CrystalReport1 crystal = new CrystalReport1();
            crystal.SetDataSource(dt);
            crystalReportViewer1.ReportSource = crystal;
            crystalReportViewer1.Refresh();
            //crystalReportViewer1.Hide();
        }

        private void reportingButton_Click(object sender, EventArgs e)
        {
            var etudiants = from etudiant in etudiantData.etudiant
                            join filiere in etudiantData.Filiere
                            on etudiant.id_fil equals filiere.Id_filiere
                            select new { etudiant.cne, etudiant.nom, etudiant.prenom, filiere.Nom_filiere};
            CrystalReport1 crystal = new CrystalReport1();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("cne");
            dataTable.Columns.Add("nom");
            dataTable.Columns.Add("prenom");
            dataTable.Columns.Add("filiere");

            foreach (var etudiant in etudiants)
            {

                var row = dataTable.NewRow();
                row["cne"] = etudiant.cne;
                row["nom"] = etudiant.nom;
                row["prenom"] = etudiant.prenom;
                row["filiere"] = etudiant.Nom_filiere;
                dataTable.Rows.Add(row);
            }
            crystal.SetDataSource(dataTable);
            crystalReportViewer1.ReportSource = crystal;
            crystalReportViewer1.Refresh();
        }

       
    }
}
