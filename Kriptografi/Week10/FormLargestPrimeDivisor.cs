using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Kripto = Kriptografi.KriptografiLibrary;
using KriptografiExtensions;

namespace Kriptografi.Week10
{
    public partial class FormLargestPrimeDivisor : Form
    {
        public FormLargestPrimeDivisor()
        {
            InitializeComponent();
            dataGridViewNotSortAbleInfo.Columns.Add("P1", "P1");
            dataGridViewNotSortAbleInfo.Columns.Add("P2", "P2");
        }

        private void buttonListNumber_Click(object sender, EventArgs e)
        {
            dataGridViewNotSortAbleInfo.Rows.Clear();
            if (numericUpDownDari.Value + 10000 < numericUpDownSampai.Value && MessageBox.Show("Range terlalu besar, lanjukan?", "Number range", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            checkBoxWriteToFile.Enabled = false;
            if (checkBoxWriteToFile.Checked)
            {
                using (StreamWriter writer = new StreamWriter("number.txt"))
                {
                    for (uint i = (uint)numericUpDownDari.Value; i <= (uint)numericUpDownSampai.Value; i++)
                    {
                        if (Kripto.IsMiller((ulong)i, 100))
                        {
                            writer.WriteLine(i.ToString() + '\t' + Kripto.GetLargestPrimeDivisor(i - 1).ToString());
                        }
                        if (i + 1 == 0) break;
                    }
                }
            }
            else
            {
                for (uint i = (uint)numericUpDownDari.Value; i <= (uint)numericUpDownSampai.Value; i++)
                {
                    if (Kripto.IsMiller((ulong)i, 100))
                    {
                        dataGridViewNotSortAbleInfo.Rows.Add(new string[] { i.ToString(), Kripto.GetLargestPrimeDivisor(i - 1).ToString() });
                    }
                    if (i + 1 == 0) break;
                }
            }
            checkBoxWriteToFile.Enabled = true;
        }
    }
}
