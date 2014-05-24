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

        }

        private void ClearKey()
        {
            textBoxY.Clear();
            dataGridViewNotSortAbleKey.Rows.Clear();
            textBoxEnkripsiPlainText.Clear();
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

        private void ClearEnkrip()
        {
            dataGridViewProsesEnkripsi.Rows.Clear();
            buttonDekripsi.Enabled = false;
            ca.Clear();
            cb.Clear();
            ClearDekrip();
        }

        int blokSize;
        List<long> ca = new List<long>();
        List<long> cb = new List<long>();

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
                long a = 0;
                // Add K Random
                // Dst
            }
        }

        private void ClearDekrip()
        {
            dataGridViewProsesDekripsi.Rows.Clear();
            textBoxDekripsiPlainText.Clear();
        }
    }
}
