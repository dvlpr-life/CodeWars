using System;

// Band name generator
// https://www.codewars.com/kata/59727ff285281a44e3000011

namespace _7_BandNameGenerator_180107
{
    static class Program
    {
        public static string BandNameGenerator(string str)
        {
            string bandName = (str.ToUpper().EndsWith(str[0].ToString().ToUpper()))
                ? string.Format("{0}{1}{1}", str[0].ToString().ToUpper(),str.Substring(1).ToLower())
                : string.Format("The {0}{1}", str[0].ToString().ToUpper(), str.Substring(1).ToLower());
            return bandName;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(BandNameGenerator("knife"));
            Console.WriteLine(BandNameGenerator("alaska"));
        }
    }
}
