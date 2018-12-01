using System;

// Calculate Meal Total
// https://www.codewars.com/kata/calculate-meal-total

// Create a function that returns the total of a meal including tip and tax. You should not tip on the tax.
// You will be given the subtotal, the tax as a percentage and the tip as a percentage.Please round your result to two decimal places.

// 7 kyu Kata - was emailed as one of the Weekly Code Challenges 11/29/2018

namespace _28_Calculate_Meal_Total_181201
{
    class Program
    {
        public static double CalculateTotal(double subtotal, int tax, int tip)
        {
            return (Math.Round(subtotal + (subtotal * (tax / 100.00)) + (subtotal * (tip / 100.00)), 2));
        }

        static void Main(string[] args)
        {
            // 5.75
            Console.WriteLine("{0}", CalculateTotal(5.00, 5, 10));
            // 45.10
            Console.WriteLine("{0}", CalculateTotal(36.97, 7, 15));
        }
    }
}
