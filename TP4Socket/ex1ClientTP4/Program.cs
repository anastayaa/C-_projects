using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ex1ClientTP4
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketClient.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888));
            do
            {
                Console.WriteLine("entrer op1 op2 operation, exemple 1 3 +");
                String message = Console.ReadLine();
                if (message.ToString() == "")
                {
                    break;
                }
                else
                {
                    byte[] buf = ASCIIEncoding.Default.GetBytes(message);
                    socketClient.Send(buf);

                    byte[] buf2 = new byte[50];
                    socketClient.Receive(buf2);
                    String msg = ASCIIEncoding.Default.GetString(buf2);

                    Console.WriteLine("resultat de l'operation est " + msg);
                }
            }
            while (true);
            Console.WriteLine("Close");
            socketClient.Close();
        }
    }
}
