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

namespace Task1
{
    public partial class UDPServer : Form
    {
        public UDPServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        UdpClient listener;
        IPEndPoint GroupEP;
        Thread thread;
        private void btnListen_Click(object sender, EventArgs e)
        {
            int port;
            if (CheckPort(out port) == 0) return;
            listener = new UdpClient(port);
            GroupEP = new IPEndPoint(IPAddress.Any, port);

            thread = new Thread(Receive);
            thread.IsBackground = true;
            thread.Start();
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
    }
}
