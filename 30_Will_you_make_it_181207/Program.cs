using System;

// Will you make it?
// https://www.codewars.com/kata/will-you-make-it

// You were camping with your friends far away from home, but when it's time to go back, you realize that you fuel
// is running out and the nearest pump is 50 miles away! You know that on average, your car runs on about 25 miles
// per gallon. There are 2 gallons left. Considering these factors, write a function that tells you if it is possible
// to get to the pump or not. Function should return true if it is possible and false if not.

// 8 kyu Kata - was emailed as one of theWeekly Coding Challenges (Countdown week 1) 12/05/2018

namespace _30_Will_you_make_it_181207
{
    class Program
    {
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            return (mpg * fuelLeft >= distanceToPump);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ZeroFuel(50, 25, 2).ToString());
            Console.WriteLine(ZeroFuel(100, 50, 1).ToString());
        }
    }
}
