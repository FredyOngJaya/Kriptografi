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
        ulong P = 0, Q = 0;
        ulong N = 0;
        ulong E = 0;
        ulong[] TN = new ulong[4];
        ulong[] D = new ulong[4];

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
            uint p, q;
            if (uint.TryParse(textBoxP.Text, out p) && uint.TryParse(textBoxQ.Text, out q))
            {
                P = p;
                Q = q;
                if (!Kripto.IsMiller(P, (int)Math.Min(P, (ulong)100)))
                {
                    MessageBox.Show("P bukan prima");
                }
                else if (!Kripto.IsMiller(Q, (int)Math.Min(Q, (ulong)100)))
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

        private bool relatifPrimaD(ulong v)
        {
            bool result = true;
            foreach (ulong t in TN)
            {
                result = result & Kripto.IsRelatifPrima(v, t);
            }
            return result;
        }

        private void buttonRandomE_Click(object sender, EventArgs e)
        {
            ulong max = Math.Max(P, Q) + 1;
            ulong t;
            do
            {
                t = (ulong)(random.NextDouble() * (TN[3] - max - 1)) + max;
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
            if (ulong.TryParse(textBoxE.Text, out E))
            {
                ulong max = Math.Max(P, Q) + 1;
                if (E > TN[3] - 1 || E < max)
                {
                    MessageBox.Show("E antara " + max + " sampai " + (TN[3] - 1));
                }
                else if (relatifPrimaD(E))
                {
                    dataGridViewNotSortAbleEEA.Columns.Add("P1", "P1");
                    dataGridViewNotSortAbleEEA.Rows.Add("P = " + P);
                    dataGridViewNotSortAbleEEA.Rows.Add("Q = " + Q);
                    dataGridViewNotSortAbleEEA.Rows.Add("N = " + N);
                    dataGridViewNotSortAbleEEA.Rows.Add("\u03D5(n)(p+1)(q+1) = " + TN[0]);
                    dataGridViewNotSortAbleEEA.Rows.Add("\u03D5(n)(p+1)(q-1) = " + TN[1]);
                    dataGridViewNotSortAbleEEA.Rows.Add("\u03D5(n)(p-1)(q+1) = " + TN[2]);
                    dataGridViewNotSortAbleEEA.Rows.Add("\u03D5(n)(p-1)(q-1) = " + TN[3]);
                    dataGridViewNotSortAbleEEA.Rows.Add("E = " + E);
                    for (int i = 0; i < TN.Length; i++)
                    {
                        D[i] = Kripto.InversModulo(E, TN[i], dataGridViewNotSortAbleEEA);
                    }
                    dataGridViewNotSortAbleEEA.Rows.Add("D(p+1)(q+1) = " + D[0]);
                    dataGridViewNotSortAbleEEA.Rows.Add("D(p+1)(q-1) = " + D[1]);
                    dataGridViewNotSortAbleEEA.Rows.Add("D(p-1)(q+1) = " + D[2]);
                    dataGridViewNotSortAbleEEA.Rows.Add("D(p-1)(q-1) = " + D[3]);

                    textBoxDPPlusQPlus.Text = D[0].ToString();
                    textBoxDPPlusQMin.Text = D[1].ToString();
                    textBoxDPMinQPlus.Text = D[2].ToString();
                    textBoxDPMinQMin.Text = D[3].ToString();

                    int t = 0;
                    ulong x = N;
                    while (x > 1)
                    {
                        t++;
                        x >>= 1;
                    }
                    numericUpDownBlockSize.Maximum = t;
                    numericUpDownBlockSize.Value = t;
                    buttonEnkripsi.Enabled = true;
                }
                else
                {
                    MessageBox.Show(E + " tidak relatif prima");
                }
            }
            else
            {
                MessageBox.Show("Cek E");
            }
        }

        #endregion

        List<ulong> cipherList = new List<ulong>();
        int blokSize;

        private ulong Lucas(ulong value, ulong key, ulong N, DataGridViewNotSortAble grid, bool printProcess)
        {
            if (key == 0) return 2;
            if (key == 1) return value;
            ulong a0 = 2;
            ulong a1 = value;
            long a2;
            if (printProcess)
            {
                grid.Rows.Add("V[0](" + value + ",1) = 2");
                grid.Rows.Add("V[1](" + value + ",1) = " + value);
            }
            for (ulong i = 2; i <= key; i++)
            {
                a2 = (long)(Kripto.MultiplyModulo(value, a1, N) - a0);
                if (a2 < 0)
                    a2 += (long)N;
                if (printProcess)
                {
                    grid.Rows.Add();
                    grid.Rows.Add("V[" + i + "](" + value + ",1) = (P * V[" + (i - 1) + "](" + value + ",1) - V[" + (i - 2) + "](" + value + ",1)) mod " + N);
                    grid.Rows.Add("V[" + i + "](" + value + ",1) = (" + value + " * " + a1 + " - " + a0 + ") mod " + N);
                    grid.Rows.Add("V[" + i + "](" + value + ",1) = " + a2);
                }
                a0 = a1;
                a1 = (ulong)a2;
            }
            return a1;
        }

        #region "Tab Enkrip"

        private void ClearEnkrip()
        {
            dataGridViewProsesEnkripsi.Rows.Clear();
            buttonDekripsi.Enabled = false;
            cipherList.Clear();
            ClearDekrip();
        }

        private void buttonEnkripsi_Click(object sender, EventArgs e)
        {
            ClearEnkrip();
            blokSize = (int)numericUpDownBlockSize.Value;
            string text = textBoxEnkripsiPlainText.Text;
            string now;
            StringBuilder plainBiner = new StringBuilder();
            foreach (char c in text)
            {
                plainBiner.Append(((int)c).ToBin(8));
            }
            dataGridViewProsesEnkripsi.Rows.Add("Plaintext : " + text);
            dataGridViewProsesEnkripsi.Rows.Add("Ukuran Blok = " + blokSize);
            dataGridViewProsesEnkripsi.Rows.Add();
            dataGridViewProsesEnkripsi.Rows.Add("Plaintext Biner : " + plainBiner.ToString());
            dataGridViewProsesEnkripsi.Rows.Add("C = V[e](P,1) mod N");
            dataGridViewProsesEnkripsi.Rows.Add("V[0](P,1) = 2; V[1](P,1) = P");
            dataGridViewProsesEnkripsi.Rows.Add("V[e](P,1) = (((P mod N).V[e-1](P,1) mod N) - V[e-2](P,1) mod N) mod N");
            int i = 1;
            while (plainBiner.Length > 0)
            {
                dataGridViewProsesEnkripsi.Rows.Add();
                if (plainBiner.Length < blokSize)
                {
                    now = plainBiner.ToString().PadRight(blokSize, '0');
                    dataGridViewProsesEnkripsi.Rows.Add("P" + i + " = " + plainBiner.ToString());
                    dataGridViewProsesEnkripsi.Rows.Add("Tambah " + (blokSize - plainBiner.Length) + " bit 0 di belakang supaya sesuai ukuran blok");
                }
                else
                {
                    now = plainBiner.ToString(0, blokSize);
                }
                plainBiner.Remove(0, Math.Min(blokSize, plainBiner.Length));
                ulong t = now.BinToUlong();
                dataGridViewProsesEnkripsi.Rows.Add("P" + i + " = " + now + " = " + t);
                ulong c = Lucas(t, E, N, dataGridViewProsesEnkripsi, checkBoxShowEnkripsiDetail.Checked);
                cipherList.Add(c);
                dataGridViewProsesEnkripsi.Rows.Add("C" + i++ +  " = V[" + E + "](" + t + ",1) mod " + N + " = " + c);
            }
            buttonDekripsi.Enabled = true;
        }

        #endregion

        #region "Tab Dekrip"

        private void ClearDekrip()
        {
            dataGridViewProsesDekripsi.Rows.Clear();
            textBoxDekripsiPlainText.Clear();
        }

        private void buttonDekripsi_Click(object sender, EventArgs e)
        {
            ClearDekrip();
            StringBuilder[] plainBiner = new StringBuilder[4];
            string now = "";
            for (int i = 0; i < plainBiner.Length; i++)
            {
                plainBiner[i] = new StringBuilder();
            }
            dataGridViewProsesDekripsi.Rows.Add("P = V[d](C,1) mod N");
            for (int iD = 0; iD < D.Length; iD++)
            {
                dataGridViewProsesDekripsi.Rows.Add();
                dataGridViewProsesDekripsi.Rows.Add("Untuk D  = " + D[iD]);
                for (int i = 0; i < cipherList.Count; i++)
                {
                    ulong c = cipherList[i];
                    dataGridViewProsesDekripsi.Rows.Add();
                    dataGridViewProsesDekripsi.Rows.Add("C" + (i + 1) + " = " + c);
                    ulong m = Lucas(c, D[iD], N, dataGridViewProsesDekripsi, checkBoxShowDekripsiDetail.Checked);
                    now = m.ToBin(blokSize);
                    plainBiner[iD].Append(now);
                    dataGridViewProsesDekripsi.Rows.Add("P" + (i + 1) + " = V[" + D[iD] + "](" + c + ",1) mod " + N + " = " + m);
                    dataGridViewProsesDekripsi.Rows.Add("P" + (i + 1) + " = " + now);
                }
            }
            for (int i = 0; i < D.Length; i++)
            {
                dataGridViewProsesDekripsi.Rows.Add();
                dataGridViewProsesDekripsi.Rows.Add("Dengan D = " + D[i] + " plaintext Biner : " + plainBiner[i].ToString());
                StringBuilder plainText = new StringBuilder();
                while (plainBiner[i].Length > 0)
                {
                    now = plainBiner[i].ToString(0, Math.Min(8, plainBiner[i].Length));
                    ulong t = now.BinToUlong();
                    if (t == 0)
                    {
                        dataGridViewProsesDekripsi.Rows.Add(plainBiner[i].ToString() + " = bit yang ditambahkan");
                        break;
                    }
                    else
                    {
                        dataGridViewProsesDekripsi.Rows.Add(now + " = " + t + " = " + (char)t);
                        plainText.Append((char)t);
                    }
                    plainBiner[i].Remove(0, Math.Min(8, plainBiner[i].Length));
                }
                dataGridViewProsesDekripsi.Rows.Add("Dengan D = " + D[i] + " plaintext = " + plainText.ToString());
            }
        }

        #endregion
    }
}
