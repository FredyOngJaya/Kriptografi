﻿using System;
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
    public partial class FormRSA : Form
    {
        Random random;
        long P = 0, Q = 0;
        long N = 0, TN = 0;
        long D = 0, E = 0;

        public FormRSA()
        {
            InitializeComponent();
            labelTotienN.Text = "\u03D5(n)";
            dataGridViewProsesEnkripsi.Columns.Add("P1", "P1");
            dataGridViewProsesDekripsi.Columns.Add("P1", "P1");
            buttonRandomD.Enabled = false;
            buttonHitungE.Enabled = false;
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
            textBoxD.Clear();
            textBoxE.Clear();
            textBoxN.Clear();
            textBoxTotientN.Clear();
            buttonRandomD.Enabled = false;
            buttonHitungE.Enabled = false;
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
                    buttonRandomD.Enabled = true;
                    buttonHitungE.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Cek p dan q");
            }
        }

        private void buttonRandomD_Click(object sender, EventArgs e)
        {
            long max = Math.Max(P, Q) + 1;
            long t;
            do
            {
                t = (long)(random.NextDouble() * (N - max)) + max;
            } while (!Kripto.IsRelatifPrima(t, TN));
            textBoxD.Text = t.ToString();
        }

        private void ClearKey()
        {
            textBoxE.Clear();
            dataGridViewNotSortAbleEEA.Rows.Clear();
            dataGridViewNotSortAbleEEA.Columns.Clear();
            textBoxEnkripsiPlainText.Clear();
            ClearEnkrip();
        }

        private void buttonHitungE_Click(object sender, EventArgs e)
        {
            ClearKey();
            if (long.TryParse(textBoxD.Text, out D))
            {
                if (Kripto.IsRelatifPrima(D, TN))
                {
                    //E = Kripto.InversModulo(D, TN);
                    E = Kripto.InversModulo(D, TN, dataGridViewNotSortAbleEEA);
                    textBoxE.Text = E.ToString();
                    int t = 0;
                    long x = N;
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
                    MessageBox.Show(D + " dan " + TN + " tidak relatif prima");
                }
            }
            else
            {
                MessageBox.Show("Cek D");
            }
        }

        #endregion

        List<long> cipher = new List<long>();
        int blokSize;

        #region "Tab Enkrip"

        private void ClearEnkrip()
        {
            dataGridViewProsesEnkripsi.Rows.Clear();
            buttonDekripsi.Enabled = false;
            cipher.Clear();
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
            dataGridViewProsesEnkripsi.Rows.Add("Plaintext Biner : " + plainBiner.ToString());
            int i = 1;
            while (plainBiner.Length > 0)
            {
                now = plainBiner.ToString(0, Math.Min(blokSize, plainBiner.Length));
                plainBiner.Remove(0, Math.Min(blokSize, plainBiner.Length));
                int t = now.BinToInt();
                dataGridViewProsesEnkripsi.Rows.Add();
                dataGridViewProsesEnkripsi.Rows.Add(now + " = " + t);
                long c = 0;
                if (checkBoxShowEnkripsiDetail.Checked)
                {
                    c = Kripto.FastExponent(t, E, N, dataGridViewProsesEnkripsi);
                }
                else
                {
                    c = Kripto.QuickModulo(t, E, N);
                }
                cipher.Add(c);
                dataGridViewProsesEnkripsi.Rows.Add("C" + i++ + " = " + t + " ^ " + E + " mod " + N + " = " + c);
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
            StringBuilder plainBiner = new StringBuilder();
            int last = 8 - (((cipher.Count - 1) * blokSize) % 8);
            for (int i = 0; i < cipher.Count; i++)
            {
                long c = cipher[i];
                long m = 0;
                if (checkBoxShowDekripsiDetail.Checked)
                {
                    m = Kripto.FastExponent(c, D, N, dataGridViewProsesDekripsi);
                }
                else
                {
                    m = Kripto.QuickModulo(c, D, N);
                }
                if (i == cipher.Count - 1)
                {
                    plainBiner.Append(m.ToBin(last));
                }
                else
                {
                    plainBiner.Append(m.ToBin(blokSize));
                }
                dataGridViewProsesDekripsi.Rows.Add("M" + (i + 1) + " = " + c + " ^ " + D + " mod " + N + " = " + m);
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
