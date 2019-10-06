using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismePersonne
{
    class Directeur:Chef
    {
        private String societe;

        public Directeur(String nom, String prenom, DateTime dateNaissance, double salaire, String service, String societe):base(nom, prenom, dateNaissance, salaire, service)
        {
            Societe = societe;
        }

        public string Societe { get; set; }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write(" " + Societe);
        }
    }
}
