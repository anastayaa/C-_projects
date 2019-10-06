using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace remoting
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
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(CalculatorImpl), "calculator", WellKnownObjectMode.Singleton);
        }
    }
}
