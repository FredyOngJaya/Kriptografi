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
        private uint blok;
        private int messageBlockIndex;
        private int lengthLow, lengthHigh;
        private uint[] H = new uint[5];
        private Color[] listColor = new Color[] { Color.Silver, Color.LimeGreen, Color.LightSteelBlue, Color.DeepSkyBlue };

        public FormSHA1()
        {
            InitializeComponent();
            dataGridViewNotSortAbleK.Columns.Add("K", "K");
            dataGridViewNotSortAbleW.Columns.Add("W", "W");
            dataGridViewNotSortAbleF.Columns.Add("F", "F");
            for (int i = 1; i <= 4; i++)
                dataGridViewNotSortAbleInfo.Columns.Add("I" + i, "I" + i);
            for (int i = 1; i <= 6; i++)
                dataGridViewNotSortAbleProses.Columns.Add("P" + i, "P" + i);
            dataGridViewNotSortAbleK.Rows.Add("K(0 <= t < 20) = " + ((int)getK(0)).ToHex(8));
            dataGridViewNotSortAbleK.Rows.Add("K(20 <= t < 40) = " + ((int)getK(20)).ToHex(8));
            dataGridViewNotSortAbleK.Rows.Add("K(40 <= t < 60) = " + ((int)getK(40)).ToHex(8));
            dataGridViewNotSortAbleK.Rows.Add("K(60 <= t < 80) = " + ((int)getK(60)).ToHex(8));
            dataGridViewNotSortAbleF.Rows.Add("0..20 (B & C) | (~B & D)");
            dataGridViewNotSortAbleF.Rows.Add("20..40 (B ^ C ^ D)");
            dataGridViewNotSortAbleF.Rows.Add("40..60 (B & C) | (B & D) | (C & D)");
            dataGridViewNotSortAbleF.Rows.Add("60..80 (B ^ C ^ D)");
        }

        private void reset()
        {
            messageBlockIndex = 0;
            lengthLow = 0;
            lengthHigh = 0;
            blok = 0;

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
            DataGridView gridW = dataGridViewNotSortAbleW;
            DataGridView gridInfo = dataGridViewNotSortAbleInfo;
            Color fill = listColor[blok % listColor.Length];
            // Biner
            gridInfo.Rows.Add("Blok-" + blok);
            gridInfo[0, gridInfo.RowCount - 1].Style.BackColor = fill;
            gridInfo.Rows.Add("Biner");
            for (int i = 0; i < messageBlock.Length; i++)
            {
                view[i % 4] = messageBlock[i].ToBin();
                if (i % 4 == 3)
                    gridInfo.Rows.Add(view);
            }
            // Hexa
            gridInfo.Rows.Add("Hexa");
            for (int t = 0; t < 16; t++)
            {
                W[t] = ((uint)messageBlock[t * 4]) << 24;
                W[t] |= ((uint)messageBlock[t * 4 + 1]) << 16;
                W[t] |= ((uint)messageBlock[t * 4 + 2]) << 8;
                W[t] |= ((uint)messageBlock[t * 4 + 3]);
                view[t % 4] = ((int)W[t]).ToHex().PadLeft(8, '0');
                if (t % 4 == 3)
                    gridInfo.Rows.Add(view);
            }
            // W
            grid.Rows.Add("W blok ke-" + blok);
            gridW.Rows.Add("W blok ke-" + blok);
            gridW[0, gridW.RowCount - 1].Style.BackColor = fill;
            int idx = gridW.RowCount;
            for (int t = 0; t < 16; t++)
            {
                grid.Rows.Add("W" + t + " = " + ((int)W[t]).ToHex(8));
                gridW.Rows.Add("W" + t + " = " + ((int)W[t]).ToHex(8));
                gridW[0, idx++].Style.BackColor = fill;
            }
            for (int t = 16; t < 80; t++)
            {
                W[t] = W[t - 3] ^ W[t - 8] ^ W[t - 14] ^ W[t - 16];
                grid.Rows.Add("W[" + t + "] = S1(W[" + (t - 3) + "] ^ W[" + (t - 8) + "] ^ W[" + (t - 14) + "] ^ W[" + (t - 16) + "])");
                grid.Rows.Add("W[" + t + "] = S1(" + ((int)W[t - 3]).ToHex(8) + " ^ " + ((int)W[t - 8]).ToHex(8) + " ^ " + ((int)W[t - 14]).ToHex(8) + " ^ " + ((int)W[t - 16]).ToHex(8) + ")");
                grid.Rows.Add("W[" + t + "] = S1(" + ((int)W[t]).ToHex(8) + ")");
                W[t] = Sn(1, W[t]);
                grid.Rows.Add("W[" + t + "] = " + ((int)W[t]).ToHex(8));
                gridW.Rows.Add("W" + t + " = " + ((int)W[t]).ToHex(8));
                gridW[0, idx++].Style.BackColor = fill;
            }
            A = H[0];
            B = H[1];
            C = H[2];
            D = H[3];
            E = H[4];
            // ABCDE
            grid.Rows.Add("Register");
            grid.Rows.Add("A = H0 = " + ((int)A).ToHex(8));
            grid.Rows.Add("B = H1 = " + ((int)B).ToHex(8));
            grid.Rows.Add("C = H2 = " + ((int)C).ToHex(8));
            grid.Rows.Add("D = H3 = " + ((int)D).ToHex(8));
            grid.Rows.Add("E = H4 = " + ((int)E).ToHex(8));
            // Tabel
            view[0] = "T";
            for (int i = 0; i < 5; i++)
            {
                view[i + 1] = ((char)('A' + i)).ToString();
            }
            grid.Rows.Add();
            grid.Rows.Add("Untuk t = 0 sampai 80");
            grid.Rows.Add("temp = S5(, A) + ft(B,C,D) + E + W[t] + K[t]");
            grid.Rows.Add("E = D");
            grid.Rows.Add("D = C");
            grid.Rows.Add("C = S30(B)");
            grid.Rows.Add("B = A");
            grid.Rows.Add("A = temp");
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
                grid.Rows.Add("H" + i + " = H" + i + " + " + (char)('A' + i) + " = " + ((int)H[i]).ToHex(8));
            }
            grid.Rows.Add();

            blok++;
            messageBlockIndex = 0;
        }

        private void buttonSHA1_Click(object sender, EventArgs e)
        {
            dataGridViewNotSortAbleProses.Rows.Clear();
            dataGridViewNotSortAbleW.Rows.Clear();
            dataGridViewNotSortAbleInfo.Rows.Clear();
            reset();
            DataGridView gridInfo = dataGridViewNotSortAbleInfo;
            string message = textBoxMessage.Text;
            StringBuilder currentBlok = new StringBuilder();
            // Message
            gridInfo.Rows.Add(new string[] { "", "Message", "=", message });
            // H
            gridInfo.Rows.Add("Initial H");
            for (int i = 0; i < H.Length; i++)
            {
                gridInfo.Rows.Add("H" + i + " = " + ((int)H[i]).ToHex(8));
            }
            byte[] _message = Encoding.ASCII.GetBytes(message);
            for (int i = 0; i < _message.Length; i++)
            {
                messageBlock[messageBlockIndex++] = _message[i];
                currentBlok.Append(_message[i].ToBin());

                lengthLow += 8;
                if (lengthLow == 0)
                {
                    lengthHigh++;
                }

                if (messageBlockIndex == 64)
                {
                    gridInfo.Rows.Add();
                    gridInfo.Rows.Add(new string[] { "Blok sekarang", "", "=", currentBlok.ToString() });
                    gridInfo.Rows.Add(new string[] { "Blok = 64 karakter", "proses dulu" });
                    currentBlok.Length = 0;
                    processMessageBlock();
                }
            }
            gridInfo.Rows.Add();
            if (messageBlockIndex > 55)
            {
                gridInfo.Rows.Add(new string[] { "Blok sekarang", "", "=", currentBlok.ToString() });
                gridInfo.Rows.Add(new string[] { "Blok > 55 karakter,", "proses dulu" });
                gridInfo.Rows.Add(new string[] { "Append bit 1, diikuti 0", "sampai 512 bit" });
                currentBlok.Length = 0;
                messageBlock[messageBlockIndex++] = 0x80;
                while (messageBlockIndex < 64)
                {
                    messageBlock[messageBlockIndex++] = 0;
                }

                processMessageBlock();

                gridInfo.Rows.Add();
                gridInfo.Rows.Add(new string[] { "Blok terakhir diisi bit 0", "sampai 448 bit" });
                while (messageBlockIndex < 56)
                {
                    messageBlock[messageBlockIndex++] = 0;
                }
            }
            else
            {
                gridInfo.Rows.Add(new string[] { "Blok sekarang", "", "=", currentBlok.ToString() });
                gridInfo.Rows.Add(new string[] { "Append bit 1, diikuti 0", "sampai 448 bit" });
                messageBlock[messageBlockIndex++] = 0x80;
                while (messageBlockIndex < 56)
                {
                    messageBlock[messageBlockIndex++] = 0;
                }
            }

            gridInfo.Rows.Add(new string[] { "Append ukuran pesan", "64 bit" });
            messageBlock[56] = (byte)((lengthHigh >> 24) & 0xFF);
            messageBlock[57] = (byte)((lengthHigh >> 16) & 0xFF);
            messageBlock[58] = (byte)((lengthHigh >> 8) & 0xFF);
            messageBlock[59] = (byte)((lengthHigh) & 0xFF);
            messageBlock[60] = (byte)((lengthLow >> 24) & 0xFF);
            messageBlock[61] = (byte)((lengthLow >> 16) & 0xFF);
            messageBlock[62] = (byte)((lengthLow >> 8) & 0xFF);
            messageBlock[63] = (byte)((lengthLow) & 0xFF);

            processMessageBlock();

            string[] data = new string[5];
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                result.Append(((int)H[i]).ToHex(8));
            }
            gridInfo.Rows.Add();
            data[2] = "Hasil";
            data[3] = result.ToString();
            gridInfo.Rows.Add(data);
            data[1] = "Hasil dengan";
            data[2] = "built-in library";
            data[3] = getSHA1(message);
            gridInfo.Rows.Add(data);
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
