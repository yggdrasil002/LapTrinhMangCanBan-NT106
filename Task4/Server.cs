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
using System.IO.Ports;
using System.Threading;

namespace Task4
{
    public partial class Server : Form
    {
        IPEndPoint ep;
        Socket server;
        List<Socket> Clientlist;

        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        //
        byte[] Serialize(object obj)
        {
            byte[] sendbuffer = Encoding.ASCII.GetBytes(obj.ToString());
            return sendbuffer;
        }
        //
        object Deserialize(byte[] DataDeser)
        {
            string data = Encoding.ASCII.GetString(DataDeser);
            return data;
        }
        //Thêm tin nhắn
        void AddMessage(string s)
        {
            ListViewItem list = new ListViewItem();
            list.Text = s;
            lsvChat.Items.Add(list.Text);
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            Clientlist = new List<Socket>();
            IPAddress ip;
            int port;
            if (CheckIP(out ip) == 0) return;
            if(CheckPort(out port) == 0) return;
            ep = new IPEndPoint(ip, port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(ep);

            Thread listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(10);
                        Socket client = server.Accept();
                        Clientlist.Add(client);

                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    ep = new IPEndPoint(ip, port);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }
        private int CheckIP(out IPAddress ip)
        {
            IPAddress IPA;
            if (IPAddress.TryParse(txbIPAddress.Text, out IPA) == false)
            {
                MessageBox.Show("Vui lòng nhập ip vào ô IP Address");
                txbIPAddress.Clear();
                ip = null;
                return 0;
            }
            ip = IPAddress.Parse(txbIPAddress.Text);
            return 1;
        }
        private int CheckPort(out int port)
        {
            int num;
            if (Int32.TryParse(txbPort.Text, out num) == false)
            {
                MessageBox.Show("Vui lòng nhập Port vào ô Port");
                txbPort.Clear();
                port = 0;
                return 0;
            }
            port = Int32.Parse(txbPort.Text);
            return 1;
        }

        private void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    client.Receive(buffer);

                    string message = (string)Deserialize(buffer);
                    AddMessage(message);
                }
            }
            catch
            {
                Clientlist.Remove(client);
                client.Close();
            }
        }

        private void Send(Socket client)
        {
            if (txbSend.Text != string.Empty)
            {
                client.Send(Serialize("Server: " + txbSend.Text));
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach (Socket item in Clientlist)
            {
                Send(item);
            }
            AddMessage(txbSend.Text);
            txbSend.Clear();
        }
    }
}
