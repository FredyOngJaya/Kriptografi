using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

using Kripto = Kriptografi.KriptografiLibrary;
using KriptografiExtensions;

namespace Kriptografi.Week9
{
    public partial class FormSHA1 : Form
    {
        public FormSHA1()
        {
            InitializeComponent();
            for (int i = 1; i <= 6; i++)
                dataGridViewNotSortAbleProses.Columns.Add("P" + i, "P" + i);
        }

        private void buttonSHA1_Click(object sender, EventArgs e)
        {
            dataGridViewNotSortAbleProses.Rows.Clear();
            string message = textBoxMessage.Text;
            int len = message.Length;
            int k = message.Length * 8;
            StringBuilder hexa = new StringBuilder();
            foreach (char c in message)
            {
                hexa.Append(((int)c).ToHex());
            }
            hexa.Append("80");
            string padding = hexa.ToString().PadRight(112, '0') + k.ToHex().PadLeft(16, '0');
            writeToGrid(padding, dataGridViewNotSortAbleProses);
            uint[] H = new uint[5];
            H[0] = 0x67452301;
            H[1] = 0xEFCDAB89;
            H[2] = 0x98BADCFE;
            H[3] = 0x10325476;
            H[4] = 0xC3D2E1F0;
            uint[] W = new uint[80];
            uint A, B, C, D, E;
            for (int i = 0; i < 16; i++)
            {
                W[i] = (uint)padding.Substring(i * 8, 8).HexToInt();
            }
            for (int t = 16; t < 80; t++)
            {
                W[t] = Sn(1, W[t - 3] ^ W[t - 8] ^ W[t - 14] ^ W[t - 16]);
            }
            //for (int i = 0; i < 80; i++)
            //{
            //    dataGridViewNotSortAbleProses.Rows.Add(new string[] { i.ToString(), ((int)W[i]).ToHex().PadLeft(8, '0') });
            //}
            A = H[0];
            B = H[1];
            C = H[2];
            D = H[3];
            E = H[4];
            string[] data = new string[10];
            data[0] = "T";
            for (int i = 0; i < 5; i++)
            {
                data[i + 1] = ((char)('A' + i)).ToString();
            }
            dataGridViewNotSortAbleProses.Rows.Add(data);
            for (int t = 0; t < 80; t++)
            {
                uint temp = Sn(5, A) + fBCD(t, B, C, D) + E + W[t] + getK(t);
                E = D;
                D = C;
                C = Sn(30, B);
                B = A;
                A = temp;
                data[0] = t.ToString();
                data[1] = ((int)A).ToHex().PadLeft(8, '0');
                data[2] = ((int)B).ToHex().PadLeft(8, '0');
                data[3] = ((int)C).ToHex().PadLeft(8, '0');
                data[4] = ((int)D).ToHex().PadLeft(8, '0');
                data[5] = ((int)E).ToHex().PadLeft(8, '0');
                dataGridViewNotSortAbleProses.Rows.Add(data);
            }
            H[0] += A;
            H[1] += B;
            H[2] += C;
            H[3] += D;
            H[4] += E;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                result.Append(((int)H[i]).ToHex().PadLeft(8, '0'));
            }
            dataGridViewNotSortAbleProses.Rows.Add(result);
            dataGridViewNotSortAbleProses.Rows.Add(getSHA1(message));
        }

        private void writeToGrid(string message, DataGridView grid)
        {
            string[] data = new string[6];
            data[5] = message;
            grid.Rows.Add(data);
            data[5] = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    data[j] = message.Substring(i * 32 + j * 8, 8);
                }
                grid.Rows.Add(data);
            }
        }

        private uint getK(int t)
        {
            if (t < 20)
                return 0x5A827999;
            else if (t < 40)
                return 0x6ED9EBA1;
            else if (t < 60)
                return 0x8F1BBCDC;
            else
                return 0xCA62C1D6;
        }

        private uint fBCD(int t, uint B, uint C, uint D)
        {
            if (t < 20)
                return (B & C) | ((~B) & D);
            else if (t < 40)
                return B ^ C ^ D;
            else if (t < 60)
                return (B & C) | (B & D) | (C & D);
            else
                return B ^ C ^ D;
        }

        private uint Sn(int n, uint num)
        {
            return (num << n) | (num >> (32 - n));
        }

        private string getSHA1(string _string)
        {
            SHA1 _sha1 = SHA1.Create();
            byte[] _input = Encoding.ASCII.GetBytes(_string);
            byte[] _hash = _sha1.ComputeHash(_input);

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < _hash.Length; i++)
            {
                output.Append(_hash[i].ToString("X2"));
            }
            return output.ToString();
        }
    }
}
