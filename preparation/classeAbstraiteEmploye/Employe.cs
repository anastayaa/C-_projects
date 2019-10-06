using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeAbstraiteEmploye
{
    abstract class Employe
    {
        private int maricule;
        private String nom, prenom;
        private DateTime dateNaissance;

        public Employe(int matricule, String nom, String prenom, DateTime dateNaissance)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public int Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public override String ToString()
        {
            return Nom + " " + Prenom;
        }

        public abstract double getSalaire();
    }
}
