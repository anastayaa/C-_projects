using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace ex3servicewcf
{
    public class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/FiliereService");
            ServiceHost host = new ServiceHost(typeof(FiliereService));

            // Open the ServiceHost.
            host.Open();

            Console.WriteLine("The service is ready at {0}", baseAddress);
            Console.WriteLine("Press <Enter> to stop the service.");
            Console.ReadLine();

            // Close the ServiceHost.
            host.Close();
        }
    }
}