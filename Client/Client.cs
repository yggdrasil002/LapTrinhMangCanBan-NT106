using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        //Bien cuc bo

        Socket socket;
        IPEndPoint ep;
        EndPoint epFrom;
        Thread thread;

        private void btnSend_Click(object sender, EventArgs e)
        {
            Send();
        }
        private void Send()
        {
            byte[] msg = Serialize("Client : " + txtMessage.Text);
            socket.SendTo(msg, ep);
            AddMessage("Client : " + txtMessage.Text);
            txtMessage.Clear();
        }
        private void btnReceive_Click(object sender, EventArgs e)
        {
            thread = new Thread(Receive);
            thread.IsBackground = true;
            thread.Start();
        }
        private void Receive()
        {
            epFrom = new IPEndPoint(IPAddress.Parse("192.168.1.12"), 22000);
            socket.Bind(epFrom);
            while (true)
                {
                    byte[] data = new byte[4096];
                    socket.ReceiveFrom(data,ref epFrom);
                    string msg = (string)Deserialize(data);
                    AddMessage(msg);
                }
        
        }
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
        private void Client_Load(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ep = new IPEndPoint(IPAddress.Parse("192.168.1.12"), 11100);
            
        }
        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            socket.Close();
        }
    }
}
