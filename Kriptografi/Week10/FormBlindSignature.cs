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
    public partial class FormBlindSignature : Form
    {
        Random random;
        ulong P = 0, Q = 0;
        ulong N = 0, TN = 0;
        ulong D = 0, E = 0;
        ulong K = 0, K_1 = 0;

        public FormBlindSignature()
        {
            InitializeComponent();
            labelTotienN.Text = "\u03D5(n)";
            buttonRandomD.Enabled = false;
            buttonHitungE.Enabled = false;
            buttonSign.Enabled = false;
            buttonVerify.Enabled = false;
        }

        private void FormBlindSignature_Load(object sender, EventArgs e)
        {
            random = new Random(DateTime.Now.Millisecond);
        }

        private void buttonHitungN_Click(object sender, EventArgs e)
        {
            textBoxD.Clear();
            textBoxE.Clear();
            textBoxN.Clear();
            textBoxTotientN.Clear();
            buttonRandomD.Enabled = false;
            buttonHitungE.Enabled = false;
            buttonRandomK.Enabled = false;
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
                    buttonRandomK.Enabled = true;
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

        private void buttonHitungE_Click(object sender, EventArgs e)
        {
            dataGridViewNotSortAbleEEA.Rows.Clear();
            dataGridViewNotSortAbleEEA.Columns.Clear();
            buttonSign.Enabled = false;
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
                    buttonSign.Enabled = true;
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

        private void buttonRandomK_Click(object sender, EventArgs e)
        {
            ulong t;
            do
            {
                t = (ulong)(random.NextDouble() * (N - 2)) + 1;
            } while (!Kripto.IsRelatifPrima(t, N));
            textBoxK.Text = t.ToString();
        }

        private ulong M_1 = 0;
        private ulong S_1 = 0, S = 0;

        private void buttonSign_Click(object sender, EventArgs e)
        {
            DataGridView gridInfo = dataGridViewNotSortAbleInfo;
            gridInfo.Rows.Clear();
            gridInfo.Columns.Clear();
            gridInfo.Columns.Add("P1", "P1");
            buttonVerify.Enabled = false;
            if (ulong.TryParse(textBoxK.Text, out K))
            {
                string sha1 = Kripto.getSHA1(textBoxPlaintext.Text);
                int _16bit = sha1.Substring(0, 4).HexToInt();
                gridInfo.Rows.Add("Sign");
                gridInfo.Rows.Add("K = " + K);
                K_1 = Kripto.InversModulo(K, N, gridInfo);
                gridInfo.Rows.Add("SHA-1(" + textBoxPlaintext.Text + ")=" + sha1);
                gridInfo.Rows.Add("16bit pertama = " + sha1.Substring(0, 4) + " = " + _16bit);

                gridInfo.Rows.Add("M* = M * ((K ^ E) % N)");
                gridInfo.Rows.Add("M* = " + _16bit + " * ((" + K + " ^ " + E + ") % " + N + ")");
                ulong c = Kripto.FastExponent(K, E, N, gridInfo);
                gridInfo.Rows.Add("(" + K + " ^ " + E + ") % " + N + " = " + c);
                M_1 = Kripto.MultiplyModulo((ulong)_16bit, c, N);
                gridInfo.Rows.Add("M* = " + _16bit + " * " + c + " % " + N + " = " + M_1);
                gridInfo.Rows.Add();
                gridInfo.Rows.Add("S* = (M* ^ D) % N");
                gridInfo.Rows.Add("S* = (" + M_1 + " ^ " + D + ") % " + N);
                S_1 = Kripto.FastExponent(M_1, D, N, gridInfo);
                gridInfo.Rows.Add("S* = (" + M_1 + " ^ " + D + ") % " + N + " = " + S_1);
                gridInfo.Rows.Add();
                gridInfo.Rows.Add("S = (K^-1 * S*) % N");
                gridInfo.Rows.Add("S = (" + K_1 + " * " + S_1 + ") % " + N);
                S = Kripto.MultiplyModulo(K_1, S_1, N);
                gridInfo.Rows.Add("S = (" + K_1 + " * " + S_1 + ") % " + N + " = " + S);
                buttonVerify.Enabled = true;
            }
            else
            {
                MessageBox.Show("Cek D");
            }
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            DataGridView gridInfo = dataGridViewNotSortAbleInfo;
            gridInfo.Rows.Add();
            gridInfo.Rows.Add();
            gridInfo.Rows.Add("Verify");
            gridInfo.Rows.Add("M* == ((M*) ^ D) ^ E % N");
            gridInfo.Rows.Add("M* == S* ^ E % N");
            gridInfo.Rows.Add("M* == " + S_1 + " ^ " + E + " % " + N);
            ulong c = Kripto.FastExponent(S_1, E, N, gridInfo);
            gridInfo.Rows.Add("M* == " + S_1 + " ^ " + E + " % " + N + " = " + c);
            gridInfo.Rows.Add(M_1 + " == " + c);
            gridInfo.Rows.Add(M_1 == c ? "Valid" : "Tidak valid");
            buttonVerify.Enabled = false;
        }
    }
}
