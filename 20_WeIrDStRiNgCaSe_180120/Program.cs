using System;
using System.Linq;

// WeIrD StRiNg CaSe
// https://www.codewars.com/kata/52b757663a95b11b3d00062d

namespace _20_WeIrDStRiNgCaSe_180120
{
    class Program
    {
        public static string ToWeirdCase(string s)
        {
            var st = string.Join(" ",s
                .Split(' ')
                .Select(sub => string.Join("",sub
                .Select((ch,i) =>i % 2 == 0 ? char.ToUpper(ch) : char.ToLower(ch)))));

            return st;
        }

        static void Main(string[] args)
        {
            // "ThIs"
            Console.WriteLine(ToWeirdCase("This"));
            // "Is"
            Console.WriteLine(ToWeirdCase("is"));
            // "ThIs Is A TeSt"
            Console.WriteLine(ToWeirdCase("This is a test"));
        }
    }
}
