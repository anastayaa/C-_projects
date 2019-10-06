using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCM
{
    class MyClass
    {
        public static int nb;

        static MyClass()
        {
            nb = 10;
            Console.WriteLine("test");
        }
        /*public MyClass()
        {
            Console.WriteLine("test2");
        }*/
        public MyClass(int x)
        {
            Console.WriteLine("test2");
        }
    }
}
