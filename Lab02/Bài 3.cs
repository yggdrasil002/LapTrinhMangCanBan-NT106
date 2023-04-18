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
    public partial class Bài_3 : Form
    {
        public Bài_3()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            int lineCount = 0;
            while (sr.ReadLine() != null)
            {
                lineCount++;
            }

            sr.BaseStream.Position = 0;
            sr.DiscardBufferedData();

            string line = null;
            string[] text = null;
            string delim = "";
            for (int i = 0; i < lineCount; i++)
            {
                line = sr.ReadLine();
                line.Trim();
                text = line.Split(null);
                for (int j = 0; j < text.Length; j++)
                    MessageBox.Show(text[j]);
                
            }
            fs.Close();
            sr.Close();
            
        }
    }
}
