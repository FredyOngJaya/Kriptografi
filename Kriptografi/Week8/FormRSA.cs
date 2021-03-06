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
        ulong P = 0, Q = 0;
        ulong N = 0, TN = 0;
        ulong D = 0, E = 0;

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
            ulong max = Math.Max(P, Q) + 1;
            ulong t;
            do
            {
                t = (ulong)(random.NextDouble() * (N - max)) + max;
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
            if (ulong.TryParse(textBoxD.Text, out D))
            {
                ulong max = Math.Max(P, Q) + 1;
                if (D >= TN || D < max)
                {
                    MessageBox.Show("D antara " + max + " sampai " + (TN - 1));
                }
                else if (Kripto.IsRelatifPrima(D, TN))
                {
                    dataGridViewNotSortAbleEEA.Columns.Add("P1", "P1");
                    dataGridViewNotSortAbleEEA.Rows.Add("P = " + P);
                    dataGridViewNotSortAbleEEA.Rows.Add("Q = " + Q);
                    dataGridViewNotSortAbleEEA.Rows.Add("N = " + N);
                    dataGridViewNotSortAbleEEA.Rows.Add("\u03D5(n) = " + TN);
                    dataGridViewNotSortAbleEEA.Rows.Add("D = " + D);
                    E = Kripto.InversModulo(D, TN, dataGridViewNotSortAbleEEA);
                    dataGridViewNotSortAbleEEA.Rows.Add("E = " + E);
                    textBoxE.Text = E.ToString();
                    int t = 0;
                    ulong temp = N;
                    while (temp > 1)
                    {
                        t++;
                        temp >>= 1;
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

        List<ulong> cipher = new List<ulong>();
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
            if (textBoxEnkripsiPlainText.Text.Length == 0)
            {
                MessageBox.Show("Plaintext kosong");
                return;
            }
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
            dataGridViewProsesEnkripsi.Rows.Add("C = M ^ E mod N");
            int i = 1;
            while (plainBiner.Length > 0)
            {
                dataGridViewProsesEnkripsi.Rows.Add();
                if (plainBiner.Length < blokSize)
                {
                    now = plainBiner.ToString().PadRight(blokSize, '0');
                    dataGridViewProsesEnkripsi.Rows.Add("M" + i + " = " + plainBiner.ToString());
                    dataGridViewProsesEnkripsi.Rows.Add("Tambah " + (blokSize - plainBiner.Length) + " bit 0 di belakang supaya sesuai ukuran blok");
                }
                else
                {
                    now = plainBiner.ToString(0, blokSize);
                }
                plainBiner.Remove(0, Math.Min(blokSize, plainBiner.Length));
                ulong t = now.BinToUlong();
                dataGridViewProsesEnkripsi.Rows.Add("M" + i + " = " + now + " = " + t);
                ulong c = 0;
                if (checkBoxShowEnkripsiDetail.Checked)
                {
                    dataGridViewProsesEnkripsi.Rows.Add("C" + i + " = " + t + " ^ " + E + " mod " + N);
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

        #region "Tab Dekrip"

        private void ClearDekrip()
        {
            dataGridViewProsesDekripsi.Rows.Clear();
            textBoxDekripsiPlainText.Clear();
        }

        private void buttonDekripsi_Click(object sender, EventArgs e)
        {
            ClearDekrip();
            StringBuilder plainBiner = new StringBuilder();
            string now = "";
            dataGridViewProsesDekripsi.Rows.Add("M  = C ^ D mod N");
            for (int i = 0; i < cipher.Count; i++)
            {
                ulong c = cipher[i];
                ulong m = 0;
                dataGridViewProsesDekripsi.Rows.Add();
                dataGridViewProsesDekripsi.Rows.Add("C" + (i + 1) + " = " + c);
                if (checkBoxShowDekripsiDetail.Checked)
                {
                    dataGridViewProsesDekripsi.Rows.Add("M" + (i + 1) + " = " + c + " ^ " + D + " mod " + N);
                    m = Kripto.FastExponent(c, D, N, dataGridViewProsesDekripsi);
                }
                else
                {
                    m = Kripto.QuickModulo(c, D, N);
                }
                now = m.ToBin(blokSize);
                plainBiner.Append(now);
                dataGridViewProsesDekripsi.Rows.Add("M" + (i + 1) + " = " + c + " ^ " + D + " mod " + N + " = " + m);
                dataGridViewProsesDekripsi.Rows.Add("M" + (i + 1) + " = " + now);
            }
            dataGridViewProsesDekripsi.Rows.Add();
            dataGridViewProsesDekripsi.Rows.Add("Plaintext Biner : " + plainBiner.ToString());
            StringBuilder plainText = new StringBuilder();
            while (plainBiner.Length > 0)
            {
                now = plainBiner.ToString(0, Math.Min(8, plainBiner.Length));
                ulong t = now.BinToUlong();
                if (t == 0)
                {
                    dataGridViewProsesDekripsi.Rows.Add(plainBiner.ToString() + " = bit yang ditambahkan");
                    break;
                }
                else
                {
                    dataGridViewProsesDekripsi.Rows.Add(now + " = " + t + " = " + (char)t);
                    plainText.Append((char)t);
                }
                plainBiner.Remove(0, Math.Min(8, plainBiner.Length));
            }
            dataGridViewProsesDekripsi.Rows.Add("Plaintext : " + plainText.ToString());
            textBoxDekripsiPlainText.Text = plainText.ToString();
        }

        #endregion
    }
}
