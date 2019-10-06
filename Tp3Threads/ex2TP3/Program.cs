using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex2TP3
{
    public class Program
    {
        private static object _lock = new object();

        static double _nominateur, _denominateur;

        public static void initialiser()
        {
            lock (_lock)
            {
                Random r = new Random();
                _nominateur = r.Next(1, 20);
                _denominateur = r.Next(1, 20);
            }
        }

        public static void reinisialiser()
        {
            lock (_lock)
            {
                _nominateur = 0;
                _denominateur = 0;
            }
        }

        public static void diviser()
        {
            lock (_lock)
            {
                if (_denominateur == 0)
                {
                    Console.WriteLine("division par 0");
                }
                else
                {
                    Console.WriteLine(_nominateur / _denominateur);
                }
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(initialiser);
            Thread t2 = new Thread(diviser);
            Thread t3 = new Thread(reinisialiser);

            t1.Start();
            t2.Start();
            t3.Start();

            Console.Read();
        }

        public string returnPath()
        {
            string folder = Environment.CurrentDirectory;
            return folder;
        }
    }
}
