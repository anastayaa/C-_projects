using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace projetCSharp
{
    public partial class Form1 : Form
    {
        FiliereDAOImpl filiereDAO;
        EtudiantDAOImpl etudiantDAO;
        int idFiliere;
        int idEtudiant;
        String tri = "asc";

        public Form1()
        {
            InitializeComponent();
            filiereDAO = new FiliereDAOImpl();
            etudiantDAO = new EtudiantDAOImpl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            actualiser();
            com_Filiere.SelectedIndex = 0;
            radio_Feminin.Checked = true;
            //tabControl1.TabPages[3].C;
        }

        /**
         * L'ajout d'une nouvelle filiere
         * **/
        private void btn_Ajout_Click(object sender, EventArgs e)
        {
            String nomFiliere = txt_Filiere.Text;
            if (!nomFiliere.Equals(""))
            {
                Filiere filiere = new Filiere(nomFiliere);
                if (filiereDAO.addFiliere(filiere))
                {
                    MessageBox.Show("Filiere ajoutée avec succes");
                    actualiser();
                }
                else
                {
                    MessageBox.Show("Probleme d'ajout de la filiere");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir le nom de la filiere");
            }
        }

        /**
         * Supprimer une filiere
         * **/
        private void btn_Supprimer_Click_1(object sender, EventArgs e)
        {
            
            if (dataGridViewFiliere.CurrentRow != null)
            {
                idFiliere = int.Parse(dataGridViewFiliere.CurrentRow.Cells[0].Value.ToString());
                if (filiereDAO.deleteFiliere(idFiliere))
                {
                    MessageBox.Show("Filiere supprimee");
                    actualiser();
                }
                else
                {
                    MessageBox.Show("Erreur de supression");
                }
            }
            else
            {
                MessageBox.Show("Aucune ligne selectionnee");
            }
        }

        /**
         * Modifier une filiere (Replissage du dialog)
         * 
         **/
        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            if (dataGridViewFiliere.CurrentRow != null)
            {
                panel1.Visible = true;
                idFiliere = int.Parse(dataGridViewFiliere.CurrentRow.Cells[0].Value.ToString());
                txt_filiere_nv.Text = dataGridViewFiliere.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Aucune ligne selectionnee");
            }
        }

        /**
         * Modifier une filiere(Valider la modification)
         **/
        private void Btn_Valider_Click(object sender, EventArgs e)
        {
            if (!txt_filiere_nv.Text.Equals(""))
            {
                String nomFiliere = txt_filiere_nv.Text;
                Filiere filiere = new Filiere();
                filiere.Id = idFiliere;
                filiere.Nom = nomFiliere;
                if (filiereDAO.updateFiliere(filiere))
                {
                    MessageBox.Show("Filiere modifiée avec succes");
                    actualiser();
                }
                else
                {
                    MessageBox.Show("Probleme de modification de la filiere");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir le nom de la filiere");
            }
            panel1.Visible = false;
        }

        /**
         * L'ajout d'un nouveau etudiant
         **/
        private void Btn_Ajout_etudiant_Click(object sender, EventArgs e)
        {
            if (!txt_Cne.Text.Equals("") && !txt_nom.Text.Equals("") && !txt_prenom.Text.Equals("")
                && !dateTime.Text.Equals("")
                && !txt_Adresse.Text.Equals("") && !txt_Telephone.Equals(""))
            {
                String cne = txt_Cne.Text;
                String nom = txt_nom.Text;
                String prenom = txt_prenom.Text;
                char sexe='F';
                if (radio_masculin.Checked == true)
                {
                    sexe = 'M';
                }

                DateTime date = Convert.ToDateTime(dateTime.Text);
                String dateNaissance = date.ToString("yyyy-MM-dd");
                String adresse = txt_Adresse.Text;
                String telephone = txt_Telephone.Text;
                String nom_filiere = com_Filiere.SelectedItem.ToString();
                
                Etudiant etudiant = new Etudiant();
                etudiant.Cne = cne;
                etudiant.Nom = nom;
                etudiant.Prenom = prenom;
                etudiant.Sexe = sexe;
                etudiant.Date_naissance = dateNaissance;
                etudiant.Adresse = adresse;
                etudiant.Telephone = telephone;
                foreach (Filiere filiere in filiereDAO.getAllFilieres())
                {
                    if (filiere.Nom.Equals(nom_filiere))
                    {

                        etudiant.Id_filiere = filiere.Id;
                        break;
                    }
                }
                bool exist = false;
                foreach(Etudiant et in etudiantDAO.getAllEtudiants(tri))
                {
                    if (et.Cne.Equals(cne))
                    {
                        exist = true;
                        break;
                    }
                }

                try
                {
                    if (exist)
                    {
                        MessageBox.Show("Etudiant deja existe");
                    }
                    else
                    {
                        if (etudiantDAO.addEtudiant(etudiant))
                        {
                            MessageBox.Show("Etudiant ajoute avec succes");
                            actualiser();
                        }
                        else
                        {
                            MessageBox.Show("Erreur d'ajout de l'etudiant");
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir toutes les informations");
            }
        }

        /**
         * Chercher un etudiant
         **/
        private void com_Cne_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cne = com_cne.SelectedItem.ToString();
            Etudiant etudiant = null;
            if (!cne.Equals(""))
            {
                foreach(Etudiant et in etudiantDAO.getAllEtudiants(tri))
                {
                    if (et.Cne.Equals(cne))
                    {
                        etudiant = et;
                        break;
                    }
                }
                idEtudiant = etudiant.Id;
                txt_Cne.Text = etudiant.Cne;
                txt_nom.Text = etudiant.Nom;
                txt_prenom.Text = etudiant.Prenom;
                if (etudiant.Sexe == 'F')
                {
                    radio_Feminin.Checked = true;
                }
                else
                {
                    radio_masculin.Checked = true;
                }
                dateTime.Text = etudiant.Date_naissance;
                txt_Adresse.Text = etudiant.Adresse;
                txt_Telephone.Text = etudiant.Telephone;
                foreach(Filiere filiere in filiereDAO.getAllFilieres())
                {
                    if (filiere.Id == etudiant.Id_filiere)
                    {
                        com_Filiere.Text = filiere.Nom;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Il faut selectionner un etudiant");
            }
        }

        /**
         * L'ajout d'un nouveau etudiant
         **/
        private void btn_modifier_etudiant_Click(object sender, EventArgs e)
        {
            if (!txt_Cne.Text.Equals("") && !txt_nom.Text.Equals("") && !txt_prenom.Text.Equals("")
                && !dateTime.Text.Equals("")
                && !txt_Adresse.Text.Equals("") && !txt_Telephone.Equals(""))
            {
                String cne = txt_Cne.Text;
                String nom = txt_nom.Text;
                String prenom = txt_prenom.Text;
                char sexe = 'F';
                if (radio_masculin.Checked == true)
                {
                    sexe = 'M';
                }

                DateTime date = Convert.ToDateTime(dateTime.Text);
                String dateNaissance = date.ToString("yyyy-MM-dd");
                String adresse = txt_Adresse.Text;
                String telephone = txt_Telephone.Text;
                String nom_filiere = com_Filiere.SelectedItem.ToString();

                Etudiant etudiant = new Etudiant();
                etudiant.Id = idEtudiant;
                etudiant.Cne = cne;
                etudiant.Nom = nom;
                etudiant.Prenom = prenom;
                etudiant.Sexe = sexe;
                etudiant.Date_naissance = dateNaissance;
                etudiant.Adresse = adresse;
                etudiant.Telephone = telephone;
                foreach (Filiere filiere in filiereDAO.getAllFilieres())
                {
                    if (filiere.Nom.Equals(nom_filiere))
                    {
                        etudiant.Id_filiere = filiere.Id;
                        break;
                    }
                }
                bool self = true;
                foreach (Etudiant et in etudiantDAO.getAllEtudiants(tri))
                {
                    if (et.Cne.Equals(cne) && et.Id!= idEtudiant)
                    {
                        self = false;
                        break;
                    }
                }

                try
                {
                    if (self)
                    {
                        if (etudiantDAO.updateEtudiant(etudiant))
                        {
                            MessageBox.Show("Etudiant modifie avec succes");
                            actualiser();
                        }
                        else
                        {
                            MessageBox.Show("Erreur de modification de l'etudiant");
                        }
                    }
                    else
                    {

                        MessageBox.Show("Etudiant deja existe");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir toutes les informations");
            }
        }

        /**
         * Supprimer un etudiant
         */
        private void btn_supprimer_etudiant_Click(object sender, EventArgs e)
        {
            if (com_cne.SelectedItem!=null)
            {
                if (etudiantDAO.deleteEtudiant(idEtudiant))
                {
                    MessageBox.Show("Etudiant supprime avec succes");
                    actualiser();
                }
                else
                {
                    MessageBox.Show("Erreur de suppression");
                }
            }
            else
            {
                MessageBox.Show("Il faut selectionner un etudiant");
            }    
        }

        /**
         * chargement de donnees
         **/
        private void btn_charger_donnees_Click(object sender, EventArgs e)
        {
            actualiser();
        }

        /**
         * tri croissant
         **/
        private void btn_tri_croissant_Click(object sender, EventArgs e)
        {
            //dataGridViewEtudiant.Sort(dataGridViewEtudiant.Columns[2], ListSortDirection.Ascending);
            //dataGridViewEtudiant.Columns["Nom"].SortMode = DataGridViewColumnSortMode.Automatic;
            tri = "asc";
            actualiser();
        }

        /**
         * tri decroissant
         **/
        private void btn_tri_decroissant_Click(object sender, EventArgs e)
        {
            tri = "desc";
            actualiser();
        }

        /**
         * Charger la liste des etudiants depuis excel
         **/
        private void btn_importer_Click_1(object sender, EventArgs e)
        {
            new import().Show();
        }


		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{ 

		}

		private void Btn_importer_Click(object sender, EventArgs e)
		{
			new import().Show();
			 
		}

		private void Reperporting_Click(object sender, EventArgs e)
		{

		}

		private void chart1_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			MessageBox.Show(index + "");
			DataGridViewRow SelectRow = dataGridViewEtudiant.Rows[index];

			txt_Cne.Text = SelectRow.Cells[0].Value.ToString();

			txt_nom.Text = SelectRow.Cells[1].Value.ToString();

			txt_prenom.Text = SelectRow.Cells[2].Value.ToString();

			

			if (SelectRow.Cells[3].Value.ToString()=="F")
			{
				radio_masculin.Checked=true;

			}

			else radio_Feminin.Checked = true;

			dateTime.Text = SelectRow.Cells[4].Value.ToString();

			txt_Adresse.Text = SelectRow.Cells[5].Value.ToString();
			 
			txt_Telephone.Text = SelectRow.Cells[6].Value.ToString();

			txt_Filiere.Text = SelectRow.Cells[7].Value.ToString();





		}

		private void Btn_Afficher_Click(object sender, EventArgs e)
		{
		
		}

        

        private void Btn_md_Click(object sender, EventArgs e)
		{



			String Cne = txt_Cne.Text=dataGridViewEtudiant.CurrentRow.Cells[1].Value.ToString();

			String nom = txt_nom.Text = dataGridViewEtudiant.CurrentRow.Cells[2].Value.ToString();

			String prenom = txt_prenom.Text = dataGridViewEtudiant.CurrentRow.Cells[3].Value.ToString();

			String sexe = dataGridViewEtudiant.CurrentRow.Cells[4].Value.ToString();

			if (sexe =="M")
			{
				radio_masculin.Checked = true;


			}

			else radio_Feminin.Checked=true ;

			//String date = dateTime.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();

			String adresse = txt_Adresse.Text = dataGridViewEtudiant.CurrentRow.Cells[5].Value.ToString();

			String telephone = txt_Telephone.Text = dataGridViewEtudiant.CurrentRow.Cells[6].Value.ToString();

			String filiere = com_Filiere.Text = dataGridViewEtudiant.CurrentRow.Cells[7].Value.ToString();




		}

		

		private void Btn_tt_Click(object sender, EventArgs e)
		{
		}


        /**
         * Les fonctions
         * */

        private void actualiser()
        {
            var bindingListEtudiants = new BindingList<Etudiant>(etudiantDAO.getAllEtudiants(tri));
            var etudiants = new BindingSource(bindingListEtudiants, null);

            var bindingListFilieres = new BindingList<Filiere>(filiereDAO.getAllFilieres());
            var filieres = new BindingSource(bindingListFilieres, null);

            dataGridViewFiliere.DataSource = filieres;
            dataGridViewEtudiant.DataSource = etudiants;

            if (etudiantDAO.getAllEtudiants(tri) != null)
            {
                com_cne.Items.Clear();
                com_cne_reporting.Items.Clear();
                foreach (Etudiant etudiant in etudiantDAO.getAllEtudiants(tri))
                {
                    com_cne.Items.Add(etudiant.Cne);
                    com_cne_reporting.Items.Add(etudiant.Cne);
                }
            }
            
            if (filiereDAO.getAllFilieres() != null)
            {
                com_Filiere.Items.Clear();
                foreach (Filiere filiere in filiereDAO.getAllFilieres())
                {
                    com_Filiere.Items.Add(filiere.Nom);
                }
            }

            /**
             * Chart
             **/
            chart_etudiant.Series["Etudiant"].Points.Clear();
            chart_etudiant.ChartAreas[0].AxisY.Maximum = 100;
            foreach(Filiere filiere in filiereDAO.getAllFilieres())
            {

                int x = chart_etudiant.Series["Etudiant"].Points.AddXY(filiere.Nom, ((double)filiere.Liste_etudiants.Count / (double)etudiantDAO.getAllEtudiants(tri).Count)*100);
                chart_etudiant.Series["Etudiant"].Points[x].Label = Math.Round(((double)filiere.Liste_etudiants.Count / (double)etudiantDAO.getAllEtudiants(tri).Count) * 100, 2) + "%";
            }
        }

    }
}
