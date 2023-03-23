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
    public partial class FrmDoc : Form
    {
        public FrmDoc()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(txtNhap.Text, out num) == false|| Int32.Parse(txtNhap.Text)>9 || Int32.Parse(txtNhap.Text)<0)
            {
                MessageBox.Show("Mời nhập lại số từ 0 đến 9");
                txtNhap.Clear();
                return;
            }

            // Doc
            switch (Int32.Parse(txtNhap.Text.Trim()))
            {
                case 0: txtKetQua.Text = "Không";
                    return; 
                case 1: txtKetQua.Text = "Một";
                    return;
                case 2:
                    txtKetQua.Text = "Hai";
                    return;
                case 3:
                    txtKetQua.Text = "Ba";
                    return;
                case 4:
                    txtKetQua.Text = "Bốn";
                    return;
                case 5:
                    txtKetQua.Text = "Năm";
                    return;
                case 6:
                    txtKetQua.Text = "Sáu";
                    return;
                case 7:
                    txtKetQua.Text = "Bảy";
                    return;
                case 8:
                    txtKetQua.Text = "Tám";
                    return;
                case 9:
                    txtKetQua.Text = "Chín";
                    return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtKetQua.Clear();
            txtNhap.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
