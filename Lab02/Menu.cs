using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            FrmBai1 frmBai1 = new FrmBai1();
            frmBai1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBai2 frmBai2 = new FrmBai2();
            frmBai2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bài_3 bai3 = new Bài_3();
            bai3.ShowDialog();
        }
    }
}
