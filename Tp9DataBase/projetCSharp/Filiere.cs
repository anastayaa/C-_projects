using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class Filiere
    {
        int id;
        String nom;
        List<Etudiant> liste_etudiants;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        internal List<Etudiant> Liste_etudiants { get => liste_etudiants; set => liste_etudiants = value; }

        public Filiere(int id, string nom, List<Etudiant> liste_etudiants)
        {
            Id = id;
            Nom = nom;
            Liste_etudiants = liste_etudiants;
        }

        public Filiere(string nom, List<Etudiant> liste_etudiants)
        {
            Nom = nom;
            Liste_etudiants = liste_etudiants;
        }

        public Filiere(string nom)
        {
            Nom = nom;
        }

        public Filiere()
        {
        }
    }
}
