using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ServeurUDP
{
    class Program
    {
        static UdpClient listener;
        static IPEndPoint groupEP;

        private static void StartListener()
        {

            listener = new UdpClient(11000);
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            groupEP = new IPEndPoint(ip, 11000);

            try
            {
                
            Console.WriteLine("Waiting for broadcast");
            Thread thread = new Thread(sendReceive);
            thread.Start();

                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                listener.Close();
            }
        }

        public static void sendReceive()
        {
            byte[] bytes = listener.Receive(ref groupEP);

            String message = Encoding.ASCII.GetString(bytes, 0, bytes.Length);
            Console.WriteLine("Received broadcast from {0} :\n {1}\n",groupEP.ToString(), message);

            String reponse = message.Trim().ToUpper();

            listener.Send(ASCIIEncoding.Default.GetBytes(reponse), ASCIIEncoding.Default.GetBytes(reponse).Length, groupEP);

        }


        public static void Main(String[] args)
        {
            StartListener();

        }
    }
}
