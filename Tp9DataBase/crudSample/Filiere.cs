using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dao
{
    class Filiere
    {
        int id;
        String nom;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public Filiere(int id, string nom)
        {
            Id = id;
            Nom = nom;
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
