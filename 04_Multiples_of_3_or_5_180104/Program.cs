using System;
using System.Linq;

// Multiples of 3 or 5
// https://www.codewars.com/kata/514b92a657cdc65150000006

namespace _4_Multiples_of_3_or_5_180104
{
    class Program
    {
        public static int Solution(int value)
        {
            var numbers = Enumerable.Range(0, value);
            int total = numbers.Where(n => (n % 5 == 0) || (n % 3 == 0)).Sum();
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(10).ToString());
        }
    }
}
