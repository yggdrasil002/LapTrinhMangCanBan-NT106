using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Bài_4 : Form
    {
        private class SinhVien
        {
            private String HoVaTen { set; get; }
            private int MSSV { set; get; }
            private String DienThoai { set; get; }
            private float DiemMon1 { set; get; }
            private float DiemMon2 { set; get; }
            private float DiemMon3 { set; get; }
            private float DiemTB { set; get; }
        }
        public Bài_4()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.CreateNew);
            StreamWriter sr = new StreamWriter(fs);
        }
    }
}
