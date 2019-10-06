using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tp3
{
    public class Program
    {
        /*
        public static void affiche()
        {
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Salut tout le monde");
                Thread.Sleep(2000);
            }
        }

        static void Main(string[] args)
        {
            //ThreadStart delegate= new ThreadStart(affiche);
            //ParameterizedThreadStart delegate= new ParameterizedThreadStart(affiche);

            Thread thread = new Thread(affiche);
            Console.WriteLine("Start");
            thread.Start();
            Console.WriteLine("End");
        }

        public string returnPath()
        {
            string folder = Environment.CurrentDirectory;
            return folder;
        }*/

        // Metod 2
        public static void Affiche(Object obj)
        {
            for (int i=0; i < 5; i++)
            {
                String message = obj as String;
                Console.WriteLine(message);
                Thread.Sleep(2000);
            }
                
        }

        public static void Main(String[] args)
        {
            //ThreadStart threadStart = new ThreadStart(Affiche);
            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(Affiche);
            Thread thread = new Thread(parameterizedThreadStart);
            thread.Start("Salut");
        }
    }
}
