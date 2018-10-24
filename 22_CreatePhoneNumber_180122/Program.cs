using System;

// Create Phone Number
// https://www.codewars.com/kata/525f50e3b73515a6db000b83

namespace _22_CreatePhoneNumber_180122
{
    class Program
    {
        public static string CreatePhoneNumber(int[] numbers) =>
            string.Format(@"({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",
                numbers[0],numbers[1],numbers[2],numbers[3],numbers[4],numbers[5],numbers[6],numbers[7],numbers[8],numbers[9]);

        static void Main(string[] args)
        {
            // "(123) 456-7890"
            Console.WriteLine(CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0}));
            // "(111) 111-1111"
            Console.WriteLine(CreatePhoneNumber(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
        }
    }
}
