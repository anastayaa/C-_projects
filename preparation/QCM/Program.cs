using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCM
{
    class Program
    {
        int x=5;
        public Program()
        {
            x = 10;
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine(MyClass.nb);

            //var a = { 1, 2, 3 }; erreur impossible (9

            public const int n=20;*/

            ///var a = new Gen<MyClass>(); (11 erreur de compilation la classe MyClass doit avoir un cons par defaut

            /* (17 Une instance converti en classe CF
            CM cm = new CF();
            cm.Afficher();
            CF cf = (CF) cm;
            cf.Afficher();
            */

            //Console.WriteLine(new Program().x);

            //var a = new int[] { 1, 2 };

            Console.WriteLine(new C1(10).x);
        }
    }
}
