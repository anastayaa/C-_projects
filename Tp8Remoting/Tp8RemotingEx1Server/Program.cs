using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Tp8RemotingEx1Server
{
    class Program
    {
        static void Main(string[] args)
        {
            
            TcpChannel channel = new TcpChannel(8085);
            ChannelServices.RegisterChannel(channel);

            /*
             * mode activation singleton ou singcall
             */
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(Tp8RemotingEx1Object.Class1), "calculator", WellKnownObjectMode.Singleton);

            /*
             * mode activation par le client
             */
            //RemotingConfiguration.RegisterActivatedServiceType(typeof(Tp8RemotingEx1Object.Class1));
            
            /*
             * A travers un fichier de configuration
             */
            //RemotingConfiguration.Configure(@"..\..\Tp8RemotingEx1Server.config", false);

            Console.WriteLine("Demarrage du serveur");
            Console.ReadKey();
        }
    }
}
