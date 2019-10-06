using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dao
{
    class DAOPersonImpl:DAOPerson
    {
        SqlConnection connection;
        SqlCommand commande;
        StringBuilder sb;

        public DAOPersonImpl(String db)
        {
            connection= new SqlConnection("Data Source=.;Initial Catalog="+db+";Integrated Security=true;");
            sb = new StringBuilder();
        }

        public bool addPerson(Person person)
        {
            bool result = false;
            connection.Open();
            commande = new SqlCommand("insert into person(name,state,id_filiere) values(@name,@state,@id_filiere)", connection);
            commande.Parameters.AddWithValue("@name", person.Name);
            commande.Parameters.AddWithValue("@state", person.State);
            commande.Parameters.AddWithValue("@id_filiere", person.Id_filiere);
            try
            {
                commande.ExecuteNonQuery();
                result = true;
            }
            catch(Exception ex)
            {
                sb.Append(new DateTime() + " " + ex.Message + "\n");
                //File.AppendAllText("logs/log.txt", sb.ToString());
                sb.Clear();
            }
            finally
            {
                commande.Dispose();
                connection.Close();
            }
            return result;
        }

        public List<Person> getAllPerson()
        {
            connection.Open();
            List<Person> persons = new List<Person>();
            string sqlQuery = String.Format("select * from person");
            commande = new SqlCommand(sqlQuery, connection);
            try{
                SqlDataReader dataReader = commande.ExecuteReader();
                Person person = null;
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        person = new Person();
                        person.Id = Convert.ToInt32(dataReader["id"]);
                        person.Name = dataReader["name"].ToString();
                        person.State = dataReader["state"].ToString();
                        person.Id_filiere = Convert.ToInt32(dataReader["id_filiere"]);
                        persons.Add(person);
                    }
                }
            }
            catch (Exception ex)
            {
                sb.Append(new DateTime()+" "+ex.Message+"\n");
                //File.AppendAllText("..\\..\\logs\\log.txt", sb.ToString());
                sb.Clear();
            }
            finally
            {
                commande.Dispose();
                connection.Close();
            }
            return persons;
        }

        public bool updatePerson(Person person)
        {
            bool result = false;
            connection.Open();
            commande = new SqlCommand("update person set Name=@name,State=@state,id_filiere=@id_filiere where ID=@id", connection);
            commande.Parameters.AddWithValue("@id", person.Id);
            commande.Parameters.AddWithValue("@name", person.Name);
            commande.Parameters.AddWithValue("@state", person.State);
            commande.Parameters.AddWithValue("@id_filiere", person.Id_filiere);
            try
            {
                commande.ExecuteNonQuery();
                result = true;
            }
            catch(Exception ex)
            {
                sb.Append(new DateTime() + " " + ex.Message + "\n");
                //File.AppendAllText("logs/log.txt", sb.ToString());
                sb.Clear();
            }
            finally
            {
                commande.Dispose();
                connection.Close();
            }
            return result;
        }

        public bool deletePerson(int idPerson)
        {
            bool result = false;
            connection.Open();
            commande = new SqlCommand("delete person where ID=@id", connection);
            commande.Parameters.AddWithValue("@id", idPerson);
            try
            {
                commande.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                sb.Append(new DateTime() + " " + ex.Message + "\n");
                //File.AppendAllText("logs/log.txt", sb.ToString());
                sb.Clear();
            }
            finally
            {
                commande.Dispose();
                connection.Close();
            }
            return result;
        }
    }
}
