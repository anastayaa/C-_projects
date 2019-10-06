using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeAbstraiteEmploye
{
    class Cadre:Employe
    {
        private int indice;

        public Cadre(int matricule, string nom, string prenom, DateTime dateNaissance, int indice) : base(matricule, nom, prenom, dateNaissance)
        {
            Indice = indice;
        }

        public int Indice
        {
            get;
            set;
        }

        public override string ToString()
        {
            return base.ToString() + " " + getSalaire();
        }

        public override double getSalaire()
        {
            if (Indice == 1)
            {
                return 13000;
            }
            else if (Indice == 2)
            {
                return 15000;
            }
            else if (Indice == 3)
            {
                return 17000;
            }
            else
            {
                return 20000;
            }
        }
    }
}
