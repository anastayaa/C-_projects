using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientUDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress broadcast = IPAddress.Parse("192.168.1.255");
            IPEndPoint ep = new IPEndPoint(broadcast, 11000);

            do
            {
                Console.WriteLine("entrer un message");
                String m = Console.ReadLine();
                byte[] sendbuf = Encoding.ASCII.GetBytes(m);
                s.SendTo(sendbuf, ep);

                byte[] b = new byte[1024];
                EndPoint x = (EndPoint)ep;
                s.ReceiveFrom(b, ref x);

                String message = Encoding.ASCII.GetString(b);
                Console.WriteLine(message);
            }
            while (true); 
        }
    }
}
