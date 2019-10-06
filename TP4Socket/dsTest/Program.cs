using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Int32? x = new Int32();
            x = null;

            Personne p = new Personne();
            p.Nom = "tayaa";

            Gen<Personne> gen = new Gen<Personne>();

            //Personne p1 = gen.Renvoyer(1);*/

            Dictionary<int, String> dc = new Dictionary<int, string>();
            dc.Add(1, "test");

            var cle = from i in dc.Values where i == "test" select i;

            Console.WriteLine(cle.);
        }
    }
}
