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

namespace Kriptografi.Week8
{
    public partial class FormRabin : Form
    {
        long P = 0, Q = 0;
        long N = 0;

        public FormRabin()
        {
            InitializeComponent();
            dataGridViewProsesEnkripsi.Columns.Add("P1", "P1");
            dataGridViewProsesDekripsi.Columns.Add("P1", "P1");
            buttonEnkripsi.Enabled = false;
            buttonDekripsi.Enabled = false;
        }

        private void FormRabin_Load(object sender, EventArgs e)
        {
        }

        private void ClearKey()
        {
            textBoxN.Clear();
            buttonEnkripsi.Enabled = false;
            textBoxEnkripsiPlainText.Clear();
            ClearEnkrip();
        }

        private void buttonHitungN_Click(object sender, EventArgs e)
        {
            ClearKey();
            if (long.TryParse(textBoxP.Text, out P) && long.TryParse(textBoxQ.Text, out Q))
            {
                if (!Kripto.IsMiller(P, (int)Math.Min(P, (long)100)))
                {
                    MessageBox.Show("P bukan prima");
                }
                else if ((P + 1) % 4 != 0)
                {
                    MessageBox.Show("P + 1 tidak habis dibagi 4");
                }
                else if (!Kripto.IsMiller(Q, (int)Math.Min(Q, (long)100)))
                {
                    MessageBox.Show("Q bukan prima");
                }
                else if ((Q + 1) % 4 != 0)
                {
                    MessageBox.Show("Q + 1 tidak habis dibagi 4");
                }
                else
                {
                    N = P * Q;
                    textBoxN.Text = N.ToString();
                    buttonEnkripsi.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Cek p dan q");
            }
        }

        List<long> cipher = new List<long>();

        private void ClearEnkrip()
        {
            dataGridViewProsesEnkripsi.Rows.Clear();
            cipher.Clear();
            buttonDekripsi.Enabled = false;
            ClearDekrip();
        }

        private void buttonEnkripsi_Click(object sender, EventArgs e)
        {
            ClearEnkrip();
            string text = textBoxEnkripsiPlainText.Text;
            int i = 1;
            foreach (char c in text)
            {
                int now = (int)c;
                string binary = now.ToBin();
                int duaKali = (now << 8) + now;
                long res = Kripto.MultiplyModulo(duaKali, duaKali, N);
                cipher.Add(res);
                dataGridViewProsesEnkripsi.Rows.Add(c + " = " + now + " = " + binary);
                dataGridViewProsesEnkripsi.Rows.Add("M" + i + " = " + binary + " " + binary + " = " + duaKali);
                dataGridViewProsesEnkripsi.Rows.Add("C" + i + " = (" + duaKali + ")^2 mod " + N + " = " + res);
                dataGridViewProsesEnkripsi.Rows.Add();
                i++;
            }
            buttonDekripsi.Enabled = true;
        }

        private void ClearDekrip()
        {
            dataGridViewProsesDekripsi.Rows.Clear();
            textBoxDekripsiPlainText.Clear();
        }

        private void buttonDekripsi_Click(object sender, EventArgs e)
        {
            ClearDekrip();
            long a = Kripto.InversModulo(P, Q);
            long b = Kripto.InversModulo(Q, P);
            dataGridViewProsesDekripsi.Rows.Add("a = " + P + "^-1 mod " + P + " = " + a);
            dataGridViewProsesDekripsi.Rows.Add("b = " + Q + "^-1 mod " + Q + " = " + b);
            int i = 1;
            long[] arr = new long[4];
            List<long> m = new List<long>();
            StringBuilder plaintext = new StringBuilder();
            foreach (long c in cipher)
            {
                long r = Kripto.QuickModulo(c, (P + 1) / 4, P);
                long s = Kripto.QuickModulo(c, (Q + 1) / 4, Q);
                long x = (Kripto.MultiplyModulo(Kripto.MultiplyModulo(a, P, N), s, N) + Kripto.MultiplyModulo(Kripto.MultiplyModulo(b, Q, N), r, N)) % N;
                long y = (Kripto.MultiplyModulo(Kripto.MultiplyModulo(a, P, N), s, N) - Kripto.MultiplyModulo(Kripto.MultiplyModulo(b, Q, N), r, N)) % N;
                if (y < 0)
                    y += N;
                arr[0] = x;
                arr[1] = y;
                arr[2] = N - x;
                arr[3] = N - y;
                dataGridViewProsesDekripsi.Rows.Add();
                dataGridViewProsesDekripsi.Rows.Add("r" + i + " = " + c + " ^ ((" + P + "+1)/4) mod " + P + " = " + r);
                dataGridViewProsesDekripsi.Rows.Add("s" + i + " = " + c + " ^ ((" + Q + "+1)/4) mod " + Q + " = " + s);
                int idx = dataGridViewProsesDekripsi.RowCount;
                dataGridViewProsesDekripsi.Rows.Add("x" + i + " = (" + a + " * " + P + " * " + s + " + " + b + " * " + Q + " * " + r + ") mod " + N + " = " + x);
                dataGridViewProsesDekripsi.Rows.Add("y" + i + " = (" + a + " * " + P + " * " + s + " - " + b + " * " + Q + " * " + r + ") mod " + N + " = " + y);
                dataGridViewProsesDekripsi.Rows.Add("-x" + i + " = " + arr[2]);
                dataGridViewProsesDekripsi.Rows.Add("-y" + i + " = " + arr[3]);
                for (int j = 0; j < 4; j++)
                {
                    long t = arr[j];
                    if (((t >> 8) & ((1 << 8) - 1)) == (t & ((1 << 8) - 1)))
                    {
                        m.Add(t);
                        dataGridViewProsesDekripsi[0, idx + j].Style.BackColor = Color.LimeGreen;
                    }
                }
                i++;
            }
            i = 1;
            foreach (long t in m)
            {
                dataGridViewProsesDekripsi.Rows.Add();
                dataGridViewProsesDekripsi.Rows.Add("M" + i + " = " + t + " = " + t.ToBin(16));
                dataGridViewProsesDekripsi.Rows.Add("M" + i + " = " + (t >> 8).ToBin(8) + " = " + (t >> 8) + " = " + (char)(t >> 8));
                plaintext.Append((char)(t >> 8));
            }
            textBoxDekripsiPlainText.Text = plaintext.ToString();
        }
    }
}
