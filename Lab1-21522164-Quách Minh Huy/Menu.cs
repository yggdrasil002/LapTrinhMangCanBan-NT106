using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_21522164_Quách_Minh_Huy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            FrmTong frm2 = new FrmTong();
            frm2.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            FrmMaxMin frm3 = new FrmMaxMin();
            frm3.ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            FrmDoc frm4 = new FrmDoc();
            frm4.ShowDialog();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            FrmDoiTien frm5 = new FrmDoiTien();
            frm5.ShowDialog();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            FrmBai5 frm6 = new FrmBai5();
            frm6.ShowDialog();
        }
    }
}
