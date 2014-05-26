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
    public partial class FormElGamal : Form
    {
        Random random;
        int P, G, X, Y;

        public FormElGamal()
        {
            InitializeComponent();
            dataGridViewNotSortAbleKey.Columns.Add("P1", "P1");
            dataGridViewProsesEnkripsi.Columns.Add("P1", "P1");
            dataGridViewProsesDekripsi.Columns.Add("P1", "P1");
            buttonEnkripsi.Enabled = false;
            buttonDekripsi.Enabled = false;
        }

        private void FormElGamal_Load(object sender, EventArgs e)
        {
            random = new Random(DateTime.Now.Millisecond);
        }

        #region "Tab Key"

        private void ClearKey()
        {
            textBoxY.Clear();
            dataGridViewNotSortAbleKey.Rows.Clear();
            textBoxEnkripsiPlainText.Clear();
            textBoxK.Clear();
            buttonEnkripsi.Enabled = false;
            ClearEnkrip();
        }

        private void buttonHitungY_Click(object sender, EventArgs e)
        {
            ClearKey();
            if (int.TryParse(textBoxP.Text, out P) && int.TryParse(textBoxG.Text, out G) && int.TryParse(textBoxX.Text, out X))
            {
                if (!Kripto.IsMiller(P, (int)Math.Min(P, (long)100)))
                {
                    MessageBox.Show("P bukan prima");
                }
                else if (G >= P || G < 1)
                {
                    MessageBox.Show("G antara 1 sampai " + (P - 1));
                }
                else if (X >= P || X < 1)
                {
                    MessageBox.Show("X antara 1 sampai " + (P - 1));
                }
                else if (!Kripto.IsGeneratorModulo(G, P))
                {
                    MessageBox.Show("G bukan generator modulo P");
                }
                else
                {
                    dataGridViewNotSortAbleKey.Rows.Add("Y = G^X % P");
                    dataGridViewNotSortAbleKey.Rows.Add("Y = " + G + "^" + X + " % " + P);
                    Y = Kripto.FastExponent(G, X, P, dataGridViewNotSortAbleKey);
                    dataGridViewNotSortAbleKey.Rows.Add("Y = " + G + "^" + X + " % " + P + " = " + Y);
                    textBoxY.Text = Y.ToString();
                    int t = 0;
                    long x = P;
                    while (x > 1)
                    {
                        t++;
                        x >>= 1;
                    }
                    numericUpDownBlockSize.Maximum = t;
                    numericUpDownBlockSize.Value = t;
                    buttonEnkripsi.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Cek p, q dan x");
            }
        }

        #endregion

        int blokSize;
        long K;
        List<long> ca = new List<long>();
        List<long> cb = new List<long>();

        #region "Tab Enkrip"

        private void ClearEnkrip()
        {
            dataGridViewProsesEnkripsi.Rows.Clear();
            buttonDekripsi.Enabled = false;
            ca.Clear();
            cb.Clear();
            ClearDekrip();
        }

        private void buttonRandomK_Click(object sender, EventArgs e)
        {
            textBoxK.Text = random.Next(1, P - 2).ToString();
        }

        private void buttonEnkripsi_Click(object sender, EventArgs e)
        {
            ClearEnkrip();
            if (long.TryParse(textBoxK.Text, out K))
            {
                blokSize = (int)numericUpDownBlockSize.Value;
                string text = textBoxEnkripsiPlainText.Text;
                string now;
                StringBuilder plainBiner = new StringBuilder();
                foreach (char c in text)
                {
                    plainBiner.Append(((int)c).ToBin(8));
                }
                dataGridViewProsesEnkripsi.Rows.Add("Plaintext Biner : " + plainBiner.ToString());
                dataGridViewProsesEnkripsi.Rows.Add("a = g^k % p");
                dataGridViewProsesEnkripsi.Rows.Add("b = m.y^k % p");
                int i = 1;
                while (plainBiner.Length > 0)
                {
                    now = plainBiner.ToString(0, Math.Min(blokSize, plainBiner.Length));
                    plainBiner.Remove(0, Math.Min(blokSize, plainBiner.Length));
                    int t = now.BinToInt();
                    dataGridViewProsesEnkripsi.Rows.Add();
                    dataGridViewProsesEnkripsi.Rows.Add();
                    dataGridViewProsesEnkripsi.Rows.Add(now + " = " + t);
                    long a = 0, b = 0;
                    dataGridViewProsesEnkripsi.Rows.Add("a = " + G + "^" + K + " % " + P);
                    if (checkBoxShowEnkripsiDetail.Checked)
                    {
                        a = Kripto.FastExponent(G, K, P, dataGridViewProsesEnkripsi);
                    }
                    else
                    {
                        a = Kripto.QuickModulo(G, K, P);
                    }
                    dataGridViewProsesEnkripsi.Rows.Add("a = " + G + "^" + K + " % " + P + " = " + a);
                    dataGridViewProsesEnkripsi.Rows.Add();
                    dataGridViewProsesEnkripsi.Rows.Add("b = " + t + "." + Y + "^" + K + " % " + P);
                    dataGridViewProsesEnkripsi.Rows.Add(Y + "^" + K + " % " + P);
                    if (checkBoxShowEnkripsiDetail.Checked)
                    {
                        b = Kripto.FastExponent(Y, K, P, dataGridViewProsesEnkripsi);
                    }
                    else
                    {
                        b = Kripto.QuickModulo(Y, K, P);
                    }
                    dataGridViewProsesEnkripsi.Rows.Add(Y + "^" + K + " % " + P + " = " + b);
                    dataGridViewProsesEnkripsi.Rows.Add("b = (" + t + "." + b + ") % " + P);
                    b = Kripto.MultiplyModulo(b, t, P);
                    dataGridViewProsesEnkripsi.Rows.Add("b = " + t + "." + Y + "^" + K + " % " + P + " = " + b);
                    ca.Add(a);
                    cb.Add(b);
                    buttonDekripsi.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Cek k");
            }
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
            int last = 8 - (((ca.Count - 1) * blokSize) % 8);
            dataGridViewProsesDekripsi.Rows.Add("c = a^(p-1-x) % p");
            dataGridViewProsesDekripsi.Rows.Add("m = c.b % p");
            for (int i = 0; i < ca.Count; i++)
            {
                long a = ca[i];
                long b = cb[i];
                long c = 0, m = 0;
                dataGridViewProsesDekripsi.Rows.Add();
                dataGridViewProsesDekripsi.Rows.Add("c = " + a + "^(" + P + "-1-" + X + ") % " + P);
                if (checkBoxShowDekripsiDetail.Checked)
                {
                    c = Kripto.FastExponent(a, P - 1 - X, P, dataGridViewProsesDekripsi);
                }
                else
                {
                    c = Kripto.QuickModulo(a, P - 1 - X, P);
                }
                m = Kripto.MultiplyModulo(c, b, P);
                dataGridViewProsesDekripsi.Rows.Add("m = (" + c + " . " + b + ") % " + P + " = " + m);
                if (i == ca.Count - 1)
                {
                    plainBiner.Append(m.ToBin(last));
                }
                else
                {
                    plainBiner.Append(m.ToBin(blokSize));
                }
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
