using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using KriptografiExtensions;

namespace Kriptografi
{
    /// <summary>
    /// Library kriptografi dosen "Drs. Ronsen Purba, M.Sc."
    /// </summary>
    public class KriptografiLibrary
    {
        public static BitArray isPrima = new BitArray(1000001, false);
        private static bool isPrimeGenerated = false;

        /// <summary>
        /// Greatest Common Divisor int
        /// </summary>
        /// <param name="num1">Bilangan 1</param>
        /// <param name="num2">Bilangan 2</param>
        /// <returns></returns>
        public static int GCD(int num1, int num2)
        {
            return (int)GCD((long)num1, (long)num2);
        }

        /// <summary>
        /// Greatest Common Divisor long
        /// </summary>
        /// <param name="num1">Bilangan 1</param>
        /// <param name="num2">Bilangan 2</param>
        /// <returns></returns>
        public static long GCD(long num1, long num2)
        {
            while (num2 > 0)
            {
                long _t = num1 % num2;
                num1 = num2;
                num2 = _t;
            }
            return num1;
        }

        /// <summary>
        /// Least Common Multiple int
        /// </summary>
        /// <param name="num1">Bilangan 1</param>
        /// <param name="num2">Bilangan 2</param>
        /// <returns></returns>
        public static int LCM(int num1, int num2)
        {
            return (num1 / GCD(num1, num2)) * num2;
        }

        /// <summary>
        /// Least Common Multiple long
        /// </summary>
        /// <param name="num1">Bilangan 1</param>
        /// <param name="num2">Bilangan 2</param>
        /// <returns></returns>
        public static long LCM(long num1, long num2)
        {
            return (num1 / GCD(num1, num2)) * num2;
        }

        /// <summary>
        /// Sieve of eratosthenes
        /// </summary>
        public static void Sieve()
        {
            if (!isPrimeGenerated)
            {
                int n = 1000000;
                isPrima[2] = true;
                for (int i = 3; i <= n; i += 2)
                {
                    isPrima[i] = true;
                }
                int sq = (int)Math.Sqrt(n + 1e-6);
                for (int i = 3; i <= sq; i += 2)
                {
                    if (isPrima[i])
                    {
                        for (int j = i * i; j <= n; j += i)
                        {
                            isPrima[j] = false;
                        }
                    }
                }
                isPrimeGenerated = true;
            }
        }

        public static bool IsRelatifPrima(int num1, int num2)
        {
            return GCD(num1, num2) == 1;
        }

        public static bool IsRelatifPrima(long num1, long num2)
        {
            return GCD(num1, num2) == 1;
        }

        /// <summary>
        /// Quick Modulo Method Int
        /// </summary>
        /// <param name="num">Number</param>
        /// <param name="power">Power</param>
        /// <param name="div">Divisor</param>
        /// <returns></returns>
        public static int QuickModulo(int num, int power, int div)
        {
            return (int)QuickModulo((long)num, (long)power, (long)div);
        }

        /// <summary>
        /// Quick Modulo Method Long
        /// </summary>
        /// <param name="num">Number</param>
        /// <param name="power">Power</param>
        /// <param name="div">Divisor</param>
        /// <returns></returns>
        public static long QuickModulo(long num, long power, long div)
        {
            long res = 1;
            long y = num;
            while (power > 0)
            {
                if ((power & 1) == 1)
                {
                    //res = (res * y) % div;
                    res = MultiplyModulo(res, y, div);
                }
                //y = (y * y) % div;
                y = MultiplyModulo(y, y, div);
                power >>= 1;
            }
            return res % div;
        }

        static long[] pangkat = new long[33];
        static long[] angka = new long[33];
        static int c = 0;
        static int lcm = -1;

        private static void PrintExponent(long div, System.Windows.Forms.DataGridView gridProses)
        {
            StringBuilder t = new StringBuilder();
            t.Append("(");
            for (int i = c - 1; i >= 0; i--)
            {
                if (angka[i] > 0)
                {
                    if (pangkat[i] > 1)
                        t.Append(" " + angka[i] + "^" + pangkat[i] + " ");
                    else
                        t.Append(" " + angka[i] + " ");
                    if (i != lcm)
                    {
                        t.Append(".");
                    }
                    else
                    {
                        t.Append(")");
                    }
                }
            }
            t.Append(" % " + div);
            gridProses.Rows.Add(t.ToString());
        }
        public static int FastExponent(int num, int power, int div, System.Windows.Forms.DataGridView gridProses)
        {
            return (int)FastExponent((long)num, (long)power, (long)div, gridProses);
        }

