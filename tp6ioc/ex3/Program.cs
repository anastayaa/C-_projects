using ex4;
using ex4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = "E:/C#_projects/tp6ioc/ex3/Config.txt";
            String[] data = System.IO.File.ReadAllLines(path);
            String daoName = data[0];
            String metierName = data[1];
            Type daoType = Type.GetType(daoName);
            Type metierType = Type.GetType(metierName);
            IDAO d = (IDAO) Activator.CreateInstance(daoType);
            IMetier m = (IMetier)Activator.CreateInstance(metierType, d);
            Console.WriteLine(m.Traitement());
        }
    }
}
