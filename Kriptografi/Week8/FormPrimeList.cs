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
    public partial class FormPrimeList : Form
    {
        public FormPrimeList()
        {
            InitializeComponent();
        }

        private void buttonShowPrime_Click(object sender, EventArgs e)
        {
            if (numericUpDownDari.Value + 10000 < numericUpDownSampai.Value && MessageBox.Show("Range terlalu besar, lanjukan?", "Prima range", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            dataGridViewNotSortAblePrima.DataSource = Kripto.GetPrime((int)numericUpDownDari.Value, (int)numericUpDownSampai.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnPrecompute.Enabled = false;
            Kripto.Sieve(100000000);
            btnPrecompute.Enabled = true;
        }
    }
}
