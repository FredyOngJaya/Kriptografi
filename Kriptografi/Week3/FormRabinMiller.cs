using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Kripto = Kriptografi.KriptografiLibrary;

namespace Kriptografi.Week3
{
    public partial class FormRabinMiller : Form
    {
        public FormRabinMiller()
        {
            InitializeComponent();
        }

        private void buttonTesPrima_Click(object sender, EventArgs e)
        {
            if (ulong.TryParse(textBoxNum.Text, out var num) == false)
            {
                MessageBox.Show("Angka diuji tidak valid (max 64 bit integer (ulong)");
                return;
            }
            if (int.TryParse(txtIterasi.Text, out var iter) == false)
            {
                MessageBox.Show("Iterasi tidak valid");
                return;
            }//999999000001
            if (iter > 1000000)
            {

            }
            bool isPrima = Kripto.IsMiller(num, iter);
            textBoxHasilRabinMiller.Text = "Dengan rabin miller, " + textBoxNum.Text;
            if (isPrima)
            {
                textBoxHasilRabinMiller.Text += " adalah bilangan prima";
            }
            else
            {
                textBoxHasilRabinMiller.Text += " adalah bukan bilangan prima";
            }
        }

        private void FormRabinMiller_Load(object sender, EventArgs e)
        {
            /*
            Kripto.Sieve();
            for (int i = 0; i < 10001; i++)
            {
                bool p = Kripto.TestPrima(i, 10);
                bool p2 = Kripto.IsMiller(i, 20);
                bool p3 = Kripto.isPrima[i];
                //dataGridViewTes.Rows.Add(new object[] { i + " " + p + " " + p2 + " " + p3 + " " + ((p != p3 || p2 != p3) ? "BEDA" : "") });
                if (p != p3 || p2 != p3)
                {
                    //dataGridViewTes.Rows[i].Cells[0].Style.BackColor = Color.Red;
                    MessageBox.Show(i + " " + p + " " + p2 + " " + p3);
                }
            }
            //*/
        }
    }
}
