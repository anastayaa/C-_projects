using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionException
{
    class Eleve
    {
        String nom;
        int age;
        double moyenne;

        public Eleve(String nom, int age, double moyenne)
        {
            Nom = nom;
            Age = age;
            Moyenne = moyenne;
        }

        public String Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value>=18 && value<=26)
                {
                    age = value;
                }
                else
                {
                    throw new InvalidAgeException("L’âge doit être entre 18 et 26");
                }
            }
        }

        public double Moyenne
        {
            get
            {
                return moyenne;
            }
            set
            {
                if(value>=0 && value <= 20)
                {
                    moyenne = value;
                }
                else
                {
                    throw new InvalidNoteException("La note doit être entre 0 et 20");
                }
            }
        }

        public override String ToString()
        {
            return this.Nom + " " + this.Age + " " + this.Moyenne;
        }
    }
}
