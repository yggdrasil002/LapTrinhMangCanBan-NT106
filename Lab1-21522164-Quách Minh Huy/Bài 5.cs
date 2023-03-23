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
    public partial class FrmBai5 : Form
    {
        public FrmBai5()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(txtNhapA.Text, out num) == false)
            {
                MessageBox.Show("Mời bạn nhập lại số nguyên A");
                txtNhapA.Clear();
                return;
            }
            if (Int32.TryParse(txtNhapB.Text, out num) == false)
            {
                MessageBox.Show("Mời bạn nhập lại số nguyên B");
                txtNhapB.Clear();
                return;
            }
            AGiaiThua();
            BGiaiThua();
            TongS1();
            TongS2();
            LuyThuaS3();
        }

        //A Giai Thua
        private void AGiaiThua()
        {
            int num1 = Int32.Parse(txtNhapA.Text);
            int i1 = num1 - 1;
            while (i1 > 0)
            {
                num1 = num1 * i1;
                i1--;
            }
            //Xuat ket qua
            lbAGiaiThua.Text = "A! = "+num1.ToString();
        }

        //B Giai Thua
        private void BGiaiThua()
        {
            int num2 = Int32.Parse(txtNhapB.Text);
            int i2 = num2 - 1;
            while (i2 > 0)
            {
                num2 = num2 * i2;
                i2--;
            }
            //Xuat ket qua
            lbBGiaiThua.Text = "B! = "+num2.ToString();
        }

        //Tong S1
        private void TongS1()
        {
            int num1 = Int32.Parse(txtNhapA.Text);
            int S1 = 0;
            for (int i = 1; i <= num1; i++)
            {
                S1 = S1 + i;
            }
            //Xuat ket qua
            if(num1 > 5)
                lbTongS1.Text = "S1 = 1 + 2 + 3 + 4 +...+ " + num1.ToString() + " = " + S1.ToString();
            switch (num1)
            {
                case 0: lbTongS1.Text = "S1 = " + S1.ToString(); break;
                case 1: lbTongS1.Text = "S1 = " + S1.ToString(); break;
                case 2: lbTongS1.Text = "S1 = 1 + 2 = " + S1.ToString(); break;
                case 3: lbTongS1.Text = "S1 = 1 + 2 + 3 = " + S1.ToString(); break;
                case 4: lbTongS1.Text = "S1 = 1 + 2 + 3 + 4 = " + S1.ToString(); break;
                case 5: lbTongS1.Text = "S1 = 1 + 2 + 3 + 4 + 5 = " + S1.ToString(); break;
            }
        }

        //Tong S2
        private void TongS2()
        {
            int num2 = Int32.Parse(txtNhapB.Text);
            int S2 = 0;
            for(int i = 1; i <= num2; i++)
            {
                S2 = S2 + i;               
            }
            //Xuat ket qua
            if(num2 > 5)
                lbTongS2.Text = "S2 = 1 + 2 + 3 + 4 +...+ " + num2.ToString() + " = " + S2.ToString();
            switch(num2)
            {
                case 0:lbTongS2.Text = "S2 = " + S2.ToString(); break;
                case 1:lbTongS2.Text = "S2 = " + S2.ToString(); break;
                case 2:lbTongS2.Text = "S2 = 1 + 2 = " + S2.ToString(); break;
                case 3:lbTongS2.Text = "S2 = 1 + 2 + 3 = " + S2.ToString(); break;
                case 4:lbTongS2.Text = "S2 = 1 + 2 + 3 + 4 = " + S2.ToString(); break;
                case 5:lbTongS2.Text = "S2 = 1 + 2 + 3 + 4 + 5 = " + S2.ToString(); break;
            }
        }

        //Luy Thua S3
        private void LuyThuaS3()
        {
            int a = Int32.Parse(txtNhapA.Text);
            int b = Int32.Parse(txtNhapB.Text);
            int s3 = 0;
            for(int i = 1;i <= b; i++)
            {
                s3 = s3 + (int)Math.Pow(a, i);
            }
            //Xuat ket qua
            if(b > 5)
            {
                lbTongS3.Text = "S3 = " + a + "^1 + " + a + "^2 + " + a + "^3 + " + a + "^4 +...+ " + a + "^" + b + 
                " = " + s3.ToString();
            }
            switch (b)
            {
                case 0: lbTongS3.Text = "S3 = " + a + "^0 = 1"; break;
                case 1: lbTongS3.Text = "S3 = " + a + "^1 = " + s3.ToString(); break;
                case 2: lbTongS3.Text = "S3 = " + a + "^1 + " + a + "^2 = " + s3.ToString(); break;
                case 3: lbTongS3.Text = "S3 = " + a + "^1 + " + a + "^2 + " + a + "^3 = " + s3.ToString(); break;
                case 4: lbTongS3.Text = "S3 = " + a + "^1 + " + a + "^2 + " + a + "^3 + " + a + "^4 = " + s3.ToString(); break;
                case 5: lbTongS3.Text = "S3 = " + a + "^1 + " + a + "^2 + " + a + "^3 + " + a + "^4 + " + a + "^5 = "
                        + s3.ToString(); break;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            lbAGiaiThua.Text = "";
            lbBGiaiThua.Text = "";
            lbTongS1.Text = "";
            lbTongS2.Text = "";
            lbTongS3.Text = "";
            txtNhapA.Clear();
            txtNhapB.Clear();   
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
