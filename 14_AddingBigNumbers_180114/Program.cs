using System;
using System.Numerics;

// Adding Big Numbers
// https://www.codewars.com/kata/525f4206b73515bffb000b21

namespace _14_AddingBigNumbers_180114
{
    class Program
    {
        public static string Add(string a, string b)
        {
            BigInteger bigA = 0;
            BigInteger bigB = 0;

            BigInteger.TryParse(a,out bigA);
            BigInteger.TryParse(b,out bigB);

            return (bigA + bigB).ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("{0} {1}","1099", Add("999","100")));

        }
    }
}
