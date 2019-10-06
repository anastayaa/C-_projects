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

namespace Calculator
{
    public partial class Form1 : Form
    {
        /**
         * La socket client serveur
         **/
        Socket socket;
        EndPoint epLocal, epRemote;

        /**
         * Les delegates
         **/
        public delegate void AddMessage(String message);
        AddMessage addMessageDelegat;

        byte[] buffer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /**
             * La socket client serveur
             **/
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            ipTextBox.Text = GetHostIP();
        }

        public String GetHostIP()
        {
            IPHostEntry hosts = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in hosts.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "127.0.0.1";
        }

        private void conectButton_Click(object sender, EventArgs e)
        {
            try
            {
                /**
                * Binding socket
                **/
                epLocal = new IPEndPoint(IPAddress.Parse(ipTextBox.Text), Convert.ToInt32(portTextBox.Text));
                socket.Bind(epLocal);

                /**
                 * Connecting to remote Ip
                 * */
                epRemote = new IPEndPoint(IPAddress.Parse(ipTextBox.Text), Convert.ToInt32(portTextBox.Text));
                socket.Connect(epRemote);

                buffer = new byte[1024];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MessageCallBack(IAsyncResult asResult)
        {
            try
            {
                byte[] receivedData = new byte[1024];
                receivedData = (byte[])asResult.AsyncState;

                /**
                 * Coverting byte to string
                 * */
                ASCIIEncoding asc = new ASCIIEncoding();
                String receivedMessage = asc.GetString(receivedData);

                /**
                 * parametres: une methode qui modifie le textBox
                 **/
                addMessageDelegat = new AddMessage(addMessageListBox);
                Object[] messageObject = { receivedMessage };
                resultsListBox.Invoke(addMessageDelegat, messageObject);

                buffer = new byte[1024];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculButton_Click(object sender, EventArgs e)
        {
            try
            {
                /**
                * Convert string message to byte
                **/
                String message;
                String op1 = op1TextBox.Text;
                String op2 = op2TextBox.Text;
                String operation = operationTetBox.Text;
                message = op1 + " " + operation + " " + op2;

                ASCIIEncoding asc = new ASCIIEncoding();
                byte[] sendingMessage = new byte[1024];
                sendingMessage = asc.GetBytes(message);

                /**
                 * Sending the encoded message
                 **/
                socket.Send(sendingMessage);

                /**
                 * parametres: une methode qui modifie le textBox
                 **/
                addMessageDelegat = new AddMessage(addMessageListBox);
                Object[] messageObject = { message };
                //resultsListBox.Invoke(addMessageDelegat, messageObject);

                op1TextBox.Text = "";
                op2TextBox.Text = "";
                operationTetBox.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addMessageListBox(String message)
        {
            resultsListBox.Items.Add(message);
        }

    }
}
