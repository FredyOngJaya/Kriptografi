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
        long N = 0;
        long E = 0;
        long[] TN = new long[4];
        long[] D = new long[4];

        public FormLUC()
        {
            InitializeComponent();
            labelTotientNPPlusQPlus.Text = "\u03D5(n)(p+1)(q+1)";
            labelTotientNPPlusQMin.Text = "\u03D5(n)(p+1)(q-1)";
            labelTotientNPMinQPlus.Text = "\u03D5(n)(p-1)(q+1)";
            labelTotientNPMinQMin.Text = "\u03D5(n)(p-1)(q-1)";
            dataGridViewProsesEnkripsi.Columns.Add("P1", "P1");
            dataGridViewProsesDekripsi.Columns.Add("P1", "P1");
            buttonRandomE.Enabled = false;
            buttonHitungD.Enabled = false;
            buttonEnkripsi.Enabled = false;
            buttonDekripsi.Enabled = false;
        }

        private void FormRSA_Load(object sender, EventArgs e)
        {
            random = new Random(DateTime.Now.Millisecond);
        }

        #region "Tab Key"

        private void buttonHitungN_Click(object sender, EventArgs e)
        {
            textBoxE.Clear();
            textBoxDPMinQMin.Clear();
            textBoxN.Clear();
            textBoxTotientNPPlusQPlus.Clear();
            buttonRandomE.Enabled = false;
            buttonHitungD.Enabled = false;
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
                    TN[0] = (P + 1) * (Q + 1);
                    TN[1] = (P + 1) * (Q - 1);
                    TN[2] = (P - 1) * (Q + 1);
                    TN[3] = (P - 1) * (Q - 1);
                    textBoxN.Text = N.ToString();
                    textBoxTotientNPPlusQPlus.Text = TN[0].ToString();
                    textBoxTotientNPPlusQMin.Text = TN[1].ToString();
                    textBoxTotientNPMinQPlus.Text = TN[2].ToString();
                    textBoxTotientNPMinQMin.Text = TN[3].ToString();
                    buttonRandomE.Enabled = true;
                    buttonHitungD.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Cek p dan q");
            }
        }

        private bool relatifPrimaD(long v)
        {
            bool result = true;
            foreach (long t in TN)
            {
                result = result & Kripto.IsRelatifPrima(v, t);
            }
            return result;
        }

        private void buttonRandomE_Click(object sender, EventArgs e)
        {
            long max = Math.Max(P, Q) + 1;
            long t;
            do
            {
                t = (long)(random.NextDouble() * (N - max)) + max;
            } while (!relatifPrimaD(t));
            textBoxE.Text = t.ToString();
        }

        private void ClearKey()
        {
            textBoxDPPlusQPlus.Clear();
            textBoxDPPlusQMin.Clear();
            textBoxDPMinQPlus.Clear();
            textBoxDPMinQMin.Clear();
            buttonEnkripsi.Enabled = false;
            dataGridViewNotSortAbleEEA.Rows.Clear();
            dataGridViewNotSortAbleEEA.Columns.Clear();
            textBoxEnkripsiPlainText.Clear();
            ClearEnkrip();
        }

        private void buttonHitungD_Click(object sender, EventArgs e)
        {
            ClearKey();
            if (long.TryParse(textBoxE.Text, out E))
            {
                if (relatifPrimaD(E))
                {
                    for (int i = 0; i < TN.Length; i++)
                    {
                        D[i] = Kripto.InversModulo(E, TN[i], dataGridViewNotSortAbleEEA);
                    }

                    textBoxDPPlusQPlus.Text = D[0].ToString();
                    textBoxDPPlusQMin.Text = D[1].ToString();
                    textBoxDPMinQPlus.Text = D[2].ToString();
                    textBoxDPMinQMin.Text = D[3].ToString();

                    buttonEnkripsi.Enabled = true;
                    int t = 0;
                    long x = N;
                    while (x > 1)
                    {
                        t++;
                        x >>= 1;
                    }
                    numericUpDownBlockSize.Maximum = t;
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
        }

        #endregion

        List<long> cipherList = new List<long>();
        int blokSize;

        private long Lucas(long value, long key, long N, DataGridViewNotSortAble grid, bool printProcess)
        {
            if (key == 0) return 2;
            if (key == 1) return value;
            long a0 = 2;
            long a1 = value;
            long a2;
            if (printProcess)
            {
                grid.Rows.Add("V[0](" + value + ",1) = 2");
                grid.Rows.Add("V[1](" + value + ",1) = " + value);
            }
            for (long i = 2; i <= key; i++)
            {
                a2 = Kripto.MultiplyModulo(value, a1, N) - a0;
                if (a2 < 0)
                    a2 += N;
                if (printProcess)
                {
                    grid.Rows.Add();
                    grid.Rows.Add("V[" + i + "](" + value + ",1) = (P * V[" + (i - 1) + "](" + value + ",1) - V[" + (i - 2) + "](" + value + ",1)) mod " + N);
                    grid.Rows.Add("V[" + i + "](" + value + ",1) = (" + value + " * " + a1 + " - " + a0 + ") mod " + N);
                    grid.Rows.Add("V[" + i + "](" + value + ",1) = " + a2);
                }
                a0 = a1;
                a1 = a2;
            }
            return a1;
        }

        #region "Tab Enkrip"

        private void ClearEnkrip()
        {
            dataGridViewProsesEnkripsi.Rows.Clear();
            buttonDekripsi.Enabled = false;
            ClearDekrip();
        }

        private void buttonEnkripsi_Click(object sender, EventArgs e)
        {
            ClearEnkrip();
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
                long c = Lucas(t, E, N, dataGridViewProsesEnkripsi, checkBoxShowEnkripsiDetail.Checked);
                cipherList.Add(c);
                dataGridViewProsesEnkripsi.Rows.Add("C" + i++ +  " = V[" + E + "](" + t + ",1) mod " + N + " = " + c);
            }
            buttonDekripsi.Enabled = true;
        }

        #endregion

        #region "Tab Enkrip"

        private void ClearDekrip()
        {
            dataGridViewProsesDekripsi.Rows.Clear();
            textBoxDekripsiPlainText.Clear();
        }

        private void buttonDekripsi_Click(object sender, EventArgs e)
        {
            ClearDekrip();
            StringBuilder[] plainBiner = new StringBuilder[4];
            for (int i = 0; i < plainBiner.Length; i++)
            {
                plainBiner[i] = new StringBuilder();
            }
            int last = 8 - (((cipherList.Count - 1) * blokSize) % 8);
            for (int iD = 0; iD < D.Length; iD++)
            {
                dataGridViewProsesDekripsi.Rows.Add("D  = " + D[iD]);
                for (int i = 0; i < cipherList.Count; i++)
                {
                    long c = cipherList[i];
                    long m = Lucas(c, D[iD], N, dataGridViewProsesDekripsi, checkBoxShowDekripsiDetail.Checked);
                    if (i == cipherList.Count - 1)
                    {
                        plainBiner[iD].Append(m.ToBin(last));
                    }
                    else
                    {
                        plainBiner[iD].Append(m.ToBin(blokSize));
                    }
                    dataGridViewProsesDekripsi.Rows.Add("C" + (i + 1) + " = " + c);
                    dataGridViewProsesDekripsi.Rows.Add("M" + (i + 1) + " = V[" + D[iD] + "](" + c + ",1) mod " + N + " = " + m);
                    dataGridViewProsesDekripsi.Rows.Add();
                }
            }
            for (int i = 0; i < D.Length; i++)
            {
                StringBuilder plainText = new StringBuilder();
                string now;
                while (plainBiner[i].Length > 0)
                {
                    now = plainBiner[i].ToString(0, Math.Min(8, plainBiner[i].Length));
                    plainBiner[i].Remove(0, Math.Min(8, plainBiner[i].Length));
                    int t = now.BinToInt();
                    plainText.Append((char)t);
                }
                dataGridViewProsesDekripsi.Rows.Add("Dengan D = " + D[i] + " plaintext = " + plainText.ToString());
            }
        }

        #endregion
    }
}
