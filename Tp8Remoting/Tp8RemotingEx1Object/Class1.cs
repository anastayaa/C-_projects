using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8RemotingEx1Object
{
    public class Class1 : MarshalByRefObject, Calculator
    {
        private int x = 0;

        public int Addition(int a, int b)
        {
            Console.WriteLine("Appel client sur Addition(): Nombre1=" + a + ", Nombre2=" + b);
            return a + b;
        }

        public int Incrementation(int valeur)
        {
            Console.WriteLine("Appel client sur Incrementation(): Valeur=" + valeur);
            x += valeur;
            return x;
        }

        public int Multiplication(int a, int b)
        {
            Console.WriteLine("Appel client sur Multiplication(): Nombre1=" + a + ", Nombre2=" + b);
            return a * b;
        }
    }
}
