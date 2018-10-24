using System;
using System.Linq;

// Narcissistic Numbers
// https://www.codewars.com/kata/narcissistic-numbers
// This Kata was in Python but completed in C#

namespace _6_NarcissisticNumber_180106
{
    class Program
    {
        public static bool Narcissistic2(int value)
        {
            var s = value.ToString();

            double total = 0;
            foreach (var ch in s)
            {
                total += Math.Pow(Convert.ToInt32(ch.ToString()), s.Length);
            }

            return total == value;
        }

        public static bool Narcissistic(int value)
        {
            double total = 0;
            var s = value.ToString();
            total = s.Select(n => Math.Pow(Convert.ToInt32(n.ToString()), s.Length)).Sum();

            return (total == value);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Narcissistic(153).ToString());
            Console.WriteLine(Narcissistic(1634).ToString());
        }
    }
}
