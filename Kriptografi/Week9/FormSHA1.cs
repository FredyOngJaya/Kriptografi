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
            for (int i = 1; i <= 6; i++)
                dataGridViewNotSortAbleInfo.Columns.Add("I" + i, "I" + i);
            dataGridViewNotSortAbleProses.Columns.Add("P1", "P1");
            dataGridViewNotSortAbleK.Rows.Add("K(0 <= t < 20) = " + getK(0).ToHex(8));
            dataGridViewNotSortAbleK.Rows.Add("K(20 <= t < 40) = " + getK(20).ToHex(8));
            dataGridViewNotSortAbleK.Rows.Add("K(40 <= t < 60) = " + getK(40).ToHex(8));
            dataGridViewNotSortAbleK.Rows.Add("K(60 <= t < 80) = " + getK(60).ToHex(8));
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
                view[t % 4] = W[t].ToHex(8);
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
                grid.Rows.Add("W" + t + " = " + W[t].ToHex(8));
                gridW.Rows.Add("W" + t + " = " + W[t].ToHex(8));
                gridW[0, idx++].Style.BackColor = fill;
            }
            for (int t = 16; t < 80; t++)
            {
                W[t] = W[t - 3] ^ W[t - 8] ^ W[t - 14] ^ W[t - 16];
                grid.Rows.Add("W[" + t + "] = S1(W[" + (t - 3) + "] ^ W[" + (t - 8) + "] ^ W[" + (t - 14) + "] ^ W[" + (t - 16) + "])");
                grid.Rows.Add("W[" + t + "] = S1(" + W[t - 3].ToHex(8) + " ^ " + W[t - 8].ToHex(8) + " ^ " + W[t - 14].ToHex(8) + " ^ " + W[t - 16].ToHex(8) + ")");
                grid.Rows.Add("W[" + t + "] = S1(" + W[t].ToHex(8) + ")");
                W[t] = Sn(1, W[t]);
                grid.Rows.Add("W[" + t + "] = " + W[t].ToHex(8));
                gridW.Rows.Add("W" + t + " = " + W[t].ToHex(8));
                gridW[0, idx++].Style.BackColor = fill;
            }
            A = H[0];
            B = H[1];
            C = H[2];
            D = H[3];
            E = H[4];
            // ABCDE
            grid.Rows.Add("Register");
            grid.Rows.Add("A = H0 = " + A.ToHex(8));
            grid.Rows.Add("B = H1 = " + B.ToHex(8));
            grid.Rows.Add("C = H2 = " + C.ToHex(8));
            grid.Rows.Add("D = H3 = " + D.ToHex(8));
            grid.Rows.Add("E = H4 = " + E.ToHex(8));
            // Tabel
            view[0] = "T";
            for (int i = 0; i < 5; i++)
            {
                view[i + 1] = ((char)('A' + i)).ToString();
            }
            grid.Rows.Add();
            grid.Rows.Add("Untuk t = 0 sampai 80");
            grid.Rows.Add("temp = S5(A) + ft(B,C,D) + E + W[t] + K[t]");
            grid.Rows.Add("E = D");
            grid.Rows.Add("D = C");
            grid.Rows.Add("C = S30(B)");
            grid.Rows.Add("B = A");
            grid.Rows.Add("A = temp");
            gridInfo.Rows.Add(view);
            for (int t = 0; t < 80; t++)
            {
                uint S5A = Sn(5, A);
                grid.Rows.Add();
                grid.Rows.Add("t = " + t);
                grid.Rows.Add("S5(A) = S5(" + A.ToHex(8) + ") = " + S5A.ToHex(8));
                uint ft = fBCD(t, B, C, D, grid);
                uint temp = S5A + ft + E + W[t] + getK(t);
                uint S30B = Sn(30, B);
                grid.Rows.Add("temp = " + S5A.ToHex(8) + " + " + ft.ToHex(8) + " + " + E.ToHex(8) + " + " + W[t].ToHex(8) + " + " + getK(t).ToHex(8) + " = " + temp.ToHex(8));
                grid.Rows.Add("E = D = " + D.ToHex(8));
                grid.Rows.Add("D = C = " + C.ToHex(8));
                grid.Rows.Add("C = S30(B) = S30(" + B.ToHex(8) + ") = " + S30B.ToHex(8));
                grid.Rows.Add("B = A = " + A.ToHex(8));
                grid.Rows.Add("A = temp = " + temp.ToHex(8));
                E = D;
                D = C;
                C = S30B;
                B = A;
                A = temp;
                view[0] = t.ToString();
                view[1] = A.ToHex(8);
                view[2] = B.ToHex(8);
                view[3] = C.ToHex(8);
                view[4] = D.ToHex(8);
                view[5] = E.ToHex(8);
                gridInfo.Rows.Add(view);
            }
            H[0] += A;
            H[1] += B;
            H[2] += C;
            H[3] += D;
            H[4] += E;
            for (int i = 0; i < H.Length; i++)
            {
                grid.Rows.Add("H" + i + " = H" + i + " + " + (char)('A' + i) + " = " + H[i].ToHex(8));
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
            gridInfo.Rows.Add(new string[] { "", "", "Message", "", "=", message });
            // H
            gridInfo.Rows.Add("Initial H");
            for (int i = 0; i < H.Length; i++)
            {
                gridInfo.Rows.Add("H" + i + " = " + H[i].ToHex(8));
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
                    gridInfo.Rows.Add(new string[] { "Blok sekarang", "", "", "=", "", currentBlok.ToString() });
                    gridInfo.Rows.Add(new string[] { "Blok = 64 karakter", "proses dulu" });
                    currentBlok.Length = 0;
                    processMessageBlock();
                }
            }
            gridInfo.Rows.Add();
            gridInfo.Rows.Add(new string[] { "Blok sekarang", "", "", "=", "", currentBlok.ToString() });
            if (messageBlockIndex > 55)
            {
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

            string[] data = new string[6];
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                result.Append(H[i].ToHex(8));
            }
            gridInfo.Rows.Add();
            data[4] = "Hasil";
            data[5] = result.ToString();
            gridInfo.Rows.Add(data);
            data[3] = "Hasil dengan";
            data[4] = "built-in library";
            data[5] = Kripto.getSHA1(message);
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

        private uint fBCD(int t, uint B, uint C, uint D, DataGridView grid)
        {
            uint res = 0;
            if (t < 20)
            {
                res =  (B & C) | ((~B) & D);
                grid.Rows.Add("f" + t + "(B,C,D) = (" + B.ToHex(8) + " & " + C.ToHex(8) + ") | (" + (~B).ToHex(8) + " & " + D.ToHex(8) + ") = " + res.ToHex(8));
            }
            else if (t < 40)
            {
                res = B ^ C ^ D;
                grid.Rows.Add("f" + t + "(B,C,D) = " + B.ToHex(8) + " ^ " + C.ToHex(8) + " ^ " + D.ToHex(8) + " = " + res.ToHex(8));
            }
            else if (t < 60)
            {
                res = (B & C) | (B & D) | (C & D);
                grid.Rows.Add("f" + t + "(B,C,D) = (" + B.ToHex(8) + " & " + C.ToHex(8) + ") | (" + B.ToHex(8) + " & " + D.ToHex(8) + ") | (" + C.ToHex(8) + " & " + D.ToHex(8) + ") = " + res.ToHex(8));
            }
            else
            {
                res = B ^ C ^ D;
                grid.Rows.Add("f" + t + "(B,C,D) = " + B.ToHex(8) + " ^ " + C.ToHex(8) + " ^ " + D.ToHex(8) + " = " + res.ToHex(8));
            }
            return res;
        }

        private uint Sn(int n, uint num)
        {
            return (num << n) | (num >> (32 - n));
        }
    }
}
