using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   DAO
{
    class Etudiant
    {
        int id;
        private String cne;
        String nom;
        String prenom;
        char sexe;
        String date_naissance;
        String adresse;
        String telephone;
        String filiere;
        int id_filiere;

        public Etudiant()
        {
        }

        public Etudiant(string cne, string nom, string prenom, char sexe, string date_naissance, string adresse, string telephone, int id_filiere)
        {
            Cne = cne;
            Nom = nom;
            Prenom = prenom;
            Sexe = sexe;
            Date_naissance = date_naissance;
            Adresse = adresse;
            Telephone = telephone;
            Id_filiere = id_filiere;
        }

        public Etudiant(int id, string cne, string nom, string prenom, char sexe, string date_naissance, string adresse, string telephone, int id_filiere)
        {
            Id = id;
            Cne = cne;
            Nom = nom;
            Prenom = prenom;
            Sexe = sexe;
            Date_naissance = date_naissance;
            Adresse = adresse;
            Telephone = telephone;
            Id_filiere = id_filiere;
        }

        public int Id { get => id; set => id = value; }
        public string Cne { get => cne; set => cne = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public char Sexe { get => sexe; set => sexe = value; }
        public string Date_naissance { get => date_naissance; set => date_naissance = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public int Id_filiere { get => id_filiere; set => id_filiere = value; }
        public string Filiere { get => filiere; set => filiere = value; }
    }
}
