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
        }

        private void FormRSA_Load(object sender, EventArgs e)
        {
            random = new Random(DateTime.Now.Millisecond);
            buttonRandomD.Enabled = false;
            buttonHitungE.Enabled = false;
            buttonEnkripsi.Enabled = false;
        }

        #region "Tab Key"

        private void buttonHitungN_Click(object sender, EventArgs e)
        {
            textBoxD.Clear();
            textBoxE.Clear();
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
                    return;
                }
            }
            else
            {
                MessageBox.Show("Cek p dan q");
            }
            textBoxN.Clear();
            textBoxTotientN.Clear();
            buttonRandomD.Enabled = false;
            buttonHitungE.Enabled = false;
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
                    return;
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
            textBoxE.Clear();
            buttonEnkripsi.Enabled = false;
        }

        #endregion

        #region "Tab Enkrip"

        private void buttonEnkripsi_Click(object sender, EventArgs e)
        {
            string plain = textBoxEnkripsiPlainText.Text;
            StringBuilder cipher = new StringBuilder();
            foreach (char c in plain)
            {
                int m = (int)Kripto.QuickModulo(c, E, N);
                cipher.Append((char)m);
            }
            textBoxEnkripsiCipherText.Text = cipher.ToString();
            textBoxDekripsiCipherText.Text = cipher.ToString();
        }

        #endregion

        #region "Tab Enkrip"

        private void buttonDekripsi_Click(object sender, EventArgs e)
        {
            string cipher = textBoxDekripsiCipherText.Text;
            StringBuilder plain = new StringBuilder();
            foreach (char c in cipher)
            {
                int m = (int)Kripto.QuickModulo(c, D, N);
                plain.Append((char)m);
            }
            textBoxDekripsiPlainText.Text = plain.ToString();
        }

        #endregion
    }
}
