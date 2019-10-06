using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDAO dao = new DAO();
            IMetier metier = new Metier(dao);
            Console.WriteLine(metier.Traitement());
        }
    }
}
