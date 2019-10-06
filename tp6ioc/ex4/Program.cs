using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterSingleton<IDAO, DAO>();
            Metier metier = unityContainer.Resolve<Metier>();
            Console.WriteLine(metier.Traitement());
        }
    }
}
