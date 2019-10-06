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

namespace calculetteClient
{
    public partial class Form1 : Form
    {
        Socket socketClient;

        public delegate void SetResponseDelegate(String response);
        public SetResponseDelegate setResponseDelegate;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void SetResponse(String response)
        {
            operaionEffectuer.Items.Add(response);
        }

        public void SetReponsePlusEleve(String response)
        {
            resultatEleveichBox.Text = response;
        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socketClient.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888));
        }

        private void calculerButton_Click(object sender, EventArgs e)
        {
            String message = nombreTextBox.Text;
            if (message != "")
            {
                byte[] buf = ASCIIEncoding.Default.GetBytes(message);
                socketClient.Send(buf);

                byte[] buf2 = new byte[50];
                socketClient.Receive(buf2);
                String msg = ASCIIEncoding.Default.GetString(buf2);

                setResponseDelegate = new SetResponseDelegate(SetResponse);
                object[] obj = { msg };
                operaionEffectuer.Invoke(setResponseDelegate, obj);

            }
        }
    }
}
