using System;
using System.CodeDom.Compiler;
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
    public partial class FrmDoiTien : Form
    {
        public FrmDoiTien()
        {
            InitializeComponent();
        }

        //class cho combobox
        public class Loai
        {
            public string Ten { get; set; }
            public long TyGia { get; set; }
        }

        //Biến cục bộ
        List<Loai> listitem;
        string temp;

        //Thêm vào dữ liệu cho combobox
        private void FrmDoiTien_Load(object sender, EventArgs e)
        {
            listitem = new List<Loai>()
            {
                new Loai(){Ten = "USD (Đô-la Mỹ)", TyGia = 22772 },
                new Loai() { Ten = "EUR (Euro)", TyGia = 28132 },
                new Loai() { Ten = "GBP (Bảng Anh)", TyGia = 31538 },
                new Loai() { Ten = "SGD (Đô-la Singapore)", TyGia = 17286 },
                new Loai() { Ten = "JPY (Yên Nhật)", TyGia = 214 }
            };
            cboTien.DataSource = listitem;
            cboTien.DisplayMember = "Ten";
        }

        //Giá tiền tương ứng cho Tỷ giá
        private void cboTien_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb != null)
            {
                Loai loaitien = cb.SelectedValue as Loai;
                lbTyGiaThayDoi.Text = loaitien.TyGia.ToString();
                temp = loaitien.TyGia.ToString();
            }
        }

        //Nút chuyển đổi
        private void btnChuyenDoi_Click(object sender, EventArgs e)
        {
            txtXuat.Clear();
            long num = 0;
            if (long.TryParse(txtNhap.Text, out num) == false)
            {
                MessageBox.Show("Mời nhập lại số");
                txtNhap.Clear();
                return;
            }
            long answer;
            answer = long.Parse(txtNhap.Text) * long.Parse(temp);
            txtXuat.Text = answer.ToString();
        }
        
        //Nút thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

