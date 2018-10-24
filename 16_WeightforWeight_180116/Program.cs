using System;
using System.Linq;

// Weight for weight
// https://www.codewars.com/kata/55c6126177c9441a570000cc

namespace _16_WeightforWeight_180116
{
    class Program
    {
        public static string orderWeight(string strng)
        {
            String result = String.Join(" ",
                strng.Split(' ').OrderBy(n => n.Sum(ch => ch - '0')).ThenBy(n => n));
            return result;
        }
        static void Main(string[] args)
        {
            // "100 180 90 56 65 74 68 86 99"
            Console.WriteLine(orderWeight("56 65 74 100 99 68 86 180 90"));
            // "2000 103 123 4444 99"
            Console.WriteLine(orderWeight("103 123 4444 99 2000"));
            // "11 11 2000 10003 22 123 1234000 44444444 9999"
            Console.WriteLine(orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
        }
    }
}
