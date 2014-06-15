using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Kriptografi
{
    public partial class FormContainer : Form
    {
        public FormContainer()
        {
            InitializeComponent();
        }

        private Week3.FormGF GF;
        private Week3.FormQuickModulo QuickModulo;
        private Week3.FormRabinMiller RabinMiller;
        private Week4.FormChineseRemainderTheorem ChineseRemainderTheorem;
        private Week6.FormAES AES;
        private Week7.FormA5 A5;
        private Week7.FormLFSR LFSR;
        private Week7.FormRC4 RC4;
        private Week8.FormRSA RSA;
        private Week8.FormElGamal ElGamal;
        private Week8.FormLUC LUC;
        private Week8.FormRabin Rabin;
        private Week8.FormPrimeList PrimeList;
        private Week9.FormSHA1 SHA1;
        private Week10.FormLargestPrimeDivisor LargetPrimeDivisor;
        private Week10.FormBlindSignature BlindSignature;

        private void ShowForm<T>(ref T newForm)
        {
            if (newForm == null || !(newForm as Form).IsHandleCreated)
            {
                Type t = typeof(T);
                Assembly a = Assembly.GetAssembly(t);
                newForm = (T)Convert.ChangeType(a.CreateInstance(t.FullName), t);
            }
            Form form = newForm as Form;
            form.MdiParent = this;
            form.Show();
            form.Focus();
        }

        private void gFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref GF);
        }

        private void fastExponentiationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref QuickModulo);
        }

        private void rabinMillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref RabinMiller);
        }

        private void chineseRemainderTheoremToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref ChineseRemainderTheorem);
        }

        private void aESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref AES);
        }

        private void a5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref A5);
        }

        private void lFSRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref LFSR);
        }

        private void rC4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref RC4);
        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref RSA);
        }

        private void elGamalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref ElGamal);
        }

        private void lUCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref LUC);
        }

        private void rabinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref Rabin);
        }

        private void primeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref PrimeList);
        }

        private void sHA1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref SHA1);
        }

        private void largestPrimeDivisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref LargetPrimeDivisor);
        }

        private void blindSignatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(ref BlindSignature);
        }
    }
}
