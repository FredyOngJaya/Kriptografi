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
    public partial class FormDSA : Form
    {
        Random random;
        ulong P, Q, H, G;
        ulong X, Y;
        ulong K;
        ulong R, S;
        ulong W, u1, u2, V;
        string M;
        List<uint> listDivisor = new List<uint>();

        public FormDSA()
        {
            InitializeComponent();
            dataGridViewNotSortAbleInfo.Columns.Add("P1", "P1");
            dataGridViewNotSortAbleFaktorPrimaP1.Columns.Add("P1", "P1");
            buttonRandomX.Enabled = false;
            buttonHitungY.Enabled = false;
            buttonRandomK.Enabled = false;
            buttonSign.Enabled = false;
            buttonVerify.Enabled = false;
        }

        private void FormDSA_Load(object sender, EventArgs e)
        {
            random = new Random(DateTime.Now.Millisecond);
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

        private void buttonHitungG_Click(object sender, EventArgs e)
        {
            textBoxG.Clear();
            dataGridViewNotSortAbleInfo.Rows.Clear();
            dataGridViewNotSortAbleProses.Rows.Clear();
            textBoxPlaintext.Clear();
            textBoxX.Clear();
            buttonRandomX.Enabled = false;
            buttonHitungY.Enabled = false;
            uint p, q, h;
            if (uint.TryParse(textBoxP.Text, out p) &&
                uint.TryParse(textBoxQ.Text, out q) && uint.TryParse(textBoxH.Text, out h))
            {
                P = p;
                Q = q;
                H = h;
                if (!Kripto.IsMiller(P, (int)Math.Min(P, (ulong)100)))
                {
                    MessageBox.Show("P bukan prima");
                }
                else if (listDivisor.Count(t => t == Q) == 0)
                {
                    MessageBox.Show("Q harus faktor prima P-1");
                }
                else if (H >= P || H < 2)
                {
                    MessageBox.Show("H antara 2 dan " + (P - 1));
                }
                else
                {
                    DataGridView grid = dataGridViewNotSortAbleInfo;
                    grid.Rows.Add("P = " + P);
                    grid.Rows.Add("Q = " + Q);
                    grid.Rows.Add("H = " + H);
                    grid.Rows.Add("G = H ^ ((P - 1) / Q) % P");
                    grid.Rows.Add("G = " + H + " ^ ((" + P + " - 1) / " + Q + ") % " + P);
                    ulong pow = (P - 1) / Q;
                    grid.Rows.Add("G = " + H + " ^ " + pow + " % " + P);
                    G = Kripto.FastExponent(H, pow, P, grid);
                    grid.Rows.Add("G = " + H + " ^ " + pow + " % " + P + " = " + G);
                    textBoxG.Text = G.ToString();
                    buttonRandomX.Enabled = true;
                    buttonHitungY.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Cek p, q dan h");
            }
        }

        private void buttonRandomX_Click(object sender, EventArgs e)
        {
            textBoxX.Text = ((ulong)((P - 2) * random.NextDouble()) + 1).ToString();
        }

        private void buttonHitungY_Click(object sender, EventArgs e)
        {
            buttonRandomK.Enabled = false;
            buttonSign.Enabled = false;
            if (ulong.TryParse(textBoxX.Text, out X))
            {
                DataGridView grid = dataGridViewNotSortAbleInfo;
                grid.Rows.Add("Y = G^X % P");
                grid.Rows.Add("Y = " + G + "^" + X + " % " + P);
                Y = Kripto.FastExponent(G, X, P, grid);
                grid.Rows.Add("Y = " + G + "^" + X + " % " + P + " = " + Y);
                textBoxY.Text = Y.ToString();
                buttonHitungY.Enabled = false;
                buttonRandomK.Enabled = true;
                buttonSign.Enabled = true;
            }
            else
            {
                MessageBox.Show("Cek x");
            }
        }

        private void buttonRandomK_Click(object sender, EventArgs e)
        {
            textBoxK.Text = ((ulong)((Q - 1) * random.NextDouble()) + 1).ToString();
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
                if (K >= Q || K < 1)
                {
                    MessageBox.Show("K antara 1 sampai " + (Q - 1));
                }
                else if (textBoxPlaintext.Text.Length == 0)
                {
                    MessageBox.Show("Plaintext kosong");
                }
                else
                {
                    grid.Rows.Add("Sign");
                    grid.Rows.Add("R = (G ^ K % P) % Q");
                    grid.Rows.Add("R = (" + G + "^" + K + " % " + P + ") % " + Q);
                    grid.Rows.Add(G + "^" + K + " % " + P);
                    ulong temp = Kripto.FastExponent(G, K, P, grid);
                    grid.Rows.Add(G + "^" + K + " % " + P + " = " + temp);
                    R = temp % Q;
                    grid.Rows.Add("R = " + temp + " % " + Q + " = " + R);

                    M = textBoxPlaintext.Text;
                    string sha1 = Kripto.getSHA1(M);
                    int _16bit = sha1.Substring(0, 4).HexToInt();
                    grid.Rows.Add();
                    grid.Rows.Add("SHA-1(pesan)");
                    grid.Rows.Add("SHA-1(" + textBoxPlaintext.Text + ")");
                    grid.Rows.Add("SHA-1 = " + sha1);
                    grid.Rows.Add("SHA-1 = " + sha1.Substring(0, 4));
                    grid.Rows.Add("SHA-1 = " + _16bit);

                    grid.Rows.Add();
                    grid.Rows.Add("S = K^-1 * (SHA-1(pesan) + X * R) % Q");
                    grid.Rows.Add("S = " + K + "^-1 * (" + _16bit + " + " + X + " * " + R + ") % " + Q);
                    ulong k_1 = Kripto.InversModulo(K, Q, grid);
                    temp = Kripto.MultiplyModulo(X, R, Q);
                    grid.Rows.Add("S = " + k_1 + " * (" + _16bit + " + " + temp + ") % " + Q);
                    temp = (temp + (ulong)_16bit) % Q;
                    grid.Rows.Add("S = " + k_1 + " * " + temp + " % " + Q);
                    S = Kripto.MultiplyModulo(k_1, temp, Q);
                    grid.Rows.Add("S = " + k_1 + " * " + temp + " % " + Q + " = " + S);
                    
                    buttonVerify.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Cek k");
            }
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            DataGridView grid = dataGridViewNotSortAbleProses;
            grid.Rows.Add();
            grid.Rows.Add();
            grid.Rows.Add("Verify");
            grid.Rows.Add("W = S^-1 % Q");
            grid.Rows.Add("W = " + S + "^-1 % " +Q);
            W = Kripto.InversModulo(S, Q, grid);

            grid.Rows.Add();
            grid.Rows.Add("u1 = (SHA-1(pesan) * W) % Q");
            string sha1 = Kripto.getSHA1(M);
            int _16bit = sha1.Substring(0, 4).HexToInt();
            grid.Rows.Add("u1 = (SHA-1(" + M + ") * " + W + ") % " + Q);
            grid.Rows.Add("u1 = (" + sha1 + " * " + W + ") % " + Q);
            grid.Rows.Add("u1 = (" + sha1.Substring(0, 4) + " * " + W + ") % " + Q);
            grid.Rows.Add("u1 = (" + _16bit + " * " + W + ") % " + Q);
            u1 = Kripto.MultiplyModulo((ulong)_16bit, W, Q);
            grid.Rows.Add("u1 = (" + _16bit + " * " + W + ") % " + Q + " = " + u1);

            grid.Rows.Add();
            grid.Rows.Add("u2 = (R * W) % Q");
            grid.Rows.Add("u2 = (" + R + " * " + W + ") % " + Q);
            u2 = Kripto.MultiplyModulo(R, W, Q);
            grid.Rows.Add("u2 = (" + R + " * " + W + ") % " + Q + " = " + u2);

            grid.Rows.Add();
            grid.Rows.Add("V = ((G^u1 * Y^u2) % P) % Q");
            grid.Rows.Add("V = ((" + G + "^" + u1 + " * " + Y + "^" + u2 + ") % " + P + ") % " + Q);
            grid.Rows.Add();
            grid.Rows.Add(G + "^" + u1 + " % " + P);
            ulong left = Kripto.FastExponent(G, u1, P, grid);
            grid.Rows.Add(G + "^" + u1 + " % " + P + " = " + left);
            grid.Rows.Add();
            grid.Rows.Add(Y + "^" + u2 + " % " + P);
            ulong right = Kripto.FastExponent(Y, u2, P, grid);
            grid.Rows.Add(Y + "^" + u2 + " % " + P + " = " + right);
            grid.Rows.Add("V = (" + left + " * " + right + ") % " + P + ") % " + Q);
            ulong temp = Kripto.MultiplyModulo(left, right, P);
            grid.Rows.Add("V = " + temp + " % " + Q);
            V = temp % Q;
            grid.Rows.Add("V = " + temp + " % " + Q + " = " + V);

            grid.Rows.Add();
            grid.Rows.Add("V = R");
            grid.Rows.Add(V + " = " + R);
            grid.Rows.Add((V == R) ? "Verifikasi Berhasil" : "Verifikasi Gagal");
            buttonVerify.Enabled = false;
        }
    }
}
