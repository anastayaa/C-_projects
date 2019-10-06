using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeAbstraiteEmploye
{
    class Patron:Employe
    {
        public static double chiffreAffaire;
        private double pourcentage;

        public Patron(int matricule, string nom, string prenom, DateTime dateNaissance, double pourcentage) : base(matricule, nom, prenom, dateNaissance)
        {
            Pourcentage = pourcentage;
        }

        public double ChiffreAffaire { get; set; }
        public double Pourcentage { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + getSalaire();
        }

        public override double getSalaire()
        {
            return ChiffreAffaire * pourcentage / 100;
        }
    }
}
