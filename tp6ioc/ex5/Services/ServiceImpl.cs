using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ex5.Services
{
    public class ServiceImpl : IService
    {
        public string GetValeurInstance()
        {
            return "Bonjour " + GetHashCode();
        }
    }
}