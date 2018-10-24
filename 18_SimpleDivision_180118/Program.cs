using System;
using System.Linq;
using System.Collections;

// Simple division
// https://www.codewars.com/kata/59ec2d112332430ce9000005

namespace _18_SimpleDivision_180118
{
    class Program
    {
        //var primenumbers = Enumerable.Range(2, b)
        //    .Where(x => Enumerable.Range(2, x - 2)
        //                         .All(y => x % y != 0));

        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number % 2 == 0) return (number == 2);
            //int root = (int)Math.Sqrt((double)number);
            //for (int i = 3; i <= root; i += 2)

            //for (int i = 3; i * i <= number; i += 2)

            for (int i = 3; i <= number/2; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static bool Solve(int a, int b)
        {
            // factors of a number - b
            //var factors = Enumerable.Range(2,b).Where(n => (b % n == 0) && IsPrime(n));
            //var factors = Enumerable.Range(2, b).Where(n => (b % n == 0) && IsPrime(n) && (a % n != 0));
            //var c = factors.Count();
            // prime numbers in factors
            //var primefactors = factors.Where(x => Enumerable.Range(3,(int)(Math.Sqrt(x) + 0.5)).All(y => x % y != 0));
            //var primefactors = factors.Where(x => IsPrime(x));
            // count of prime numbers not divisible by a
            //var c = primefactors.Where(x => a % x != 0).Count();

            //Console.WriteLine(b);
            var c = Enumerable.Range(2, b).Where(n => (b % n == 0) && IsPrime(n) && (a % n != 0)).Count();
            return (c == 0);
        }

        static void Main(string[] args)
        {
            // true
            Console.WriteLine(Solve(2, 256).ToString());
            // false
            Console.WriteLine(Solve(2, 253).ToString());
            // true
            Console.WriteLine(Solve(9, 243).ToString());
            // false
            Console.WriteLine(Solve(15, 12).ToString());
            // true
            Console.WriteLine(Solve(21, 2893401).ToString());
            // false
            Console.WriteLine(Solve(21, 2893406).ToString());
            // true
            Console.WriteLine(Solve(54, 2834352).ToString());
            // false
            Console.WriteLine(Solve(54, 2834359).ToString());
            // true
            Console.WriteLine(Solve(1000013, 7187761).ToString());
            // false
            Console.WriteLine(Solve(1000013, 7187762).ToString());
        }
    }
}
