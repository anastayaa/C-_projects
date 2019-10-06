using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Metier : IMetier
    {
        IDAO dAO;

        public Metier(IDAO dAO)
        {
            this.dAO = dAO;
        }

        public int Traitement()
        {
            return dAO.GetData() * 3;
        }
    }
}
