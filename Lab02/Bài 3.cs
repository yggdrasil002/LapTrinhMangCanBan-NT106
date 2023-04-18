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

        private void PushArray(string[] a, int i)
        {
            string temp;
            while (i < a.Length)
            {
                temp = (a[i+1]);
                a[i+1] = a[i];
                a[i] = temp;
                i++;
            }
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
            Read(sr, lineCount);
            fs.Close();
            sr.Close();
        }
        private void Read (StreamReader sr, int lineCount)
        {
            string line = null;
            string[] number = null;
            string deOperators = " +-*/";
            string[] operators = null;
            string deNumber = "0123456789 ";
            for (int i = 0; i < lineCount; i++)
            {
                line = sr.ReadLine();
                line.Trim();
                number = line.Split(deOperators.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                operators = line.Split(deNumber.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                int result = int.Parse(number[0]);
                int temp = 0;

                while (temp < operators.Length)
                {
                    for (int j = 0; j < operators.Length; j++)
                    {
                        if (operators[j] == "*" && operators[j] == "/")
                            switch (operators[j])
                            {
                                case "*":
                                    result = int.Parse(number[j]) * int.Parse(number[j + 1]);
                                    number[j] = result.ToString();
                                    PushArray(number, j + 1);
                                    PushArray(operators, j);
                                    break;
                                case "/":
                                    result = int.Parse(number[j]) * int.Parse(number[j + 1]);
                                    number[j] = result.ToString();
                                    PushArray(number, j + 1);
                                    PushArray(operators, j);
                                    break;
                            }
                    }
                    temp++;
                }
                for (int k = 0; k < number.Length; k++)
                    MessageBox.Show(number[k]);
                break;
            }
            
            sr.Close();
        }
        private void XuLyNgoac()
        {

        }
    }
}
