using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeAbstraiteEmploye
{
    class Ouvrier : Employe
    {
        private DateTime dateEntree;
        public static double SMIG = 2500;

        public Ouvrier(int matricule, String nom, String prenom, DateTime dateNaissance, DateTime dateEntree)
        :base(matricule, nom, prenom, dateNaissance){
                DateEntree = dateEntree;
        }

        public DateTime DateEntree { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + getSalaire();
        }

        public override double getSalaire()
        {
            double salaire = SMIG + (new DateTime().Year - dateEntree.Year) * 100;
            if (salaire > SMIG * 2)
            {
                return SMIG * 2;
            }
            return salaire;
        }
    }
}
