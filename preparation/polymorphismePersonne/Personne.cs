using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismePersonne
{
    class Personne
    {
        private String nom, prenom;
        private DateTime dateNaissance;

        public String Nom
        {
            set
            {
                nom = value;
            }
            get
            {
                return nom;
            }
        }

        public String Prenom
        {
            get
            {
                return prenom;
            }
            set
            {
                prenom = value;
            }
        }

        public DateTime DateNaissance
        {
            set;
            get;
        }

        public Personne(String nom, String prenom, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public virtual void Afficher()
        {
            Console.WriteLine(this.Nom+" "+this.Prenom+" "+this.DateNaissance);
        }
    }
}