        public static long FastExponent(long num, long power, long div, System.Windows.Forms.DataGridView gridProses)
        {
            c = 0;
            lcm = -1;
            Array.Clear(pangkat, 0, pangkat.Length);
            Array.Clear(angka, 0, angka.Length);
            long t = power;
            while (t > 0)
            {
                if ((t & 1) == 1)
                {
                    if (lcm == -1)
                        lcm = c;
                    pangkat[c] = 1 << c;
                    angka[c] = num;
                }
                t >>= 1;
                c++;
            }
            PrintExponent(div, gridProses);
            while (pangkat[c - 1] != 1)
            {
                t = MultiplyModulo(angka[c - 1], angka[c - 1], div);
                for (int i = 0; i < c; i++)
                {
                    if (pangkat[i] > 1)
                    {
                        pangkat[i] >>= 1;
                        angka[i] = t;
                    }
                }
                PrintExponent(div, gridProses);
            }
            t = 1;
            for (int i = 0; i < c; i++)
            {
                if (pangkat[i] == 1)
                {
                    t = MultiplyModulo(t, angka[i], div);
                }
            }
            return t;
        }

        /// <summary>
        /// Multiply num1 and num2 Modulo N, anticipate overflow
        /// </summary>
        /// <param name="num1">Number 1</param>
        /// <param name="num2">Number 2</param>
        /// <param name="divisor">Divisor</param>
        /// <returns></returns>
        public static long MultiplyModulo(long num1, long num2, long divisor)
        {
            long res = 0;
            long y = num1 % divisor;
            while (num2 > 0)
            {
                if ((num2 & 1) == 1)
                {
                    res = (res + y) % divisor;
                }
                y = (y * 2) % divisor;
                num2 >>= 1;
            }
            return res;
        }

        /// <summary>
        /// Number checker
        /// </summary>
        /// <param name="data">String</param>
        /// <returns></returns>
        public static bool IsNumber(string data)
        {
            Regex hexa = new Regex(@"^0|(-?[1-9][0-9]*)$");
            return hexa.IsMatch(data);
        }

