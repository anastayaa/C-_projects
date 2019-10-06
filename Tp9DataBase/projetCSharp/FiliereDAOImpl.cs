using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    class FiliereDAOImpl : FiliereDAO
    {
        SqlConnection connection;
        SqlCommand commande;
        SqlDataReader dataReader, dataReaderList;

        public FiliereDAOImpl()
        {
            connection = new SqlConnection("Data Source=.;Initial Catalog=gestion_etudiants_projet_csharp;Integrated Security=true; MultipleActiveResultSets=True");
        }

        public bool addFiliere(Filiere filiere)
        {
            connection.Open();
            bool result = false;
            commande = new SqlCommand("insert into filiere(nom_filiere) values(@nom_filiere)", connection);
            commande.Parameters.AddWithValue("@nom_filiere", filiere.Nom);
            try
            {
                commande.ExecuteNonQuery();
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

        public bool deleteFiliere(int idFiliere)
        {
            connection.Open();
            bool result = false;
            commande = new SqlCommand("DELETE FROM filiere WHERE id_filiere=@id_filiere", connection);
            commande.Parameters.AddWithValue("@id_filiere", idFiliere);
            try
            {
                commande.ExecuteNonQuery();
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

        public bool updateFiliere(Filiere filiere)
        {
            connection.Open();
            bool result = false;
            commande = new SqlCommand("update filiere set nom_filiere=@nom_filiere where id_filiere=@id_filiere", connection);
            commande.Parameters.AddWithValue("@nom_filiere", filiere.Nom);
            commande.Parameters.AddWithValue("@id_filiere", filiere.Id);
            try
            {
                commande.ExecuteNonQuery();
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

        public List<Filiere> getAllFilieres()
        {
            connection.Open();
            List<Filiere> filieres = null;
            commande = new SqlCommand("select * from filiere", connection);
            try
            {
                dataReader = commande.ExecuteReader();
                Filiere filiere = null;
                if (dataReader.HasRows)
                {
                    filieres = new List<Filiere>();
                    while (dataReader.Read())
                    {
                        SqlCommand commandeList = new SqlCommand("select e.*, f.* from etudiant e, filiere f where e.id_filiere=f.id_filiere and f.id_filiere=@id_filiere", connection);
                        filiere = new Filiere();
                        filiere.Id = Convert.ToInt32(dataReader["id_filiere"]);
                        filiere.Nom = dataReader["nom_filiere"].ToString();
                        commandeList.Parameters.AddWithValue("@id_filiere", filiere.Id);
                        dataReaderList = commandeList.ExecuteReader();
                        List<Etudiant> etudiants = null;
                        Etudiant etudiant = null;
                        if (dataReaderList.HasRows)
                        {
                            etudiants = new List<Etudiant>();
                            while (dataReaderList.Read())
                            {
                                etudiant = new Etudiant();
                                etudiant.Id = Convert.ToInt32(dataReaderList["id_etudiant"]);
                                etudiant.Cne = dataReaderList["cne_etudiant"].ToString();
                                etudiant.Nom = dataReaderList["nom_etudiant"].ToString();
                                etudiant.Prenom = dataReaderList["prenom_etudiant"].ToString();
                                etudiant.Sexe = Convert.ToChar(dataReaderList["sexe_etudiant"]);
                                etudiant.Date_naissance = dataReaderList["date_naissance_etudiant"].ToString();
                                etudiant.Adresse = dataReaderList["adresse_etudiant"].ToString();
                                etudiant.Telephone = dataReaderList["telephone_etudiant"].ToString();
                                etudiant.Id_filiere = Convert.ToInt32(dataReaderList["id_filiere"]);
                                etudiant.Filiere = dataReaderList["nom_filiere"].ToString();
                                etudiants.Add(etudiant);
                            }
                        }
                        commandeList.Parameters.Clear();
                        dataReaderList.Close();
                        filiere.Liste_etudiants = etudiants;
                        filieres.Add(filiere);
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
            return filieres;
        }
    }
}
