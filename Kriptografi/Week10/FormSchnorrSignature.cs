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
    public partial class FormSchnorrSignature : Form
    {
        Random random;
        ulong P, G, X, Y;
        ulong Q;
        ulong K, R, B;
        ulong M;
        List<uint> listDivisor = new List<uint>();

        public FormSchnorrSignature()
        {
            InitializeComponent();
            dataGridViewNotSortAbleInfo.Columns.Add("P1", "P1");
            dataGridViewNotSortAbleFaktorPrimaP1.Columns.Add("P1", "P1");
            buttonRandomK.Enabled = false;
            buttonSign.Enabled = false;
            buttonVerify.Enabled = false;
        }

        private void FormSchnorrSignature_Load(object sender, EventArgs e)
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
            uint p, g, x, q;
            if (uint.TryParse(textBoxP.Text, out p) && uint.TryParse(textBoxG.Text, out g) && 
                uint.TryParse(textBoxX.Text, out x) && uint.TryParse(textBoxQ.Text, out q))
            {
                P = p;
                G = g;
                X = x;
                Q = q;
                if (!Kripto.IsMiller(P, (int)Math.Min(P, (ulong)100)))
                {
                    MessageBox.Show("P bukan prima");
                }
                else if (listDivisor.Count(t => t == Q) == 0)
                {
                    MessageBox.Show("Q harus faktor prima P-1");
                }
                else if (X >= Q - 1 || X < 1)
                {
                    MessageBox.Show("X harus < " + (Q - 1));
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
                    grid.Rows.Add("Y = G^-X % P");
                    grid.Rows.Add("Y = (G^-1 % P)^X % P");
                    grid.Rows.Add("G^-1 % P");
                    grid.Rows.Add(G + "^-1 % " + P);
                    ulong g_1 = Kripto.InversModulo(G, P, dataGridViewNotSortAbleProses);
                    grid.Rows.Add(G + "^-1 % " + P + " = " + g_1);
                    grid.Rows.Add("Y = " + g_1 + "^" + X + " % " + P);
                    Y = Kripto.FastExponent(g_1, X, P, grid);
                    grid.Rows.Add("Y = " + g_1 + "^" + X + " % " + P + " = " + Y);
                    textBoxY.Text = Y.ToString();
                    buttonRandomK.Enabled = true;
                    buttonSign.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Cek p, g, q dan x");
            }
        }

        private void buttonRandomK_Click(object sender, EventArgs e)
        {
            textBoxK.Text = ((ulong)((Q - 1) * random.NextDouble()) + 1).ToString();
        }

        private void textBoxP_Leave(object sender, EventArgs e)
        {
            uint p = 0;
            if (uint.TryParse(textBoxP.Text, out p))
            {
                P = p;
                dataGridViewNotSortAbleFaktorPrimaP1.Rows.Clear();
                listDivisor = Kripto.GetPrimeDivisor((uint)P - 1);
                foreach (uint t in listDivisor)
                {
                    dataGridViewNotSortAbleFaktorPrimaP1.Rows.Add(t.ToString());
                }
            }
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
                if (K >= Q - 1 || K < 1)
                {
                    MessageBox.Show("K harus < " + (Q - 1));
                }
                else if (textBoxPlaintext.Text.Length == 0)
                {
                    MessageBox.Show("Plaintext kosong");
                }
                else
                {
                    grid.Rows.Add();
                    grid.Rows.Add("Sign");
                    grid.Rows.Add("R = G^K % P");
                    grid.Rows.Add("R = " + G + "^" + K + " % " + P);
                    R = Kripto.FastExponent(G, K, P, grid);
                    grid.Rows.Add("R = " + G + "^" + K + " % " + P + " = " + R);

                    M = (ulong)textBoxPlaintext.Text[0];
                    string sha1 = Kripto.getSHA1(M.ToString() + R.ToString());
                    int _16bit = sha1.Substring(0, 4).HexToInt();
                    grid.Rows.Add();
                    grid.Rows.Add("E = SHA-1(M||r)");
                    grid.Rows.Add("E = SHA-1(" + M + "||" + R + ")");
                    grid.Rows.Add("E = SHA-1(" + M + "" + R + ")");
                    grid.Rows.Add("E = " + sha1);
                    grid.Rows.Add("E = " + sha1.Substring(0, 4));
                    grid.Rows.Add("E = " + _16bit);

                    ulong S = Kripto.MultiplyModulo(X, (ulong)_16bit, Q);
                    grid.Rows.Add();
                    grid.Rows.Add("S = (K + X * E) % Q");
                    grid.Rows.Add("S = (" + K + " + " + X + " * " + _16bit + ") % " + Q);
                    grid.Rows.Add("S = (" + K + " + " + S + ") % " + Q);
                    S = (K + S) % Q;
                    grid.Rows.Add("S = (" + K + " + " + S + ") % " + Q + " = " + S);

                    //B = Kripto.MultiplyModulo(X, A, P - 1);
                    //grid.Rows.Add();
                    //grid.Rows.Add("M = X * A + K * B (mod P-1)");
                    //grid.Rows.Add(M + " = " + X + " * " + A + " + " + K + " * B mod " + (P - 1));
                    //grid.Rows.Add(M + " = " + B + " + " + K + " mod " + (P - 1) + " * B mod " + (P - 1));
                    //grid.Rows.Add("B mod " + (P - 1) + " = " + M + " - " + B + " * " + K + " ^ -1 mod " + (P - 1));
                    //ulong K_1 = Kripto.InversModulo(K, P - 1, grid);
                    //if (B > M)
                    //{
                    //    B = P - 1 + M - B;
                    //}
                    //else
                    //{
                    //    B = M - B;
                    //}
                    //grid.Rows.Add("B mod " + (P - 1) + " = " + B + " * " + K_1 + " mod " + (P - 1));
                    //B = Kripto.MultiplyModulo(B, K_1, P - 1);
                    //grid.Rows.Add("B mod " + (P - 1) + " = " + B);
                    //grid.Rows.Add("B = " + B);

                    //grid.Rows.Add("Digital signature = concat(a,b) = " + A + "" + B);

                    buttonVerify.Enabled = true;
                }
            }
        }
    }
}
