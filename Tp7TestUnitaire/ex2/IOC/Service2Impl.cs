using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ex2.IOC
{
    public class Service2Impl : IService2
    {
        IService1 service1;

        public Service2Impl(IService1 service1)
        {
            this.service1 = service1;
        }

        public int clacule(int cle, int x)
        {
            return x * service1.GetDonne(cle);
        }
    }
}