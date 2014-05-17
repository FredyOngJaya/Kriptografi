using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Kripto = Kriptografi.KriptografiLibrary;

namespace Kriptografi.Week3
{
    public partial class FormQuickModulo : Form
    {
        public FormQuickModulo()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(numericUpDownNumber.Value);
            int pow = Convert.ToInt32(numericUpDownPower.Value);
            int div = Convert.ToInt32(numericUpDownDivisor.Value);
            textBoxResult.Text = QuickModulo(num, pow, div).ToString();
            textBox1.Text = Kripto.QuickModulo(num, pow, div).ToString();
        }

        private int QuickModulo(int num, int power, int div)
        {
            int[] bit = new int[33];
            int ct = 0;
            while (power > 0)
            {
                bit[ct] = power % 2;
                power >>= 1;
                ct++;
            }
            int[] powLeft = new int[33];
            long[] val = new long[33];
            for (int i = 0; i < ct; i++)
            {
                if (bit[i] == 1)
                {
                    powLeft[i] = 1 << i;
                    val[i] = num;
                }
            }
            while (powLeft[ct - 1] > 1)
            {
                for (int i = 0; i < ct; i++)
                {
                    if (powLeft[i] > 1)
                    {
                        powLeft[i] >>= 1;
                        val[i] = (val[i] * val[i]) % div;
                    }
                }
            }
            long res = 1;
            for (int i = 0; i < ct; i++)
            {
                if (bit[i] == 1)
                {
                    res = (res * val[i]) % div;
                }
            }
            return (int)res;
        }
    }
}
