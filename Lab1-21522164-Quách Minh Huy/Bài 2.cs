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
    public partial class FrmMaxMin : Form
    {
        public FrmMaxMin()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

            double num = 0;
            if (double.TryParse(txtSo1.Text, out num) == false)
            {
                MessageBox.Show("Vui lòng nhập số");
                txtSo1.Clear();
                return;
            }
            if (double.TryParse(txtSo2.Text, out num) == false)
            {
                MessageBox.Show("Vui lòng nhập số");
                txtSo2.Clear();
                return;
            }
            if (double.TryParse(txtSo3.Text, out num) == false)
            {
                MessageBox.Show("Vui lòng nhập số");
                txtSo3.Clear();
                return;
            }

            //Tim Max Min
            double s1 = double.Parse(txtSo1.Text.Trim());
            double s2 = double.Parse(txtSo2.Text.Trim());
            double s3 = double.Parse(txtSo3.Text.Trim());
            double max = 0, min = 0;
            if (s1 > s2)
                if (s1 > s3)
                {
                    max = s1;
                    if (s2 > s3)
                        min = s3;
                    else
                        min = s2;
                }
                else {
                    max = s3;
                    min = s2;
                }
            else
            {
                if (s2 > s3)
                {
                    max = s2;
                    if(s1 > s3)
                        min = s3;
                    else min = s1;
                }
                else
                {
                    max = s3;
                    min = s1;
                }
            }
            txtMax.Text = max.ToString();
            txtMin.Text = min.ToString();
                
        }

        //Nut xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMax.Clear();
            txtMin.Clear();
            txtSo1.Clear();
            txtSo2.Clear();
            txtSo3.Clear();
        }

        //Nut thoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
