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
    public partial class FormLUC : Form
    {
        Random random;
        long P = 0, Q = 0;
        long N = 0, TN = 0;
        long D = 0, E = 0;

        public FormLUC()
        {
            InitializeComponent();
            //labelTotienN.Text = "\u03A6\u03C6\u03D5\u0278(n)";
            labelTotienN.Text = "\u03D5(n)";
            dataGridViewProsesEnkripsi.Columns.Add("P1", "P1");
            dataGridViewProsesDekripsi.Columns.Add("P1", "P1");
        }

        private void FormRSA_Load(object sender, EventArgs e)
        {
            random = new Random(DateTime.Now.Millisecond);
            buttonRandomE.Enabled = false;
            buttonHitungD.Enabled = false;
            buttonEnkripsi.Enabled = false;
        }

        #region "Tab Key"

        private void buttonHitungN_Click(object sender, EventArgs e)
        {
            textBoxE.Clear();
            textBoxD.Clear();
            if (long.TryParse(textBoxP.Text, out P) && long.TryParse(textBoxQ.Text, out Q))
            {
                if (!Kripto.IsMiller(P, (int)Math.Min(P, (long)100)))
                {
                    MessageBox.Show("P bukan prima");
                }
                else if (!Kripto.IsMiller(Q, (int)Math.Min(Q, (long)100)))
                {
                    MessageBox.Show("Q bukan prima");
                }
                else
                {
                    N = P * Q;
                    TN = (P - 1) * (Q - 1);
                    textBoxN.Text = N.ToString();
                    textBoxTotientN.Text = TN.ToString();
                    buttonRandomE.Enabled = true;
                    buttonHitungD.Enabled = true;
                    return;
                }
            }
            else
            {
                MessageBox.Show("Cek p dan q");
            }
            textBoxN.Clear();
            textBoxTotientN.Clear();
            buttonRandomE.Enabled = false;
            buttonHitungD.Enabled = false;
        }

        private void buttonRandomE_Click(object sender, EventArgs e)
        {
            long max = Math.Max(P, Q) + 1;
            long t;
            do
            {
                t = (long)(random.NextDouble() * (N - max)) + max;
            } while (!Kripto.IsRelatifPrima(t, TN));
            textBoxE.Text = t.ToString();
        }

        private void buttonHitungD_Click(object sender, EventArgs e)
        {
            if (long.TryParse(textBoxE.Text, out E))
            {
                if (Kripto.IsRelatifPrima(E, TN))
                {
                    D = Kripto.InversModulo(E, TN);
                    textBoxD.Text = D.ToString();
                    buttonEnkripsi.Enabled = true;
                    int t = 0;
                    long x = N;
                    while (x > 1)
                    {
                        t++;
                        x >>= 1;
                    }
                    numericUpDownBlockSize.Maximum = t;
                    return;
                }
                else
                {
                    MessageBox.Show(E + " dan " + TN + " tidak relatif prima");
                }
            }
            else
            {
                MessageBox.Show("Cek E");
            }
            textBoxD.Clear();
            buttonEnkripsi.Enabled = false;
        }

        #endregion

        List<long> cipherList = new List<long>();
        int blokSize;

        private long Lucas(long P, long e, long N, DataGridViewNotSortAble grid)
        {
            if (e == 0) return 2;
            if (e == 1) return P;
            long a0 = 2;
            long a1 = P;
            long a2;
            grid.Rows.Add("V[0](" + P + ",1) = 2");
            grid.Rows.Add("V[1](" + P + ",1) = " + P);
            for (long i = 2; i <= e; i++)
            {
                a2 = Kripto.MultiplyModulo(P, a1, N) - a0;
                if (a2 < 0)
                    a2 += N;
                grid.Rows.Add();
                grid.Rows.Add("V[" + i + "](" + P + ",1) = (P * V[" + (i - 1) + "](" + P + ",1) - V[" + (i - 2) + "](" + P + ",1) mod " + N);
                grid.Rows.Add("V[" + i + "](" + P + ",1) = (" + P + " * " + a1 + " - " + a0 + ") mod " + N);
                grid.Rows.Add("V[" + i + "](" + P + ",1) = " + a2);
                a0 = a1;
                a1 = a2;
            }
            return a1;
        }

        #region "Tab Enkrip"

        private void buttonEnkripsi_Click(object sender, EventArgs e)
        {
            dataGridViewProsesEnkripsi.Rows.Clear();
            string text = textBoxEnkripsiPlainText.Text;
            blokSize = (int)numericUpDownBlockSize.Value;
            string now;
            StringBuilder plainBiner = new StringBuilder();
            foreach (char c in text)
            {
                plainBiner.Append(((int)c).ToBin(8));
            }
            dataGridViewProsesEnkripsi.Rows.Add("Plaintext Biner : " + plainBiner.ToString());
            cipherList.Clear();
            int i = 1;
            while (plainBiner.Length > 0)
            {
                now = plainBiner.ToString(0, Math.Min(blokSize, plainBiner.Length));
                plainBiner.Remove(0, Math.Min(blokSize, plainBiner.Length));
                int t = now.BinToInt();
                dataGridViewProsesEnkripsi.Rows.Add();
                dataGridViewProsesEnkripsi.Rows.Add(now + " = " + t);
                long c = Lucas(t, E, N, dataGridViewProsesEnkripsi);
                cipherList.Add(c);
                dataGridViewProsesEnkripsi.Rows.Add("C" + i++ +  " = V[" + E + "](" + t + ",1) mod " + N + " = " + c);
            }
        }

        #endregion

        #region "Tab Enkrip"

        private void buttonDekripsi_Click(object sender, EventArgs e)
        {
            dataGridViewProsesDekripsi.Rows.Clear();
            int i = 1;
            StringBuilder plainBiner = new StringBuilder();
            foreach (long c in cipherList)
            {
                long m = Lucas(c, D, N, dataGridViewProsesDekripsi);
                plainBiner.Append(m.ToBin(blokSize));
                dataGridViewProsesDekripsi.Rows.Add("C" + i++ + " = V[" + D + "](" + c + ",1) mod " + N + " = " + m);
                dataGridViewProsesDekripsi.Rows.Add();
            }
            dataGridViewProsesDekripsi.Rows.Add("Plaintext Biner : " + plainBiner.ToString());
            StringBuilder plainText = new StringBuilder();
            string now;
            while (plainBiner.Length > 0)
            {
                now = plainBiner.ToString(0, Math.Min(8, plainBiner.Length));
                plainBiner.Remove(0, Math.Min(8, plainBiner.Length));
                int t = now.BinToInt();
                plainText.Append((char)t);
            }
            textBoxDekripsiPlainText.Text = plainText.ToString();
        }

        #endregion
    }
}
