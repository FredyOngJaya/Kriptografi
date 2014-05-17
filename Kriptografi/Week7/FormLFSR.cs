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
    public partial class FormLFSR : Form
    {
        public FormLFSR()
        {
            InitializeComponent();
        }

        private void FormLFSR_Load(object sender, EventArgs e)
        {
            buttonLFSR.Enabled = false;
            radioButtonShiftLeft.Checked = true;
            string[] nama = { "Putaran", "Register", "Output", "Feedback" };
            for (int i = 0; i < 4; i++)
            {
                dataGridViewProsesLFSR.Columns.Add(nama[i], nama[i]);
            }
            dataGridViewListKey.Columns.Add("Kunci", "Key");
        }

        int nBit;
        private void buttonSetBit_Click(object sender, EventArgs e)
        {
            treeViewBit.BeginUpdate();
            treeViewBit.Nodes.Clear();
            nBit = (int)numericUpDownBit.Value;
            for (int i = 0; i < nBit; i++)
            {
                TreeNode newNode = new TreeNode((i + 1).ToString());
                newNode.Tag = i;
                treeViewBit.Nodes.Add(newNode);
            }
            treeViewBit.EndUpdate();
            buttonSetBit.Enabled = false;
            buttonLFSR.Enabled = true;
        }

        private void buttonLFSR_Click(object sender, EventArgs e)
        {
            dataGridViewProsesLFSR.Rows.Clear();
            dataGridViewListKey.Rows.Clear();
            List<int> bitFeedback = new List<int>();
            foreach (TreeNode node in treeViewBit.Nodes)
            {
                if (node.Checked)
                {
                    bitFeedback.Add(Convert.ToInt32(node.Tag));
                }
            }
            if (bitFeedback.Count == 0)
            {
                MessageBox.Show("Pilih bit feedback");
            }
            else
            {
                if (textBoxSeed.Text.Length != nBit / 8)
                {
                    MessageBox.Show("Bit seed != bit di set");
                }
                else
                {
                    int buang = (int)numericUpDownBuang.Value;
                    int lenKey = (int)numericUpDownNBitKunci.Value;
                    int maxIterasi = (int)numericUpDownNKunci.Value * lenKey + buang;
                    int feedBack = 0, output = 0;
                    StringBuilder seed = new StringBuilder();
                    StringBuilder resKey = new StringBuilder();
                    string keySeed = textBoxSeed.Text;
                    for (int i = 0; i < keySeed.Length; i++)
                    {
                        string now = ((int)keySeed[i]).ToBin();
                        seed.Append(new string('0', 8 - now.Length) + now);
                    }
                    string[] debug = new string[4];
                    for (int i = 0; i <= maxIterasi; i++)
                    {
                        if (i > 0)
                        {
                            if (radioButtonShiftLeft.Checked)
                            {
                                // shift left mode
                                seed.Append(feedBack);
                                output = seed[0] - '0';
                                seed.Remove(0, 1);
                            }
                            else
                            {
                                // shift right mode
                                seed.Insert(0, feedBack);
                                output = seed[seed.Length - 1] - '0';
                                seed.Remove(seed.Length - 1, 1);
                            }
                            resKey.Append(output);
                            if (resKey.Length % lenKey == 0)
                            {
                                dataGridViewListKey.Rows.Add(new string[] { resKey.ToString() });
                                resKey.Length = 0;
                            }
                        }

                        feedBack = 0;
                        for (int idx = 0; idx < bitFeedback.Count; idx++)
                        {
                            feedBack ^= (seed[bitFeedback[idx]] - '0');
                        }

                        debug[0] = i.ToString();
                        debug[1] = seed.ToString();
                        debug[2] = (i == 0 ? "-" : output.ToString());
                        debug[3] = feedBack.ToString();
                        dataGridViewProsesLFSR.Rows.Add(debug);
                        if (i > 0 && i <= buang)
                        {
                            dataGridViewProsesLFSR[2, i].Style.BackColor = Color.LightGray;
                        }
                        else if (i > buang)
                        {
                            dataGridViewProsesLFSR[2, i].Style.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
        }
    }
}
