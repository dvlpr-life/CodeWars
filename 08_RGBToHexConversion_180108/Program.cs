using System;

// RGB To Hex Conversion
// https://www.codewars.com/kata/513e08acc600c94f01000001

namespace _8_RGBToHexConversion_180108
{
    class Program
    {
        public static string Rgb(int r, int g, int b)
        {
            return String.Format("{0}{1}{2}",
                Math.Min(Math.Max(0, r), 255).ToString("X2"),
                Math.Min(Math.Max(0, g), 255).ToString("X2"),
                Math.Min(Math.Max(0, b), 255).ToString("X2"));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Rgb(12,-20,295));
        }
    }
}
