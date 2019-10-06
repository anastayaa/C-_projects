using ex4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
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
