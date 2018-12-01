using System;
using System.Linq;

// Counting sheep...
// https://www.codewars.com/kata/54edbc7200b811e956000556

// Consider an array of sheep where some sheep may be missing from their place.We need a function that counts the number of sheep present in the array (true means present).
// For example,
// [true, true, true, false,
//   true, true, true, true,
//   true, false, true, false,
//   true, false, false, true,
//   true, true, true, true,
//   false, false, true, true]
// The correct answer would be 17.

// Simple 8 kyu Kata - was emailed as one of the Weekly Code Challenges 11/29/2018

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
