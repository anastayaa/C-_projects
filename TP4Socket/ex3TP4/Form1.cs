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
using System.IO;

namespace ex3TP4
{
    public partial class Form1 : Form
    {
        Socket socket;
        EndPoint epLocal, epRemote;

        byte[] buffer;

        /**
         * Delegate pour l'enregistrement de donnees
         **/
        public delegate void AddMessageDelegate(String s);
        public AddMessageDelegate messageDelegate;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            IPTextBoxSender.Text = GetHostIP();
            IPTextBoxReceiver.Text = GetHostIP();
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


        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                /**
                * Binding socket
                **/
                epLocal = new IPEndPoint(IPAddress.Parse(IPTextBoxSender.Text), Convert.ToInt32(PortTextBoxSender.Text));
                socket.Bind(epLocal);

                /**
                 * Connecting to remote Ip
                 * */
                epRemote = new IPEndPoint(IPAddress.Parse(IPTextBoxReceiver.Text), Convert.ToInt32(portTextBoxReceiver.Text));
                socket.Connect(epRemote);

                buffer = new byte[1024];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                /**
                * Convert string message to byte
                **/
                ASCIIEncoding asc = new ASCIIEncoding();
                byte[] sendingMessage = new byte[1024];
                sendingMessage = asc.GetBytes(messageTextBox.Text);

                /**
                 * Sending the encoded message
                 **/
                socket.Send(sendingMessage);

                messageDelegate = new AddMessageDelegate(AddMessageSenderListBox);
                Object[] messageObject = { messageTextBox.Text };
                messagesListBox.Invoke(messageDelegate, messageObject);
                messageTextBox.Text = "";
            }
            catch(Exception ex)
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
                messageDelegate = new AddMessageDelegate(AddMessageReceiverListBox);
                Object[] messageObject = { receivedMessage };
                messagesReceiverListBox.Invoke(messageDelegate, messageObject);

                buffer = new byte[1024];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*
         * OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                //pictureBox1.BackgroundImage = BackgroundImage.
                MessageBox.Show(op.FileName);
                pictureBox1.Image = Image.FromFile(op.FileName);

                FileStream fs = new FileStream(op.FileName, FileMode.Open,FileAccess.Read);
                byte[] bytesToSend = new byte[fs.Length];

                   * */
        public void AddMessageReceiverListBox(String message)
        {
            messagesReceiverListBox.Items.Add("Ami: " + message);
        }

        public void AddMessageSenderListBox(String message)
        {
            messagesListBox.Items.Add("Me: " + message);
        }

    }
}
