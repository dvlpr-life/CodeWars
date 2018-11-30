using System;
using System.Linq;

// Counting sheep...
// https://www.codewars.com/kata/54edbc7200b811e956000556

// Simple 8 kyu Kata - was emailed as one of the Week's Challenges

namespace _27_Counting_Sheep_181129
{
    class Program
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return (sheeps.Count( x => x == true));
        }

        static void Main(string[] args)
        {
            var sheeps1 = new bool[] { true, false, true };
            Console.WriteLine("{0} {1}", "sheeps1", CountSheeps(sheeps1));
        }
    }
}
