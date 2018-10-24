using System;
using System.Linq;

// Bit Counting
// https://www.codewars.com/kata/526571aae218b8ee490006f4

namespace _3_Bit_Counting
{
    class Program
    {
        public static int BestPratice(int n)
        {
            return Convert.ToString(n, 2).Count(x => x == '1');
        }

        public static int CountBits(int n)
        {

            int r = 0;
            string binary = string.Empty;

            while (n != 0)
            {
                r = n % 2;
                n /= 2;
                binary = r.ToString() + binary;
            }

            return binary.ToCharArray().Count(c => c == '1');
        }
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("{0}",CountBits(1234).ToString()));
        }
    }
}
