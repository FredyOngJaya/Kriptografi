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
    public partial class FormRabinMiller : Form
    {
        public FormRabinMiller()
        {
            InitializeComponent();
        }

        private void buttonTesPrima_Click(object sender, EventArgs e)
        {
            bool isPrima = Kripto.TestPrima(Convert.ToInt64(textBoxNum.Text), 1662803);
            textBoxHasilRabinMiller.Text = "Dengan rabin miller, " + textBoxNum.Text;
            if (isPrima)
            {
                textBoxHasilRabinMiller.Text += " adalah bilangan prima";
            }
            else
            {
                textBoxHasilRabinMiller.Text += " adalah bukan bilangan prima";
            }
        }

        private void FormRabinMiller_Load(object sender, EventArgs e)
        {
            /*
            for (int i = 0; i < 101; i++)
            {
                bool p = Kripto.TestPrima(i, 10);
                bool p2 = Kripto.IsMiller(i, 20);
                dataGridViewTes.Rows.Add(new object[] { i + " " + p + " " + p2 });
            }
            //*/
        }
    }
}
