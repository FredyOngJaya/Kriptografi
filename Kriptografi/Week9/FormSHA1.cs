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
        private byte[] messageBlock = new byte[64];
        private int messageBlockIndex;
        private int lengthLow, lengthHigh;
        uint[] H = new uint[5];

        public FormSHA1()
        {
            InitializeComponent();
            for (int i = 1; i <= 6; i++)
                dataGridViewNotSortAbleProses.Columns.Add("P" + i, "P" + i);
        }

        private void reset()
        {
            messageBlockIndex = 0;
            lengthLow = 0;
            lengthHigh = 0;

            H[0] = 0x67452301;
            H[1] = 0xEFCDAB89;
            H[2] = 0x98BADCFE;
            H[3] = 0x10325476;
            H[4] = 0xC3D2E1F0;
        }

        private void writeToGrid(byte[] data, DataGridView grid)
        {
            string[] view = new string[6];
            for (int i = 0; i < data.Length / 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    view[j] = data[i * 4 + j].ToBin();
                }
                grid.Rows.Add(view);
            }
        }

        private void processMessageBlock()
        {
            uint[] W = new uint[80];
            uint A, B, C, D, E;
            string[] view = new string[6];
            DataGridView grid = dataGridViewNotSortAbleProses;
            // Biner
            grid.Rows.Add("Biner");
            for (int i = 0; i < messageBlock.Length; i++)
            {
                view[i % 4] = messageBlock[i].ToBin();
                if (i % 4 == 3)
                    grid.Rows.Add(view);
            }
            // Hexa
            grid.Rows.Add("Hexa");
            for (int t = 0; t < 16; t++)
            {
                W[t] = ((uint)messageBlock[t * 4]) << 24;
                W[t] |= ((uint)messageBlock[t * 4 + 1]) << 16;
                W[t] |= ((uint)messageBlock[t * 4 + 2]) << 8;
                W[t] |= ((uint)messageBlock[t * 4 + 3]);
                view[t % 4] = ((int)W[t]).ToHex().PadLeft(8, '0');
                if (t % 4 == 3)
                    grid.Rows.Add(view);
            }
            // W
            grid.Rows.Add("W");
            for (int t = 0; t < 16; t++)
            {
                view[t % 4] = "W" + t + " = " + ((int)W[t]).ToHex().PadLeft(8, '0');
                if (t % 4 == 3)
                    grid.Rows.Add(view);
            }
            for (int t = 16; t < 80; t++)
            {
                W[t] = Sn(1, W[t - 3] ^ W[t - 8] ^ W[t - 14] ^ W[t - 16]);
                view[t % 4] = "W" + t + " = " + ((int)W[t]).ToHex().PadLeft(8, '0');
                if (t % 4 == 3)
                    grid.Rows.Add(view);
            }
            A = H[0];
            B = H[1];
            C = H[2];
            D = H[3];
            E = H[4];
            // ABCDE
            grid.Rows.Add("Register");
            grid.Rows.Add("A = " + ((int)A).ToHex(8));
            grid.Rows.Add("B = " + ((int)B).ToHex(8));
            grid.Rows.Add("C = " + ((int)C).ToHex(8));
            grid.Rows.Add("D = " + ((int)D).ToHex(8));
            grid.Rows.Add("E = " + ((int)E).ToHex(8));
            // Tabel
            view[0] = "T";
            for (int i = 0; i < 5; i++)
            {
                view[i + 1] = ((char)('A' + i)).ToString();
            }
            grid.Rows.Add(view);
            for (int t = 0; t < 80; t++)
            {
                uint temp = Sn(5, A) + fBCD(t, B, C, D) + E + W[t] + getK(t);
                E = D;
                D = C;
                C = Sn(30, B);
                B = A;
                A = temp;
                view[0] = t.ToString();
                view[1] = ((int)A).ToHex(8);
                view[2] = ((int)B).ToHex(8);
                view[3] = ((int)C).ToHex(8);
                view[4] = ((int)D).ToHex(8);
                view[5] = ((int)E).ToHex(8);
                grid.Rows.Add(view);
            }
            H[0] += A;
            H[1] += B;
            H[2] += C;
            H[3] += D;
            H[4] += E;
            for (int i = 0; i < H.Length; i++)
            {
                dataGridViewNotSortAbleProses.Rows.Add("H" + i + " = H" + i + " + " + (char)('A' + i) + " = " + ((int)H[i]).ToHex(8));
            }

            messageBlockIndex = 0;
        }

        private void buttonSHA1_Click(object sender, EventArgs e)
        {
            dataGridViewNotSortAbleProses.Rows.Clear();
            reset();
            // H
            dataGridViewNotSortAbleProses.Rows.Add("Initial H");
            for (int i = 0; i < H.Length; i++)
            {
                dataGridViewNotSortAbleProses.Rows.Add("H" + i + " = " + ((int)H[i]).ToHex(8));
            }
            string message = textBoxMessage.Text;
            byte[] _message = Encoding.ASCII.GetBytes(message);
            for (int i = 0; i < _message.Length; i++)
            {
                messageBlock[messageBlockIndex++] = _message[i];

                lengthLow += 8;
                if (lengthLow == 0)
                {
                    lengthHigh++;
                }

                if (messageBlockIndex == 64)
                {
                    processMessageBlock();
                }
            }
            if (messageBlockIndex > 55)
            {
                messageBlock[messageBlockIndex++] = 0x80;
                while (messageBlockIndex < 64)
                {
                    messageBlock[messageBlockIndex++] = 0;
                }

                processMessageBlock();

                while (messageBlockIndex < 56)
                {
                    messageBlock[messageBlockIndex++] = 0;
                }
            }
            else
            {
                messageBlock[messageBlockIndex++] = 0x80;
                while (messageBlockIndex < 56)
                {
                    messageBlock[messageBlockIndex++] = 0;
                }
            }

            messageBlock[56] = (byte)((lengthHigh >> 24) & 0xFF);
            messageBlock[57] = (byte)((lengthHigh >> 16) & 0xFF);
            messageBlock[58] = (byte)((lengthHigh >> 8) & 0xFF);
            messageBlock[59] = (byte)((lengthHigh) & 0xFF);
            messageBlock[60] = (byte)((lengthLow >> 24) & 0xFF);
            messageBlock[61] = (byte)((lengthLow >> 16) & 0xFF);
            messageBlock[62] = (byte)((lengthLow >> 8) & 0xFF);
            messageBlock[63] = (byte)((lengthLow) & 0xFF);

            processMessageBlock();

            string[] data = new string[10];
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                result.Append(((int)H[i]).ToHex().PadLeft(8, '0'));
            }
            data[5] = result.ToString();
            dataGridViewNotSortAbleProses.Rows.Add(data);
            data[5] = getSHA1(message);
            dataGridViewNotSortAbleProses.Rows.Add(data);
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
