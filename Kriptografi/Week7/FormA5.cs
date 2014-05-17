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
    public partial class FormA5 : Form
    {
        public FormA5()
        {
            InitializeComponent();
        }

        private void FormA5_Load(object sender, EventArgs e)
        {
            string[] nama = { "Putaran", "Register1", "Register2", "Register3", "Feedback R1", "Feedback R2", "Feedback R3", "Output R1", "Output R2", "Output R3", "Output" };
            for (int i = 0; i < 11; i++)
            {
                dataGridViewKey.Columns.Add(nama[i], nama[i]);
            }
            dataGridViewListKey.Columns.Add("Kunci", "Key");
        }

        private void buttonKey_Click(object sender, EventArgs e)
        {
            dataGridViewKey.Rows.Clear();
            dataGridViewListKey.Rows.Clear();
            if (textBoxKey.Text.Length != 8)
            {
                MessageBox.Show("Key 8 karakter");
            }
            else
            {
                int lenKey = (int)numericUpDownNBitKunci.Value;
                int n = (int)numericUpDownNKunci.Value * lenKey;
                string key = textBoxKey.Text;
                string binerKey = "";
                for (int i = 7; i >= 0; i--)
                {
                    string now = ((int)key[i]).ToBin();
                    now = new string('0', 8 - now.Length) + now;
                    char[] arr = now.ToCharArray();
                    Array.Reverse(arr);
                    binerKey += new string(arr);
                }
                int R1 = binerKey.Substring(45, 19).BinToInt();
                int R2 = binerKey.Substring(23, 22).BinToInt();
                int R3 = binerKey.Substring(0, 23).BinToInt();
                string[] debug = new string[11];
                int feedbackR1 = 0, feedbackR2 = 0, feedbackR3 = 0;
                int output1 = 0, output2 = 0, output3 = 0, output = 0;
                StringBuilder resKey = new StringBuilder();
                for (int i = 0; i <= n; i++)
                {
                    if (i > 0)
                    {
                        R1 <<= 1;
                        R2 <<= 1;
                        R3 <<= 1;
                        R1 |= feedbackR1;
                        R2 |= feedbackR2;
                        R3 |= feedbackR3;
                        output1 = (R1 & (1 << 19)) >> 19;
                        output2 = (R2 & (1 << 22)) >> 22;
                        output3 = (R3 & (1 << 23)) >> 23;
                        R1 &= ((1 << 19) - 1);
                        R2 &= ((1 << 22) - 1);
                        R3 &= ((1 << 23) - 1);
                        output = output1 ^ output2 ^ output3;
                        resKey.Append(output);
                        if (resKey.Length % lenKey == 0)
                        {
                            dataGridViewListKey.Rows.Add(new string[] { resKey.ToString() });
                            resKey.Length = 0;
                        }
                    }

                    int r1_18 = (R1 & (1 << 18)) >> 18;
                    int r1_17 = (R1 & (1 << 17)) >> 17;
                    int r1_16 = (R1 & (1 << 16)) >> 16;
                    int r1_13 = (R1 & (1 << 13)) >> 13;
                    feedbackR1 = r1_18 ^ r1_17 ^ r1_16 ^ r1_13;

                    int r2_21 = (R2 & (1 << 21)) >> 21;
                    int r2_20 = (R2 & (1 << 20)) >> 20;
                    feedbackR2 = r2_20 ^ r2_21;

                    int r3_22 = (R3 & (1 << 22)) >> 22;
                    int r3_21 = (R3 & (1 << 21)) >> 21;
                    int r3_20 = (R3 & (1 << 20)) >> 20;
                    int r3_7 = (R3 & (1 << 7)) >> 7;
                    feedbackR3 = r3_22 ^ r3_21 ^ r3_20 ^ r3_7;

                    debug[0] = i.ToString();
                    binerKey = R1.ToBin();
                    binerKey = new string('0', 19 - binerKey.Length) + binerKey;
                    debug[1] = binerKey;
                    binerKey = R2.ToBin();
                    binerKey = new string('0', 22 - binerKey.Length) + binerKey;
                    debug[2] = binerKey;
                    binerKey = R3.ToBin();
                    binerKey = new string('0', 23 - binerKey.Length) + binerKey;
                    debug[3] = binerKey;
                    debug[4] = feedbackR1.ToString();
                    debug[5] = feedbackR2.ToString();
                    debug[6] = feedbackR3.ToString();
                    debug[7] = (i == 0 ? "-" : output1.ToString());
                    debug[8] = (i == 0 ? "-" : output2.ToString());
                    debug[9] = (i == 0 ? "-" : output3.ToString());
                    debug[10] = (i == 0 ? "-" : output.ToString());
                    dataGridViewKey.Rows.Add(debug);
                }
            }
        }
    }
}
