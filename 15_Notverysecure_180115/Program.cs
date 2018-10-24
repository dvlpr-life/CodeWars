using System;
using System.Text.RegularExpressions;

// Not very secure
// https://www.codewars.com/kata/526dbd6c8c0eb53254000110

namespace _15_Notverysecure_180115
{
    class Program
    {
        public static bool Alphanumeric(string str)
        {
            var r = new Regex(@"^[a-zA-Z0-9]+$",RegexOptions.IgnorePatternWhitespace);
            return r.IsMatch(str);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Alphanumeric("Mazinkaiser").ToString()); //True
            Console.WriteLine(Alphanumeric("hello world_").ToString()); //False
            Console.WriteLine(Alphanumeric("PassW0rd").ToString()); // True
            Console.WriteLine(Alphanumeric("     ").ToString()); // False
            Console.WriteLine(Alphanumeric("A").ToString()); // False


        }
    }
}
