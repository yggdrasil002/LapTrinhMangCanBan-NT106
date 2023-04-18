using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class FrmBai2 : Form
    {
        public FrmBai2()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            rtbRead.Text = sr.ReadToEnd();
            txtName.Text = ofd.SafeFileName.ToString();
            txtSize.Text = fs.Length.ToString();
            txtURL.Text = fs.Name;
            txtLineCount.Text = rtbRead.Lines.Count().ToString();
            txtCharacter.Text = rtbRead.TextLength.ToString();

            sr.BaseStream.Position = 0;
            sr.DiscardBufferedData();

            int counter = 0;
            string line = null;
            string delim = " ,.";
            string[] fields = null;

            while (sr.Read() >= 0)
            {
                line = sr.ReadLine();
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter += fields.Length;
            }
            txtWordsCount.Text = counter.ToString();

            sr.Close();
            fs.Close();
        }

        object Line(StreamReader sr)
        {
            int linecount = 0;
            while (sr.ReadLine() != null)
            {
                linecount++;
            }
            return linecount;
        }

    }
}
