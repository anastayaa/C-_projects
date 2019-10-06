using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ex2.IOC
{
    public class Service1Impl : IService1
    {
        private static Dictionary<int, int> dict = new Dictionary<int, int> { { 1, 2 }, { 3, 4 } };

        public int GetDonne(int cle)
        {
            return dict.ContainsKey(cle) ? dict[cle] : 1;
        }
    }
}