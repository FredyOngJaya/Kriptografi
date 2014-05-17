using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Kripto = Kriptografi.KriptografiLibrary;
using KriptografiExtensions;

namespace Kriptografi.Week4
{
    public partial class FormChineseRemainderTheorem : Form
    {
        public FormChineseRemainderTheorem()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (Kripto.IsNumber(textBoxNumber.Text) && Kripto.IsNumber(textBoxDivisor.Text))
            {
                int num = Convert.ToInt32(textBoxNumber.Text);
                int div = Convert.ToInt32(textBoxDivisor.Text);
                if (div == 0)
                {
                    MessageBox.Show("Divisor shouldn't equals 0");
                }
                else if (num == 0)
                {
                    MessageBox.Show("Number shouldn't equals 0");
                }
                else if (num == div)
                {
                    MessageBox.Show("Number shouldn't equals divisor");
                }
                else
                {
                    if (num > div)
                    {
                        num %= div;
                    }
                    if (num < 0)
                    {
                        num += (num / div - 1) * -div;
                    }
                    dataGridViewCRT.Rows.Add(new object[] { "X =", num, "mod", div });
                    textBoxNumber.Clear();
                    textBoxDivisor.Clear();
                }
            }
            else
            {
                MessageBox.Show("Input Number");
            }
        }

        private void buttonHitungCRT_Click(object sender, EventArgs e)
        {
            if (dataGridViewCRT.RowCount > 0)
            {
                long a = Convert.ToInt32(dataGridViewCRT["number", 0].Value);
                long b = Convert.ToInt32(dataGridViewCRT["divisor", 0].Value);
                long lcm = b;
                for (int i = 1; i < dataGridViewCRT.RowCount; i++)
                {
                    DataGridViewRow row = dataGridViewCRT.Rows[i];
                    long num = Convert.ToInt64(row.Cells["number"].Value);
                    long div = Convert.ToInt64(row.Cells["divisor"].Value);
                    lcm = Kripto.LCM(lcm, div);
                    long x = num - a;
                    long inv = Kripto.InversModulo(b, div);
                    x *= inv;
                    x %= div;
                    a += b * x;
                    b *= div;
                }
                if (a < 0)
                    a += lcm;
                textBox1.Text = "Hasil = " + a;
                /*
                int n = dataGridViewCRT.RowCount;
                long[] arrNum = new long[n];
                long[] arrDiv = new long[n];
                for (int i = 0; i < n; i++)
                {
                    arrNum[i] = Convert.ToInt32(dataGridViewCRT["number", i].Value);
                    arrDiv[i] = Convert.ToInt32(dataGridViewCRT["divisor", i].Value);
                }
                textBox1.Text += " " + Kripto.ChineseRemainderTheorem(arrNum, arrDiv);
                //*/
            }
            else
            {
                textBox1.Clear();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (dataGridViewCRT.SelectedRows.Count > 0)
            {
                dataGridViewCRT.Rows.Remove(dataGridViewCRT.SelectedRows[0]);
            }
        }
    }
}
