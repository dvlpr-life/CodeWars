using System;

// Is n divisible by x and y?
// https://www.codewars.com/kata/5545f109004975ea66000086

// Create a function isDivisible(n, x, y) that checks if a number n is divisible by two numbers x AND y. All inputs are positive, non-zero digits.

// // 8 kyu Kata - was emailed as one of theWeekly Coding Challenges (Countdown week 1) 12/05/2018
namespace _29_Is_n_divisible_by_x_and_y_181207
{
    class Program
    {
        public static bool isDivisible(long n, long x, long y)
        {
            return ((x != 0) & (y != 0) ? (n % x == 0) & (n % y == 0) : false);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(isDivisible(3, 1, 3).ToString());
            Console.WriteLine(isDivisible(12, 2, 6).ToString());
            Console.WriteLine(isDivisible(100, 5, 3).ToString());
            Console.WriteLine(isDivisible(12, 7, 8).ToString());
        }
    }
}
