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
        ulong P = 0, Q = 0;
        ulong N = 0;

        public FormRabin()
        {
            InitializeComponent();
            dataGridViewNotSortAbleEEA.Columns.Add("P1", "P1");
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
            dataGridViewNotSortAbleEEA.Rows.Clear();
            textBoxEnkripsiPlainText.Clear();
            ClearEnkrip();
        }

        private void buttonHitungN_Click(object sender, EventArgs e)
        {
            ClearKey();
            uint p, q;
            if (uint.TryParse(textBoxP.Text, out p) && uint.TryParse(textBoxQ.Text, out q))
            {
                P = p;
                Q = q;
                if (!Kripto.IsMiller(P, (int)Math.Min(P, (ulong)100)))
                {
                    MessageBox.Show("P bukan prima");
                }
                else if ((P + 1) % 4 != 0)
                {
                    MessageBox.Show("P + 1 tidak habis dibagi 4");
                }
                else if (!Kripto.IsMiller(Q, (int)Math.Min(Q, (ulong)100)))
                {
                    MessageBox.Show("Q bukan prima");
                }
                else if ((Q + 1) % 4 != 0)
                {
                    MessageBox.Show("Q + 1 tidak habis dibagi 4");
                }
                else
                {
                    dataGridViewNotSortAbleEEA.Rows.Add("P = " + P);
                    dataGridViewNotSortAbleEEA.Rows.Add("Q = " + Q);
                    N = P * Q;
                    dataGridViewNotSortAbleEEA.Rows.Add("N = " + N);
                    textBoxN.Text = N.ToString();
                    buttonEnkripsi.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Cek p dan q");
            }
        }

        List<ulong> cipher = new List<ulong>();

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
            dataGridViewProsesEnkripsi.Rows.Add("Plaintext : " + text);
            dataGridViewProsesEnkripsi.Rows.Add("M = MM");
            dataGridViewProsesEnkripsi.Rows.Add("C = M ^ 2 mod N");
            foreach (char c in text)
            {
                dataGridViewProsesEnkripsi.Rows.Add();
                int now = (int)c;
                string binary = now.ToBin(8);
                int duaKali = (now << 8) + now;
                ulong res = Kripto.MultiplyModulo((ulong)duaKali, (ulong)duaKali, N);
                cipher.Add(res);
                dataGridViewProsesEnkripsi.Rows.Add(c + " = " + now + " = " + binary);
                now = dataGridViewProsesEnkripsi.RowCount;
                dataGridViewProsesEnkripsi.Rows.Add("M" + i + " = " + binary + " " + binary + " = " + duaKali);
                if ((ulong)duaKali > N)
                {
                    dataGridViewProsesEnkripsi[0, now].Style.BackColor = Color.Red;
                    dataGridViewProsesEnkripsi.Rows.Add("Pesan lebih besar dari N(" + duaKali + ">" + N + "), silakan cari prima lain jika ingin mengenkripsi pesan ini");
                    return;
                }
                dataGridViewProsesEnkripsi.Rows.Add("C" + i + " = (" + duaKali + ")^2 mod " + N + " = " + res);
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
            dataGridViewProsesDekripsi.Rows.Add("a = P^-1 mod Q");
            dataGridViewProsesDekripsi.Rows.Add("b = Q^-1 mod P");
            dataGridViewProsesDekripsi.Rows.Add("r = c ^ ((P+1)/4) mod P");
            dataGridViewProsesDekripsi.Rows.Add("s = c ^ ((Q+1)/4) mod Q");
            dataGridViewProsesDekripsi.Rows.Add("x = (a * P * s + b * Q * r) mod N");
            dataGridViewProsesDekripsi.Rows.Add("y = (a * P * s - b * Q * r) mod N");
            dataGridViewProsesDekripsi.Rows.Add("M1 = x");
            dataGridViewProsesDekripsi.Rows.Add("M2 = N - x");
            dataGridViewProsesDekripsi.Rows.Add("M1 = y");
            dataGridViewProsesDekripsi.Rows.Add("M2 = N - y");
            dataGridViewProsesDekripsi.Rows.Add();
            ulong a = Kripto.InversModulo(P, Q, dataGridViewProsesDekripsi);
            ulong b = Kripto.InversModulo(Q, P, dataGridViewProsesDekripsi);
            dataGridViewProsesDekripsi.Rows.Add("a = " + P + "^-1 mod " + Q + " = " + a);
            dataGridViewProsesDekripsi.Rows.Add("b = " + Q + "^-1 mod " + P + " = " + b);
            int i = 1;
            ulong[] arr = new ulong[4];
            List<ulong> m = new List<ulong>();
            StringBuilder plaintext = new StringBuilder();
            ulong p4 = (P + 1) / 4;
            ulong q4 = (Q + 1) / 4;
            foreach (ulong c in cipher)
            {
                ulong r = Kripto.QuickModulo(c, p4, P);
                ulong s = Kripto.QuickModulo(c, q4, Q);
                ulong left = Kripto.MultiplyModulo(Kripto.MultiplyModulo(a, P, N), s, N);
                ulong right = Kripto.MultiplyModulo(Kripto.MultiplyModulo(b, Q, N), r, N);
                ulong x = (left + right) % N;
                ulong y;
                if (right > left)
                {
                    y = N - right + left;
                }
                else
                {
                    y = (Kripto.MultiplyModulo(Kripto.MultiplyModulo(a, P, N), s, N) - Kripto.MultiplyModulo(Kripto.MultiplyModulo(b, Q, N), r, N)) % N;
                }
                arr[0] = x;
                arr[1] = N - x;
                arr[2] = y;
                arr[3] = N - y;
                dataGridViewProsesDekripsi.Rows.Add();
                dataGridViewProsesDekripsi.Rows.Add("r" + i + " = " + c + " ^ ((" + P + "+1)/4) mod " + P + " = " + r);
                dataGridViewProsesDekripsi.Rows.Add("s" + i + " = " + c + " ^ ((" + Q + "+1)/4) mod " + Q + " = " + s);
                dataGridViewProsesDekripsi.Rows.Add("x" + i + " = (" + a + " * " + P + " * " + s + " + " + b + " * " + Q + " * " + r + ") mod " + N + " = " + x);
                dataGridViewProsesDekripsi.Rows.Add("y" + i + " = (" + a + " * " + P + " * " + s + " - " + b + " * " + Q + " * " + r + ") mod " + N + " = " + y);
                int idx = dataGridViewProsesDekripsi.RowCount;
                for (int j = 0; j < 4; j++)
                {
                    ulong t = arr[j];
                    dataGridViewProsesDekripsi.Rows.Add("M" + (j + 1) + " = " + arr[j] + " = " + arr[j].ToBin(16));
                    if (((t >> 8) & ((1 << 8) - 1)) == (t & ((1 << 8) - 1)))
                    {
                        m.Add(t);
                        dataGridViewProsesDekripsi[0, idx + j].Style.BackColor = Color.LimeGreen;
                    }
                }
                i++;
            }
            dataGridViewProsesDekripsi.Rows.Add();
            i = 1;
            foreach (ulong t in m)
            {
                dataGridViewProsesDekripsi.Rows.Add("M" + i + " = " + t + " = " + t.ToBin(16));
                dataGridViewProsesDekripsi.Rows.Add("M" + i++ + " = " + (t >> 8).ToBin(8) + " = " + (t >> 8) + " = " + (char)(t >> 8));
                plaintext.Append((char)(t >> 8));
            }
            textBoxDekripsiPlainText.Text = plaintext.ToString();
        }
    }
}
