using System;
using System.Linq;
using System.Text.RegularExpressions;

// Dubstep
// https://www.codewars.com/kata/551dc350bf4e526099000ae5

namespace Dubstep
{
    class Program
    {
        public static string BestPractice(string input)
        {
            return Regex.Replace(input, "(WUB)+", " ").Trim();
        }
        public static string SongDecoder(string input)
        {
            input = input.Replace("WUB"," ").Trim();

            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            input = regex.Replace(input, " ");

            return input;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SongDecoder("RWUBWUBWUBLWUB"));
        }
    }
}
