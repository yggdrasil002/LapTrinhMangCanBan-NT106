using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class DashBroad : Form
    {
        public DashBroad()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            UDPClient uDPClient = new UDPClient();
            uDPClient.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            UDPServer uUDPServer = new UDPServer();
            uUDPServer.Show();
        }
    }
}
