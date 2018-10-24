using System;
using System.Linq;
using System.Globalization;
using System.Threading;
using System.Text.RegularExpressions;

//
//
// This Kata was done in C#, however it was a JavaScript Kata
//
//

namespace _11_ChangeCase_180111
{
    class Program
    {
        public static String toSentenceCase(String str)
        {
            var r = new Regex (@"(^[a-z])|(\.|\!|\?)\s+(.)", RegexOptions.ExplicitCapture);
            var result = r.Replace(str.ToLower(), s => s.Value.ToUpper());
            return result;
        }

        public static String toLowerCase(String str)
        {
            return str.ToLower();
        }

        public static String toUpperCase(String str)
        {
            return str.ToUpper();
        }

        public static String capitalizeEachWord(String str)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(str);
        }

        public static String toToggleCase(String str)
        {
            var result = str.Select(c => (c == char.ToUpper(c)) ? char.ToLower(c) : char.ToUpper(c));
            return string.Join("",result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(toSentenceCase("hello. world! hello. world? hello."));
            Console.WriteLine(toLowerCase("Hello World"));
            Console.WriteLine(toUpperCase("Hello World"));
            Console.WriteLine(capitalizeEachWord("Hello World"));
            Console.WriteLine(toToggleCase("Hello World"));
        }
    }
}
