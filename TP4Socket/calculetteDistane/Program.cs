using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace calculetteDistane
{
    class Program
    {
        static Socket socket, socketClient;
        static IPEndPoint ep;
        static void Main(string[] args)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888));
            socket.Listen(100);

            while (true)
            {
                Console.WriteLine("Waiting for client connection");

                socketClient = socket.Accept();
                Thread t = new Thread(Traitement);
                t.Start();
            }

        }

        public static void Traitement()
        {
            while (true)
            {
                try
                {
                    byte[] buf2 = new byte[50];
                    socketClient.Receive(buf2);
                    String msg = ASCIIEncoding.Default.GetString(buf2);

                    double op1 = Convert.ToDouble(msg);

                    double resultat= op1* op1;

                    Console.WriteLine(resultat);

                    byte[] buf = ASCIIEncoding.Default.GetBytes(resultat + "");
                    socketClient.Send(buf);
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    //socketClient.Close();
                    //break;
                    byte[] buf = ASCIIEncoding.Default.GetBytes(ex.Message);
                    socketClient.Send(buf);
                    
                }
            }
        }

    }
}
