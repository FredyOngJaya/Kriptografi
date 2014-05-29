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
        ulong P, G, X, Y;

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
            uint p, g, x;
            if (uint.TryParse(textBoxP.Text, out p) && uint.TryParse(textBoxG.Text, out g) && uint.TryParse(textBoxX.Text, out x))
            {
                P = p;
                G = g;
                X = x;
                if (!Kripto.IsMiller(P, (int)Math.Min(P, (ulong)100)))
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
                else if (!Kripto.IsGeneratorModulo(g, p))
                {
                    MessageBox.Show("G bukan generator modulo P");
                }
                else
                {
                    dataGridViewNotSortAbleKey.Rows.Add("P = " + P);
                    dataGridViewNotSortAbleKey.Rows.Add("G = " + G);
                    dataGridViewNotSortAbleKey.Rows.Add("X = " + X);
                    dataGridViewNotSortAbleKey.Rows.Add("Y = G^X % P");
                    dataGridViewNotSortAbleKey.Rows.Add("Y = " + G + "^" + X + " % " + P);
                    Y = Kripto.FastExponent(G, X, P, dataGridViewNotSortAbleKey);
                    dataGridViewNotSortAbleKey.Rows.Add("Y = " + G + "^" + X + " % " + P + " = " + Y);
                    textBoxY.Text = Y.ToString();
                    int t = 0;
                    ulong temp = P;
                    while (temp > 1)
                    {
                        t++;
                        temp >>= 1;
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
        ulong K;
        List<ulong> ca = new List<ulong>();
        List<ulong> cb = new List<ulong>();

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
            textBoxK.Text = ((ulong)((P - 3) * random.NextDouble()) + 1).ToString();
        }

        private void buttonEnkripsi_Click(object sender, EventArgs e)
        {
            ClearEnkrip();
            if (ulong.TryParse(textBoxK.Text, out K))
            {
                if (K > P - 2 || K < 1)
                {
                    MessageBox.Show("K antara 1 sampai " + (P - 2));
                }
                else if (textBoxEnkripsiPlainText.Text.Length == 0)
                {
                    MessageBox.Show("Plaintext kosong");
                }
                else
                {
                    blokSize = (int)numericUpDownBlockSize.Value;
                    string text = textBoxEnkripsiPlainText.Text;
                    string now;
                    StringBuilder plainBiner = new StringBuilder();
                    foreach (char c in text)
                    {
                        plainBiner.Append(((int)c).ToBin(8));
                    }
                    dataGridViewProsesEnkripsi.Rows.Add("Plaintext : " + text);
                    dataGridViewNotSortAbleKey.Rows.Add("K = " + K);
                    dataGridViewProsesEnkripsi.Rows.Add("Ukuran Blok = " + blokSize);
                    dataGridViewProsesEnkripsi.Rows.Add();
                    dataGridViewProsesEnkripsi.Rows.Add("Plaintext Biner : " + plainBiner.ToString());
                    dataGridViewProsesEnkripsi.Rows.Add("a = g^k % p");
                    dataGridViewProsesEnkripsi.Rows.Add("b = m.y^k % p");
                    int i = 1;
                    while (plainBiner.Length > 0)
                    {
                        dataGridViewProsesEnkripsi.Rows.Add();
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
                        ulong a = 0, b = 0;
                        if (checkBoxShowEnkripsiDetail.Checked)
                        {
                            dataGridViewProsesEnkripsi.Rows.Add("a = " + G + "^" + K + " % " + P);
                            a = Kripto.FastExponent(G, K, P, dataGridViewProsesEnkripsi);
                        }
                        else
                        {
                            a = Kripto.QuickModulo(G, K, P);
                        }
                        dataGridViewProsesEnkripsi.Rows.Add("a = " + G + "^" + K + " % " + P + " = " + a);
                        dataGridViewProsesEnkripsi.Rows.Add();
                        if (checkBoxShowEnkripsiDetail.Checked)
                        {
                            dataGridViewProsesEnkripsi.Rows.Add("b = " + t + "." + Y + "^" + K + " % " + P);
                            dataGridViewProsesEnkripsi.Rows.Add(Y + "^" + K + " % " + P);
                            b = Kripto.FastExponent(Y, K, P, dataGridViewProsesEnkripsi);
                            dataGridViewProsesEnkripsi.Rows.Add(Y + "^" + K + " % " + P + " = " + b);
                            dataGridViewProsesEnkripsi.Rows.Add("b = (" + t + "." + b + ") % " + P);
                        }
                        else
                        {
                            b = Kripto.QuickModulo(Y, K, P);
                        }
                        b = Kripto.MultiplyModulo(b, (ulong)t, P);
                        dataGridViewProsesEnkripsi.Rows.Add("b = " + t + "." + Y + "^" + K + " % " + P + " = " + b);
                        ca.Add(a);
                        cb.Add(b);
                    }
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
            string now;
            dataGridViewProsesDekripsi.Rows.Add("c = a^(p-1-x) % p");
            dataGridViewProsesDekripsi.Rows.Add("m = c.b % p");
            for (int i = 0; i < ca.Count; i++)
            {
                ulong a = ca[i];
                ulong b = cb[i];
                ulong c = 0, m = 0;
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
                plainBiner.Append(m.ToBin(blokSize));
                dataGridViewProsesDekripsi.Rows.Add("m = (" + c + " . " + b + ") % " + P + " = " + m);
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
