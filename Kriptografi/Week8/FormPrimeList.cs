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

        private void btnPrecompute10_Click(object sender, EventArgs e)
        {
            btnPrecompute10.Enabled = false;
            Kripto.Sieve(10_000_000);
            btnPrecompute10.Enabled = true;
            MessageBox.Show("Selesai");
        }

        private void btnPrecompute100_Click(object sender, EventArgs e)
        {
            btnPrecompute100.Enabled = false;
            Kripto.Sieve(100_000_000);
            btnPrecompute100.Enabled = true;
            MessageBox.Show("Selesai");
        }

        private void btnPrecompute1000_Click(object sender, EventArgs e)
        {
            btnPrecompute1000.Enabled = false;
            Kripto.Sieve(1_000_000_000);
            btnPrecompute1000.Enabled = true;
            MessageBox.Show("Selesai");
        }
    }
}
