using ex2.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Tests.IOC
{
    class Stub : IService1
    {
        public int GetDonne(int cle)
        {
            if (cle == 1)
            {
                return 10;
            }
            return 1;
        }
    }
}
