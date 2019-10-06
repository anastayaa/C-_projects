using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismePersonne
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne[] P = new Personne[8];
            P[0] = new Employe("NOM1", "PRENOM1", new DateTime(1985, 3, 4), 9000);
            P[1] = new Employe("NOM2", "PRENOM2", new DateTime(1984, 3, 4), 10000);
            P[2] = new Employe("NOM3", "PRENOM3", new DateTime(1983, 3, 4), 8000);
            P[3] = new Employe("NOM4", "PRENOM4", new DateTime(1982, 3, 4), 11000);
            P[4] = new Employe("NOM5", "PRENOM5", new DateTime(1981, 3, 4), 7000);
            P[5] = new Chef("NOM6", "PRENOM6", new DateTime(1988, 7, 6), 9000, "SERVICE1");
            P[6] = new Chef("NOM7", "PRENOM7", new DateTime(1984, 7, 6), 9000, "SERVICE2");
            P[7] = new Directeur("NOM8", "PRENOM8", new DateTime(1988, 7, 6), 9000, "SERVICE3", "SOCIETE1");

            for (int i = 0; i < P.Length; i++)
            {
                //Appel d'une méthode polymorphique (qui prend une nouvelle forme dans les classes dérivées)
                P[i].Afficher();  
                Console.Out.WriteLine("");
            }

            foreach (Personne p in P)
            {
                p.Afficher();
                Console.Out.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
