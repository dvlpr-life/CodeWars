using System;

namespace FindNextSquare
{
    // Find the next perfect square!
    // https://www.codewars.com/kata/56269eb78ad2e4ced1000013

    class Program
    {
        static long BestPractice(long num)
        {
            return System.Math.Sqrt(num) % 1 == 0 ? (long)System.Math.Pow(System.Math.Sqrt(num) + 1, 2) : -1;
        }

        static long FindNextSquare(long num)
        {
            double number = System.Math.Sqrt(num);
            if (System.Math.Round(number) == number)
            {
                number += 1;
                return (long)(number * number);
            }
            else
            {
                return -1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("Number: {0}",FindNextSquare(121)));
        }
    }
}
