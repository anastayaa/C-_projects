using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsTest
{
    class Gen<T> where T: class, IComparable
    {
        public T[] tab;

        public static int n = 10;

        public void add(T t)
        {
            for(int i=0; i<tab.Length; i++)
            {
                if (tab[i] != null)
                {

                    tab[i] = t; break;
                }
                else
                {
                
                }
            }
        }

        public T Renvoyer(int i)
        {
            if(i>=0 && i < tab.Length)
            {
                return tab[i];
            }
            return null;
        }

    }
}
