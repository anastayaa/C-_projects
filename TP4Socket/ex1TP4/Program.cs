using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex1TP4
{
    class Program
    {
        static Socket socket, socketClient;

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
                    if (socketClient.Connected)
                    {
                        byte[] buf2 = new byte[50];
                        socketClient.Receive(buf2);
                        String msg = ASCIIEncoding.Default.GetString(buf2);

                        double op1 = Convert.ToDouble(msg.Split(' ')[0]);// 1
                        double op2 = Convert.ToDouble(msg.Split(' ')[1]);// 2
                        String operation = msg.Split(' ')[2].Substring(0, 1);/// +************************

                        double resultat;
                        switch (operation)
                        {
                            case "+":
                                resultat = op1 + op2; break;
                            case "-":
                                resultat = op1 - op2; break;
                            case "*":
                                resultat = op1 * op2; break;
                            case "/":
                                resultat = op1 / op2; break;
                            default:
                                resultat = 0; break;
                        }

                        byte[] buf = ASCIIEncoding.Default.GetBytes(resultat + "");
                        socketClient.Send(buf);
                    }
                }
                catch(Exception ex)
                {
                    if (socketClient.Connected) {
                        byte[] buf = ASCIIEncoding.Default.GetBytes(ex.Message);
                        socketClient.Send(buf);
                    }
                }
            }         
        }
    }
}
