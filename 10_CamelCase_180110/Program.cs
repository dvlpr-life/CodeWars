using System;
using System.Linq;
using System.Threading;
using System.Globalization;

// CamelCase Method
// https://www.codewars.com/kata/587731fda577b3d1b0001196

namespace _10_CamelCase_180110
{
    class Program
    {
        public static string CamelCase(string str)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            var s = string.Join("", str.Split(' ').Select(x => textInfo.ToTitleCase(x)));
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CamelCase("the dog"));
            Console.WriteLine(CamelCase("cAmEl cAsE"));
        }
    }
}
