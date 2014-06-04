using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KriptografiExtensions
{
    public static class KriptoExtensions
    {
        public static string ToHex(this int number)
        {
            return number.ToString("X2");
        }
        public static string ToHex(this int number, int hexLength)
        {
            return number.ToString("X2").PadLeft(hexLength, '0');
        }

        public static string ToBin(this int number)
        {
            return Convert.ToString(number, 2);
        }

        public static string ToBin(this int number, int binLength)
        {
            return number.ToBin().PadLeft(binLength, '0');
        }

        public static string ToHex(this long number)
        {
            return number.ToString("X2");
        }

        public static string ToBin(this long number)
        {
            return Convert.ToString(number, 2);
        }

        public static string ToBin(this long number, int binLength)
        {
            return number.ToBin().PadLeft(binLength, '0');
        }

        public static string ToHex(this ulong number)
        {
            return number.ToString("X2");
        }

        public static string ToBin(this ulong number)
        {
            return ToBin((long)number);
        }

        public static string ToBin(this ulong number, int binLength)
        {
            return number.ToBin().PadLeft(binLength, '0');
        }

        public static string ToBin(this byte number)
        {
            return Convert.ToString(number, 2).PadLeft(8, '0');
        }

        public static int BinToInt(this string binary)
        {
            return Convert.ToInt32(binary, 2);
        }

        public static ulong BinToUlong(this string binary)
        {
            return Convert.ToUInt64(binary, 2);
        }

        public static int HexToInt(this string hexa)
        {
            return int.Parse(hexa, System.Globalization.NumberStyles.HexNumber);
        }

        public static string BinToHex(this string binary)
        {
            return binary.BinToInt().ToHex();
        }

        public static string HexToBin(this string hexa)
        {
            return hexa.HexToInt().ToBin();
        }
    }
}
