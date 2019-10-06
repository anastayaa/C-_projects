using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismePersonne
{
    class Chef:Employe
    {
        private String service;

        public Chef(String nom, String prenom, DateTime dateNaissance, double salaire, String service):base(nom, prenom, dateNaissance, salaire)
        {
            Service = service;
        }

        public string Service { get; set; }

        public override void Afficher()
        {
            base.Afficher();
            Console.Write(" " + Service);
        }
    }
}
