using ex2.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Tests.IOC
{
    class Mock : IService1
    {
        public bool isCalled = false;

        public int GetDonne(int cle)
        {
            isCalled = true;
            return 1;
        }
    }
}
