using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace calculetteDistanceClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void op1Button_Click(object sender, EventArgs e)
        {
            chaineOperation.Text += op1Button.Text;
        }

        private void op2Button_Click(object sender, EventArgs e)
        {
            chaineOperation.Text += op2Button.Text;
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            chaineOperation.Text += mulButton.Text;
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            chaineOperation.Text += plusButton.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*try
            {
                //Socket socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //socketClient.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888));
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        public void sendAndReceive()
        {
           /* do
            {
                String message = chaineOperation.Text;
                if (message != "")
                {
                    byte[] buf = ASCIIEncoding.Default.GetBytes(message);
                    socketClient.Send(buf);

                    byte[] buf2 = new byte[50];
                    socketClient.Receive(buf2);
                    String msg = ASCIIEncoding.Default.GetString(buf2);

                    chaineOperation.Text = msg;
                }

            }
            while (true);
            */
        }

    }
}
