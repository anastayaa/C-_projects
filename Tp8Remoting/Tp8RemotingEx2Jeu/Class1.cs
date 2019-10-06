using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8RemotingEx2Jeu
{
    public class Class1 : MarshalByRefObject
    {
        private int i;
        private int nbTentatives=0;

        public Class1()
        {
            Random random = new Random();
            i = random.Next(1, 10);
        }

        public String Jouer(int x)
        {
            Console.WriteLine("Le nombre entre par l'utilisateur A " + x);
            Console.WriteLine("Le nombre genere par l'utilisateur B " + i);

            nbTentatives=getNbTentatives()+1;

            if (getNbTentatives() <= 4)
            {
                if (x > i)
                {
                    Console.WriteLine("Plus grand");
                    return "Plus grand";
                }
                else if (x < i)
                {
                    Console.WriteLine("Plus petit");
                    return "Plus petit";
                }
                else
                {
                    Console.WriteLine("Gagne");
                    this.nbTentatives = 0;
                    return "Gagne";
                }
            }
            else
            {
                this.nbTentatives = 0;
                return "Nombre tentatives depase, essayez a nouveau";
            }
        }

        public int getNbTentatives()
        {
            return nbTentatives;
        }

        public int score()
        {
            if (getNbTentatives() <= 4)
            {
                return 10 - getNbTentatives();
            }
            else
            {
                return 0;
            }
        }
    }
}
