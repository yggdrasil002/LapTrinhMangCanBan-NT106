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
    public partial class FrmTong : Form
    {
        public FrmTong()
        {
            InitializeComponent();
        }

        //Nút tính tổng có điều kiện
        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(txtNhapso1.Text, out num) == false)
            {
                MessageBox.Show("Vui lòng nhập số nguyên vào ô số thứ nhất");
                txtNhapso1.Clear();
                return;
            }
            if (Int32.TryParse(txtNhapso2.Text, out num) == false)
            {
                MessageBox.Show("Vui lòng nhập số nguyên vào ô số thứ 2");
                txtNhapso2.Clear();
                return;
            }

            //Tinh Tong
            int num1, num2;
            long sum = 0;
            num1 = Int32.Parse(txtNhapso1.Text.Trim());
            num2 = Int32.Parse((txtNhapso2.Text.Trim()));
            sum = num1 + num2;
            txtKetqua.Text = sum.ToString();
        }
        
        //Nút thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
