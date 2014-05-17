using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using Kripto = Kriptografi.KriptografiLibrary;
using KriptografiExtensions;

namespace Kriptografi.Week3
{
    public partial class FormGF : Form
    {
        public FormGF()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Regex hexa = new Regex(@"^[0-9A-F]+$");
            if (hexa.IsMatch(textBoxNumber1.Text) && hexa.IsMatch(textBoxNumber2.Text) && hexa.IsMatch(textBoxDivisor.Text))
            {
                try
                {
                    int num1 = textBoxNumber1.Text.HexToInt();
                    int num2 = textBoxNumber2.Text.HexToInt();
                    int div = textBoxDivisor.Text.HexToInt();
                    string bin1 = num1.ToBin();
                    string bin2 = num2.ToBin();
                    string binDiv = div.ToBin();
                    int len = 5 * (bin1.Length + bin2.Length - 1) / 4;
                    string now, binary;
                    string line = DuplicateChar('-', len);
                    dataGridViewCalcBiner.Rows.Clear();
                    dataGridViewCalcHex.Rows.Clear();

                    InsertDataGridPolinomial(ToPolinomial(bin1));
                    binary = InsertSpace(bin1);
                    now = string.Concat(DuplicateChar(' ', len - binary.Length), binary);
                    InsertDataGrid(now);

                    InsertDataGridPolinomial(ToPolinomial(bin2));
                    binary = InsertSpace(bin2);
                    now = string.Concat(DuplicateChar(' ', len - binary.Length), binary);
                    InsertDataGrid(now);

                    InsertDataGridPolinomial(line);
                    InsertDataGrid(line);
                    string binMul = Multiply(bin1, bin2, bin2.Length - 1);

                    line += "XOR";
                    InsertDataGridPolinomial(line);
                    InsertDataGrid(line);

                    InsertDataGridPolinomial(ToPolinomial(binMul));
                    binary = InsertSpace(binMul);
                    now = string.Concat(DuplicateChar(' ', len - binary.Length), binary);
                    InsertDataGrid(now);

                    int ct = 64;
                    if (binMul.Length > 8)
                        binDiv = string.Concat(binDiv, DuplicateChar('0', binMul.Length - binDiv.Length));
                    while (binMul.Length > 8 && ct-- > 0)
                    {
                        InsertDataGridPolinomial(ToPolinomial(binDiv));
                        binary = InsertSpace(binDiv);
                        now = string.Concat(DuplicateChar(' ', len - binary.Length), binary);
                        InsertDataGrid(now);

                        InsertDataGridPolinomial(line);
                        InsertDataGrid(line);
                        binMul = XOR(binMul, binDiv);
                        InsertDataGridPolinomial(ToPolinomial(binMul));
                        binary = InsertSpace(binMul);
                        now = string.Concat(DuplicateChar(' ', len - binary.Length), binary);
                        InsertDataGrid(now);
                        while (binMul[0] == '0')
                        {
                            binMul = binMul.Remove(0, 1);
                            binDiv = binDiv.Remove(binDiv.Length - 1, 1);
                        }
                    }
                    int gf = binMul.BinToInt();
                    InsertDataGridPolinomial(ToPolinomial(binMul));
                    InsertDataGrid(now + " = " + gf.ToHex() + "(16) = " + Kripto.GF_8_Hexa(num1, num2));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Hexa tidak valid");
            }
        }

        private void InsertDataGrid(string data)
        {
            dataGridViewCalcBiner.Rows.Add(new object[] { data });
        }

        private void InsertDataGridPolinomial(string data)
        {
            //MessageBox.Show(data);
            dataGridViewCalcHex.Rows.Add(new object[] { data });
        }

        private string InsertSpace(string source)
        {
            StringBuilder res = new StringBuilder();
            int ct = 1;
            for (int i = source.Length - 1; i >= 0; i--)
            {
                res.Insert(0, source[i]);
                if (ct % 4 == 0)
                {
                    res.Insert(0, ' ');
                }
                ct++;
            }
            return res.ToString();
        }

        private string DuplicateChar(char chr, int count)
        {
            return new string(chr, count);
        }

        private string Multiply(string num1, string num2, int pre0)
        {
            int len2 = num2.Length - 1;
            string res = DuplicateChar('0', num1.Length + num2.Length - 1);
            for (int i = len2; i >= 0; i--)
            {
                if (num2[i] == '1')
                {
                    InsertDataGridPolinomial(ToPolinomial(num1 + DuplicateChar('0', len2 - i)));
                    string now = DuplicateChar('0', pre0 + i - len2) + num1 + DuplicateChar('0', len2 - i);
                    res = XOR(res, now);
                    now = InsertSpace(now);
                    InsertDataGrid(now);
                }
            }
            return res;
        }

        private string XOR(string bin1, string bin2)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bin1.Length; i++)
            {
                result.Append((bin1[i] - '0') ^ (bin2[i] - '0'));
            }
            return result.ToString();
        }

        private string ToPolinomial(string bin)
        {
            int len = bin.Length;
            StringBuilder result = new StringBuilder();
            bool first = false;
            for (int i = 0; i < len; i++)
            {
                if (bin[i] == '1')
                {
                    int idx = len - i - 1;
                    if (first)
                    {
                        result.Append(" + ");
                    }
                    first = true;
                    if (idx == 0)
                    {
                        result.Append("1");
                    }
                    else if (idx == 1)
                    {
                        result.Append("x");
                    }
                    else
                    {
                        result.Append("x^" + idx);
                    }
                }
            }
            return result.ToString();
        }

        private void FormGF_Load(object sender, EventArgs e)
        {
            textBoxNumber1.Text = ((int)'F').ToString("X2");
            textBoxNumber2.Text = ((int)'f').ToString("X2");
        }
    }
}
