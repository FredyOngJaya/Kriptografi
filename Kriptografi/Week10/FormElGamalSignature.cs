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

namespace Kriptografi.Week10
{
    public partial class FormElGamalSignature : Form
    {
        Random random;
        ulong P, G, X, Y;
        ulong K, A, B;
        ulong M;

        public FormElGamalSignature()
        {
            InitializeComponent();
            dataGridViewNotSortAbleInfo.Columns.Add("P1", "P1");
            buttonRandomK.Enabled = false;
            buttonSign.Enabled = false;
            buttonVerify.Enabled = false;
        }

        private void FormElGamalSignature_Load(object sender, EventArgs e)
        {
            random = new Random(DateTime.Now.Millisecond);
        }

        private void buttonHitungY_Click(object sender, EventArgs e)
        {
            textBoxY.Clear();
            dataGridViewNotSortAbleInfo.Rows.Clear();
            textBoxPlaintext.Clear();
            textBoxK.Clear();
            buttonRandomK.Enabled = false;
            buttonSign.Enabled = false;
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
                    DataGridView grid = dataGridViewNotSortAbleInfo;
                    grid.Rows.Add("P = " + P);
                    grid.Rows.Add("G = " + G);
                    grid.Rows.Add("X = " + X);
                    grid.Rows.Add("Y = G^X % P");
                    grid.Rows.Add("Y = " + G + "^" + X + " % " + P);
                    Y = Kripto.FastExponent(G, X, P, grid);
                    grid.Rows.Add("Y = " + G + "^" + X + " % " + P + " = " + Y);
                    textBoxY.Text = Y.ToString();
                    buttonRandomK.Enabled = true;
                    buttonSign.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Cek p, q dan x");
            }
        }

        private void buttonRandomK_Click(object sender, EventArgs e)
        {
            textBoxK.Text = ((ulong)((P - 3) * random.NextDouble()) + 1).ToString();
        }

        private void buttonSign_Click(object sender, EventArgs e)
        {
            DataGridView grid = dataGridViewNotSortAbleProses;
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.Columns.Add("P1", "P1");
            buttonVerify.Enabled = false;
            if (ulong.TryParse(textBoxK.Text, out K))
            {
                if (K > P - 2 || K < 1)
                {
                    MessageBox.Show("K antara 1 sampai " + (P - 2));
                }
                else if (textBoxPlaintext.Text.Length == 0)
                {
                    MessageBox.Show("Plaintext kosong");
                }
                else
                {
                    grid.Rows.Add("Sign");
                    grid.Rows.Add("A = G^K % P");
                    grid.Rows.Add("A = " + G + "^" + K + " % " + P);
                    A = Kripto.FastExponent(G, K, P, grid);
                    grid.Rows.Add("A = " + G + "^" + K + " % " + P + " = " + A);

                    M = (ulong)textBoxPlaintext.Text[0];
                    B = Kripto.MultiplyModulo(X, A, P - 1);
                    grid.Rows.Add();
                    grid.Rows.Add("M = X * A + K * B (mod P-1)");
                    grid.Rows.Add(M + " = " + X + " * " + A + " + " + K + " * B mod " + (P - 1));
                    grid.Rows.Add(M + " = " + B + " + " + K + " mod " + (P - 1) + " * B mod " + (P - 1));
                    grid.Rows.Add("B mod " + (P - 1) + " = " + M + " - " + B + " * " + K + " ^ -1 mod " + (P - 1));
                    ulong K_1 = Kripto.InversModulo(K, P - 1, grid);
                    if (B > M)
                    {
                        B = P - 1 + M - B;
                    }
                    else
                    {
                        B = M - B;
                    }
                    grid.Rows.Add("B mod " + (P - 1) + " = " + B + " * " + K_1 + " mod " + (P - 1));
                    B = Kripto.MultiplyModulo(B, K_1, P - 1);
                    grid.Rows.Add("B mod " + (P - 1) + " = " + B);
                    grid.Rows.Add("B = " + B);

                    grid.Rows.Add("Digital signature = concat(a,b) = " + A + "" + B);

                    buttonVerify.Enabled = true;
                }
            }
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            DataGridView grid = dataGridViewNotSortAbleProses;
            grid.Rows.Add();
            grid.Rows.Add();
            grid.Rows.Add("Verify");
            grid.Rows.Add("(Y ^ A * A ^ B) mod P = G ^ M mod P");
            grid.Rows.Add("(" + Y + " ^ " + A + " * " + A + " ^ " + B + ") mod " + P + " = " + G + " ^ " + M + " mod " + P);
            grid.Rows.Add();
            grid.Rows.Add(Y + " ^ " + A + " mod " + P);
            ulong ya = Kripto.FastExponent(Y, A, P, grid);
            grid.Rows.Add(Y + " ^ " + A + " mod " + P + " = " + ya);
            grid.Rows.Add();
            grid.Rows.Add(A + " ^ " + B + " mod " + P);
            ulong ab = Kripto.FastExponent(A, B, P, grid);
            grid.Rows.Add(A + " ^ " + B + " mod " + P + " = " + ab);
            grid.Rows.Add();
            grid.Rows.Add(G + " ^ " + M + " mod " + P);
            ulong gm = Kripto.FastExponent(G, M, P, grid);
            grid.Rows.Add(G + " ^ " + M + " mod " + P + " = " + gm);
            grid.Rows.Add();
            grid.Rows.Add("(" + ya + " * " + ab + ") mod " + P + " = " + gm);
            ya = Kripto.MultiplyModulo(ya, ab, P);
            grid.Rows.Add(ya + " = " + gm);
            grid.Rows.Add((ya == gm) ? "Verifikasi Berhasil" : "Verifikasi Gagal");
        }
    }
}
