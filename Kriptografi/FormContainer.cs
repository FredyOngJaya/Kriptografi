using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kriptografi
{
    public partial class FormContainer : Form
    {
        public FormContainer()
        {
            InitializeComponent();
        }

        //private FormGF _FormGF = new FormGF();
        //private FormQuickModulo _FormFastExponentiation = new FormQuickModulo();

        private void ShowForm(Form newForm)
        {
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void gFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Week3.FormGF());
        }

        private void fastExponentiationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Week3.FormQuickModulo());
        }

        private void rabinMillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Week3.FormRabinMiller());
        }

        private void chineseRemainderTheoremToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Week4.FormChineseRemainderTheorem());
        }

        private void aESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Week6.FormAES());
        }

        private void a5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Week7.FormA5());
        }

        private void lFSRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Week7.FormLFSR());
        }

        private void rC4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Week7.FormRC4());
        }
    }
}
