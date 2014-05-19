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
    public partial class FormRSA : Form
    {
        Random random;
        long P = 0, Q = 0;
        long N = 0, TN = 0;
        long D = 0, E = 0;

        public FormRSA()
        {
            InitializeComponent();
            //labelTotienN.Text = "\u03A6\u03C6\u03D5\u0278(n)";
            labelTotienN.Text = "\u03D5(n)";
            dataGridViewProsesEnkripsi.Columns.Add("P1", "P1");
            dataGridViewProsesDekripsi.Columns.Add("P1", "P1");
            buttonRandomD.Enabled = false;
            buttonHitungE.Enabled = false;
            buttonEnkripsi.Enabled = false;
            //buttonDekripsi.Enabled = false;
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

        private void buttonHitungE_Click(object sender, EventArgs e)
        {
            textBoxE.Clear();
            buttonEnkripsi.Enabled = false;
            if (long.TryParse(textBoxD.Text, out D))
            {
                if (Kripto.IsRelatifPrima(D, TN))
                {
                    E = Kripto.InversModulo(D, TN);
                    textBoxE.Text = E.ToString();
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
            cipher.Clear();
            while (plainBiner.Length > 0)
            {
                now = plainBiner.ToString(0, Math.Min(blokSize, plainBiner.Length));
                plainBiner.Remove(0, Math.Min(blokSize, plainBiner.Length));
                int t = now.BinToInt();
                dataGridViewProsesEnkripsi.Rows.Add();
                dataGridViewProsesEnkripsi.Rows.Add(now + " = " + t);
                long c = Kripto.QuickModulo(t, E, N);
                cipher.Add(c);
                dataGridViewProsesEnkripsi.Rows.Add("C = " + t + " ^ " + E + " mod " + N + " = " + c);
            }
        }

        #endregion

        #region "Tab Enkrip"

        private void buttonDekripsi_Click(object sender, EventArgs e)
        {
            dataGridViewProsesDekripsi.Rows.Clear();
            foreach (long c in cipher)
            {
                long m = Kripto.QuickModulo(c, D, N);
                dataGridViewProsesDekripsi.Rows.Add("M = " + c + " ^ " + D + " mod " + N + " = " + m);
                dataGridViewProsesDekripsi.Rows.Add();
            }
        }

        #endregion
    }
}