        //*
        /// <summary>
        /// Rabin miller primality test, iteration signifies the accuracy,
        /// source http://community.topcoder.com/tc?module=Static&amp;d1=tutorials&amp;d2=primalityTesting
        /// </summary>
        /// <param name="number">Number to test</param>
        /// <param name="iteration">Number of iteration</param>
        /// <returns></returns>
        public static bool IsMiller(long number, int iteration)
        {
            if (number < 2)
            {
                return false;
            }
            if (number != 2 && number % 2 == 0)
            {
                return false;
            }
            long s = number - 1;
            while ((s & 1) == 0)
            {
                s >>= 1;
            }
            Random rand = new Random();
            for (int i = 0; i < iteration; i++)
            {
                long a = ((long)rand.Next() * (long)rand.Next()) % (number - 1) + 1;
                long temp = s;
                long mod = QuickModulo(a, temp, number);
                while (temp != number - 1 && mod != 1 && mod != number - 1)
                {
                    mod = (mod * mod) % number;
                    temp <<= 1;
                }
                if (mod != number - 1 && (temp & 1) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //*/

        #region "Minggu 2"
        //generator modulo
        //fpb
        //relatif prima
        //invers modulo

        /// <summary>
        /// Check number is generator modulo or not
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="div">Divisor(prime number)</param>
        /// <returns></returns>
        public static bool IsGeneratorModulo(int number, int prime)
        {
            Sieve();
            List<int> faktorPrima = new List<int>();
            int p = prime - 1;
            int sq = (int)Math.Sqrt(p);
            for (int i = 2; i <= sq && p > 1; i++)
            {
                if (isPrima[i] && p % i == 0)
                {
                    faktorPrima.Add(i);
                    while (p % i == 0)
                    {
                        p /= i;
                    }
                }
            }
            if (p > 1)
            {
                faktorPrima.Add(p);
            }
            p = prime - 1;
            bool res = true;
            foreach (int prima in faktorPrima)
            {
                int mod = QuickModulo(number, p / prima, prime);
                res &= (mod > 1);
            }
            return res;
        }

        public static System.Data.DataTable GetPrime(int lower, int upper)
        {
            Sieve();
            System.Data.DataTable list = new System.Data.DataTable();
            list.Columns.Add("Prima");
            for (int i = lower; i <= upper; i++)
            {
                if (isPrima[i]) list.Rows.Add(i);
            }
            return list;
        }

        /// <summary>
        /// Invers modulo of a number
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="divisor">Divisor(prime number)</param>
        /// <returns></returns>
        public static long InversModulo(long number, long divisor)
        {
            if (divisor == 1) return 1;
            long div = divisor;
            long aLast = 0, bLast = 1;
            while (number > 0)
            {
                long mod = divisor / number;
                long x = divisor - (mod * number);
                divisor = number;
                number = x;
                x = aLast - (mod * bLast);
                aLast = bLast;
                bLast = x;
            }
            if (aLast < 0)
                aLast += div;
            return aLast;
        }
        public static long InversModulo(long number, long divisor, System.Windows.Forms.DataGridView gridProses)
        {
            if (divisor == 1) return 1;
            long div = divisor;
            long aLast = 0, bLast = 1;
            int i = 1;
            int col = 0;
            int nCol = gridProses.ColumnCount;
            int nRow = gridProses.RowCount;
            string pers = number + "^-1 % " + divisor + " = ";
            if (i > nCol)
            {
                gridProses.Columns.Add("P" + i, "P" + i);
            }
            i++;
            if (i > nCol)
            {
                gridProses.Columns.Add("P" + i, "P" + i);
            }
            i++;
            if (i > nCol)
            {
                gridProses.Columns.Add("P" + i, "P" + i);
            }
            gridProses.Rows.Add();
            gridProses.Rows.Add(new string[] { "", number.ToString(), divisor.ToString() });
            gridProses.Rows.Add(new string[] { "", "0", "1" });
            while (number > 0)
            {
                col = i;
                i++;
                if (i > nCol)
                {
                    gridProses.Columns.Add("P" + i, "P" + i);
                }
                long mod = divisor / number;
                long x = divisor - (mod * number);

                gridProses[col, nRow].Value = mod;
                gridProses[col, nRow + 1].Value = x;

                divisor = number;
                number = x;
                x = aLast - (mod * bLast);
                aLast = bLast;
                bLast = x;
                if (number != 0)
                    gridProses[col, nRow + 2].Value = bLast;
            }
            if (aLast < 0)
            {
                pers += aLast + " + " + div + " = ";
                aLast += div;
            }
            gridProses.Rows.Add(pers + aLast);
            gridProses.Rows.Add();
            return aLast;
        }

        #endregion

        #region "Minggu 3"
        //Key exchange
        //Fungsi dan invers fungsi
        //GF
        //rabin miller

        /// <summary>
        /// Galios Field Hexa
        /// </summary>
        /// <param name="num1">Number 1</param>
        /// <param name="num2">Number 2</param>
        /// <returns></returns>
        public static string GF_8_Hexa(int num1, int num2)
        {
            return GF_8(num1, num2).ToHex();
        }

        /// <summary>
        /// Galios Field Int
        /// </summary>
        /// <param name="num1">Number 1</param>
        /// <param name="num2">Number 2</param>
        /// <returns></returns>
        public static int GF_8(int num1, int num2)
        {
            int res = 0;
            while (num2 > 0)
            {
                if ((num2 & 1) == 1)
                {
                    res ^= num1;
                }
                num1 <<= 1;
                if ((num1 & 1 << 8) == 1 << 8)
                    num1 ^= 0x011B;
                num2 >>= 1;
            }
            return res;
        }

        /// <summary>
        /// Prime Test Miller
        /// </summary>
        /// <param name="pnP"></param>
        /// <param name="pnA"></param>
        /// <returns></returns>
        public static bool TestPrima(long pnP, long pnA)
        {
            if ((pnP % 2 == 0 && pnP != 2) || pnP < 2)
            {
                return false;
            }
            else
            {
                return IsRabinMiller(pnP, pnA);
            }
        }

        /// <summary>
        /// Rabin Miller
        /// </summary>
        /// <param name="pnP"></param>
        /// <param name="pnA"></param>
        /// <returns></returns>
        public static bool IsRabinMiller(long pnP, long pnA)
        {
            int nTemp;
            long pnC;
            int pnB;
            long pnM;
            long pnJ;
            long pnZ;
            if (pnP == 2)
                return true;
            pnC = pnP - 1;
            nTemp = 0;
            while (pnC % (1 << nTemp) == 0 && (1 << nTemp) < pnP)
            {
                nTemp = nTemp + 1;
            }
            pnB = nTemp - 1;
            pnM = pnC / (1 << pnB);
            pnJ = 0;
            pnZ = QuickModulo(pnA, pnM, pnP);
            if (pnZ == 1 || pnZ == (pnP - 1))
                return true;
            while (true)
            {
                if (pnJ > 0 && pnZ == 1)
                    return false;
                pnJ = pnJ + 1;
                if (pnJ < pnB && pnZ != pnP - 1)
                {
                    pnZ = QuickModulo(pnZ, (long)2, pnP);
                    continue;
                }
                else
                {
                    break;
                }
            }
            if (pnZ == pnP - 1)
                return true;
            if (pnJ == pnB && pnZ != pnP - 1)
                return false;
            return true;
        }

        #endregion

        #region "Minggu 4"
        //Hill Cipher
        //Chinese Remainder Theorem

        //*
        /// <summary>
        /// Chinese Remainder Theorem
        /// </summary>
        /// <param name="number">Array of Number</param>
        /// <param name="divisor">Array of Divisor</param>
        /// <returns></returns>
        public static long ChineseRemainderTheorem(long[] number, long[] divisor)
        {
            try
            {
                if (number.Length > 0 && number.Length == divisor.Length)
                {
                    long a = number[0];
                    long b = divisor[0];
                    long lcm = divisor[0];
                    for (int i = 1; i < number.Length; i++)
                    {
                        long num = number[i];
                        long div = divisor[i];
                        lcm = LCM(lcm, div);
                        long x = num - a;
                        long inv = InversModulo(b, div);
                        x *= inv;
                        x %= div;
                        a += b * x;
                        b *= div;
                    }
                    return a;
                }
                return -1;
            }
            catch (Exception)
            {
                return -1;
                throw;
            }
        }
        //*/

        #endregion
    }

    public class DataGridViewNotSortAble : System.Windows.Forms.DataGridView
    {
        protected override void OnColumnAdded(System.Windows.Forms.DataGridViewColumnEventArgs e)
        {
            base.OnColumnAdded(e);
            e.Column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        }
    }
}
