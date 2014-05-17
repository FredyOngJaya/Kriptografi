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

namespace Kriptografi.Week7
{
    public partial class FormRC4 : Form
    {
        public FormRC4()
        {
            InitializeComponent();
        }

        int[] key = new int[32];
        int[] S = new int[32];
        int nBit;
        private void FormRC4_Load(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(null, null);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewProsesRC4.Rows.Clear();
            dataGridViewProsesRC4.Columns.Clear();
            nBit = (int)numericUpDownNBit.Value;
            for (int i = 0; i <= nBit; i++)
            {
                dataGridViewProsesRC4.Columns.Add(i.ToString(), i.ToString());
            }
            for (int i = 0; i < nBit; i++)
            {
                S[i] = i;
                key[i] = i;
            }
            textBoxOutput.Clear();
            fillKeyToTextBox();
        }

        private void fillKeyToTextBox()
        {
            for (int i = 0; i < 32; i++)
            {
                this.Controls["textBox" + (i + 1)].Text = (i < nBit ? key[i].ToString() : "");
            }
        }

        private void buttonShuffle_Click(object sender, EventArgs e)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            int n = nBit;
            for (int i = n - 1; i >= 0; i--)
            {
                int k = random.Next(i);
                int t = key[i];
                key[i] = key[k];
                key[k] = t;
            }
            fillKeyToTextBox();
        }

        private void buttonRC4_Click(object sender, EventArgs e)
        {
            try
            {
                long test = 0;
                for (int i = 0; i < nBit; i++)
                {
                    S[i] = i;
                    key[i] = Convert.ToInt32(this.Controls["textBox" + (i + 1)].Text);
                    test |= ((long)1 << key[i]);
                }
                if (test != ((long)1 << nBit) - 1)
                {
                    MessageBox.Show("Key tidak lengkap 0-" + nBit);
                }
                else
                {
                    dataGridViewProsesRC4.Rows.Clear();
                    textBoxOutput.Clear();
                    int i, j = 0, t;
                    int n;
                    string[] debug = new string[33];
                    n = dataGridViewProsesRC4.RowCount;
                    debug[0] = "Iterasi";
                    dataGridViewProsesRC4.Rows.Add(debug);
                    dataGridViewProsesRC4[0, n].Style.BackColor = Color.LightGreen;
                    for (i = 0; i < nBit; i++)
                    {
                        debug[0] = "Iterasi " + i;
                        dataGridViewProsesRC4.Rows.Add(debug);
                        debug[0] = "j=(" + j + " + St[" + i + "] + Key[" + j + "]) mod " + nBit;
                        dataGridViewProsesRC4.Rows.Add(debug);
                        debug[0] = "j=(" + j + " + " + S[i] + " + " + key[j] + ") mod " + nBit + " = ";
                        j = (j + S[i] + key[i]) % nBit;
                        debug[0] += j.ToString();
                        dataGridViewProsesRC4.Rows.Add(debug);
                        t = S[i];
                        S[i] = S[j];
                        S[j] = t;
                        debug[0] = "Swap(St[" + i + "],St[" + j + "])";
                        for (int x = 0; x < nBit; x++)
                        {
                            debug[x + 1] = S[x].ToString();
                        }
                        dataGridViewProsesRC4.Rows.Add(debug);
                        for (int x = 0; x < nBit; x++)
                        {
                            debug[x + 1] = "";
                        }
                    }
                    i = j = 0;
                    n = dataGridViewProsesRC4.RowCount;
                    debug[0] = "Output";
                    dataGridViewProsesRC4.Rows.Add(debug);
                    dataGridViewProsesRC4[0, n].Style.BackColor = Color.LightGreen;
                    int nOutput = (int)numericUpDownProduksiKey.Value;
                    while (nOutput-- > 0)
                    {
                        i += 1;
                        debug[0] = "I=" + i;
                        dataGridViewProsesRC4.Rows.Add(debug);
                        debug[0] = "j=(" + j + " + St[" + i + "]) mod " + nBit;
                        dataGridViewProsesRC4.Rows.Add(debug);
                        debug[0] = "j=(" + j + " + " + S[i] + ") mod " + nBit + " = ";
                        j = (j + S[i]) % nBit;
                        debug[0] += j.ToString();
                        dataGridViewProsesRC4.Rows.Add(debug);
                        t = S[i];
                        S[i] = S[j];
                        S[j] = t;
                        debug[0] = "Swap(St[" + i + "],St[" + j + "])";
                        for (int x = 0; x < nBit; x++)
                        {
                            debug[x + 1] = S[x].ToString();
                        }
                        dataGridViewProsesRC4.Rows.Add(debug);
                        for (int x = 0; x < nBit; x++)
                        {
                            debug[x + 1] = "";
                        }
                        debug[0] = "Output St[(St[" + i + "] + St[" + j + "]) mod " + nBit + "]";
                        dataGridViewProsesRC4.Rows.Add(debug);
                        debug[0] = "Output St[(" + S[i] + " + " + S[j] + ") mod " + nBit + "] = St[" + ((S[i] + S[j]) % nBit) + "] = ";
                        t = S[(S[i] + S[j]) % nBit];
                        debug[0] += t.ToString();
                        dataGridViewProsesRC4.Rows.Add(debug);
                        textBoxOutput.Text += t + " ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
