using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1Ex2
{
    class GuichetsBanque
    {
        private bool[] tabGuichets;

        public GuichetsBanque(int n)
        {
            tabGuichets = new bool[n];

            for(int i=0; i<tabGuichets.Length; i++)
            {
                tabGuichets[i] = true;
            }
        }

        public int guichetLibre()
        {
            for (int i = 0; i < tabGuichets.Length; i++)
            {
                if (tabGuichets[i] == true)
                    return i;
            }
            Console.WriteLine("Aucun guichet ni disponible");
            return -1;
        }

        public void modifEtat(int num)
        {
            if(num>=0 && num < tabGuichets.Length)
            {
                if(tabGuichets[num] == true)
                {
                    tabGuichets[num] = false;
                }
                else
                {
                    tabGuichets[num] = true;
                }
            }
            else
            {
                Console.WriteLine("Guichet non valide, reprendre la saisie");
            }
        }

        public int nbGuichetLibre()
        {
            int nb =0;
            for (int i = 0; i < tabGuichets.Length; i++)
            {
                if (tabGuichets[i] == true)
                    nb++;
            }
            return nb;
        }
    }
}
