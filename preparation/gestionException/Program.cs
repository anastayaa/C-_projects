using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionException
{

    class Program
    {
        public static void saisieEntier()
        {
            try
            {
                Console.WriteLine("Entrer un entier");
                int entier = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(entier);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Une erreur est produite");
                Console.WriteLine(ex.Message);
            }
        }

        public static void saisieEntierDO()
        {
            int entier;
            bool isError = false;
            do
            {
                try
                {
                    isError = false;
                    Console.WriteLine("Entrer un entier");
                    entier = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(entier);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Une erreur est produite");
                    Console.WriteLine(ex.Message);
                    isError = true;
                }
            }
            while (isError);
        }

        public static void saisieDateNaissance()
        {
            try
            {
                Console.WriteLine("Entrer votre date de naissance");
                DateTime dateNaissance = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine(dateNaissance);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid date");
                Console.WriteLine(ex.Message);
            }
        }

        public static void dateDepartArrive()
        {
            try
            {
                Console.WriteLine("Entrer la date de depart");
                DateTime dateDepart = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Entrer la date d'arrive");
                DateTime dateArrive = Convert.ToDateTime(Console.ReadLine());

                if (dateDepart > dateArrive)
                {
                    throw new Exception(">");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid date");
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            Eleve eleve = new Eleve("TAYAA", 17, 20);
            Console.WriteLine(eleve);
        }
    }
}
