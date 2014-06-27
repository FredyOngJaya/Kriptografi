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
            ulong num = Convert.ToUInt64(numericUpDownNumber.Value);
            ulong pow = Convert.ToUInt64(numericUpDownPower.Value);
            ulong div = Convert.ToUInt64(numericUpDownDivisor.Value);
            textBoxResult.Text = Kripto.QuickModulo(num, pow, div).ToString();
        }
    }
}
