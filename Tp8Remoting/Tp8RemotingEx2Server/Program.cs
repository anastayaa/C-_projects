using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Tp8RemotingEx2Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(8085);
            ChannelServices.RegisterChannel(channel);

            //RemotingConfiguration.RegisterWellKnownServiceType(typeof(Tp8RemotingEx2Jeu.Class1), "jeu", WellKnownObjectMode.SingleCall);
            RemotingConfiguration.RegisterActivatedServiceType(typeof(Tp8RemotingEx2Jeu.Class1));
            Console.WriteLine("Demarrage du serveur");
            Console.ReadKey();
        }
    }
}
