using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsTest
{
    class Personne : IComparable
    {
        public String Nom
        {
            get;set;

        }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
