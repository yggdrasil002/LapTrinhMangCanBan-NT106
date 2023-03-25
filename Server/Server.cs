using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        UdpClient listener;
        IPEndPoint GroupEP;
        Thread thread;
        int flag;
        IPEndPoint remotedEP = new IPEndPoint(IPAddress.Parse("192.168.1.12"), 22000);
        EndPoint epFrom = new IPEndPoint(IPAddress.Parse("192.168.1.12"), 22000);
        byte[] Serialize(object obj)
        {
            byte[] sendbuffer = Encoding.ASCII.GetBytes(obj.ToString());
            return sendbuffer;
        }
        object Deserialize(byte[] DataDeser)
        {
            string data = Encoding.ASCII.GetString(DataDeser);
            return data;
        }
        void AddMessage(string s)
        {
            ListViewItem lsv = new ListViewItem();
            lsv.Text = s;
            lsvMessage.Items.Add(lsv.Text);
        }
        private void btnHost_Click(object sender, EventArgs e)
        {
            flag = 1;
            thread = new Thread(Receive);
            thread.IsBackground = true;
            thread.Start();
        }
        void Receive()
        {
            string RData;
            byte[] RByteArray;
            while (true)
            {
                RByteArray = listener.Receive(ref GroupEP);
                RData = (string)Deserialize(RByteArray);
                AddMessage(RData); 
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        { 
            Send();
        }
        private void Send()
        {
            byte[] msg = Serialize("Server: " + txtMessage.Text);
            AddMessage("Server: " + txtMessage.Text);
            txtMessage.Clear();
            listener.Send(msg, msg.Length, remotedEP);
        }
        private void Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            listener.Close();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            listener = new UdpClient(11100);
            GroupEP = new IPEndPoint(IPAddress.Any, 11100);
        }
    }
}
