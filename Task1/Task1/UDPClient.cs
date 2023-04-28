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

namespace Task1
{
    public partial class UDPClient : Form
    {
        public UDPClient()
        {
            InitializeComponent();
        }

        Socket socket;
        IPEndPoint ep;
        private void btnSend_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            int port;
            if (CheckIP(out ip) == 0) return;
            if (CheckPort(out port) == 0) return;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ep = new IPEndPoint(ip, port);

            byte[] msg = Serialize(txbSend.Text);
            socket.SendTo(msg, ep);
            txbSend.Clear();
        }
        private int CheckIP(out IPAddress ip)
        {
            IPAddress IPA;
            if (IPAddress.TryParse(txbIP.Text, out IPA) == false)
            {
                MessageBox.Show("Vui lòng nhập ip vào ô IP Address");
                txbIP.Clear();
                ip = null;
                return 0;
            }
            ip = IPAddress.Parse(txbIP.Text);
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
    }
}
