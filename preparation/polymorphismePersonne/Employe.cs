using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismePersonne
{
    class Employe:Personne
    {

        private double salaire;

        public Employe(String nom, String prenom, DateTime dateNaissance, double salaire):base(nom, prenom, dateNaissance)
        {
            Salaire = salaire;
        }

        public double Salaire { get; set; }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write(" " + Salaire);
        }
    }
}
