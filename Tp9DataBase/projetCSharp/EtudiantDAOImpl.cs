using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    class EtudiantDAOImpl : EtudiantDAO
    {
        SqlConnection connection;
        SqlCommand commande;
        SqlDataReader dataReader;

        public EtudiantDAOImpl()
        {
            connection = new SqlConnection("Data Source=.;Initial Catalog=gestion_etudiants_projet_csharp;Integrated Security=true;");
        }

        public bool addEtudiant(Etudiant etudiant)
        {
            connection.Open();
            bool result = false;
            SqlTransaction tr = connection.BeginTransaction();
            commande = new SqlCommand("insert into etudiant(cne_etudiant, nom_etudiant, prenom_etudiant, sexe_etudiant, date_naissance_etudiant, adresse_etudiant, telephone_etudiant, id_filiere) values(@cne_etudiant, @nom_etudiant, @prenom_etudiant, @sexe_etudiant, @date_naissance_etudiant, @adresse_etudiant, @telephone_etudiant, @id_filiere)", connection);
            commande.Transaction = tr;
            commande.Parameters.AddWithValue("@cne_etudiant", etudiant.Cne);
            commande.Parameters.AddWithValue("@nom_etudiant", etudiant.Nom);
            commande.Parameters.AddWithValue("@prenom_etudiant", etudiant.Prenom);
            commande.Parameters.AddWithValue("@sexe_etudiant", etudiant.Sexe);
            commande.Parameters.AddWithValue("@date_naissance_etudiant", etudiant.Date_naissance);
            commande.Parameters.AddWithValue("@adresse_etudiant", etudiant.Adresse);
            commande.Parameters.AddWithValue("@telephone_etudiant", etudiant.Telephone);
            commande.Parameters.AddWithValue("@id_filiere", etudiant.Id_filiere);
            try
            {
                commande.ExecuteNonQuery();
                tr.Commit();
                result = true;
            }
            catch (Exception ex)
            {
                tr.Rollback();
                throw new Exception(ex.Message);
            }
            finally
            {
                commande.Dispose();
                connection.Close();
            }
            return result;
        }

        public bool deleteEtudiant(int idEtudiant)
        {
            connection.Open();
            bool result = false;
            commande = new SqlCommand("DELETE FROM etudiant WHERE id_etudiant=@id_etudiant", connection);
            commande.Parameters.AddWithValue("@id_etudiant", idEtudiant);
            try
            {
                int i = commande.ExecuteNonQuery();
                if (i > 0)
                    result = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                commande.Dispose();
                connection.Close();
            }
            return result;
        }

        public bool updateEtudiant(Etudiant etudiant)
        {
            connection.Open();
            bool result = false;
            commande = new SqlCommand("update etudiant set cne_etudiant=@cne_etudiant, nom_etudiant=@nom_etudiant, prenom_etudiant=@prenom_etudiant, sexe_etudiant=@sexe_etudiant, date_naissance_etudiant=@date_naissance_etudiant, adresse_etudiant=@adresse_etudiant, telephone_etudiant=@telephone_etudiant, id_filiere=@id_filiere where id_etudiant=@id_etudiant", connection);
            commande.Parameters.AddWithValue("@cne_etudiant", etudiant.Cne);
            commande.Parameters.AddWithValue("@nom_etudiant", etudiant.Nom);
            commande.Parameters.AddWithValue("@prenom_etudiant", etudiant.Prenom);
            commande.Parameters.AddWithValue("@sexe_etudiant", etudiant.Sexe);
            commande.Parameters.AddWithValue("@date_naissance_etudiant", etudiant.Date_naissance);
            commande.Parameters.AddWithValue("@adresse_etudiant", etudiant.Adresse);
            commande.Parameters.AddWithValue("@telephone_etudiant", etudiant.Telephone);
            commande.Parameters.AddWithValue("@id_filiere", etudiant.Id_filiere);
            commande.Parameters.AddWithValue("@id_etudiant", etudiant.Id);
            try
            {
                int i=commande.ExecuteNonQuery();
                if(i>0)
                    result = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                commande.Dispose();
                connection.Close();
            }
            return result;
        }

        public List<Etudiant> getAllEtudiants(String tri)
        {
            connection.Open();
            List<Etudiant> etudiants=null;
            commande = new SqlCommand("select * from etudiant e, filiere f where f.id_filiere=e.id_filiere order by nom_etudiant "+tri, connection);
            try
            {
                dataReader = commande.ExecuteReader();
                Etudiant etudiant = null;
                if (dataReader.HasRows)
                {
                    etudiants = new List<Etudiant>();
                    while (dataReader.Read())
                    {
                        etudiant = new Etudiant();
                        etudiant.Id = Convert.ToInt32(dataReader["id_etudiant"]);
                        etudiant.Cne = dataReader["cne_etudiant"].ToString();
                        etudiant.Nom= dataReader["nom_etudiant"].ToString();
                        etudiant.Prenom= dataReader["prenom_etudiant"].ToString();
                        etudiant.Sexe= Convert.ToChar(dataReader["sexe_etudiant"]);
                        etudiant.Date_naissance= dataReader["date_naissance_etudiant"].ToString();
                        etudiant.Adresse= dataReader["adresse_etudiant"].ToString();
                        etudiant.Telephone= dataReader["telephone_etudiant"].ToString();
                        etudiant.Id_filiere = Convert.ToInt32(dataReader["id_filiere"]);
                        etudiant.Filiere = dataReader["nom_filiere"].ToString();
                        etudiants.Add(etudiant);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                commande.Dispose();
                connection.Close();
            }
            return etudiants;
        }
    }
}
