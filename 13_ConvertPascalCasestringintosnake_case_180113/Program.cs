using System;
using System.Linq;
using System.Text.RegularExpressions;

// Convert PascalCase string into snake_case
// https://www.codewars.com/kata/529b418d533b76924600085d

namespace _13_ConvertPascalCasestringintosnake_case_180113
{
    class Program
    {
        public static string BP_ToUnderscore(int str) => str.ToString();
        public static string BP_ToUnderscore(string str) => String.Join("_", Regex.Split(str, "(?=[A-Z])").Skip(1)).ToLower();

        public static string ToUnderscore(int str)
        {
            return str.ToString();
        }

        public static string ToUnderscore(string str)
        {
            var r = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z][0-9]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z0-9])(?=[^A-Za-z0-9])", RegexOptions.IgnorePatternWhitespace);

            return r.Replace(str, "_").ToLower();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("{0} - {1}","test_controller", ToUnderscore("TestController")));
            Console.WriteLine(String.Format("{0} - {1}", "this_is_beautiful_day", ToUnderscore("ThisIsBeautifulDay")));
            Console.WriteLine(String.Format("{0} - {1}", "am7_days", ToUnderscore("Am7Days")));
            Console.WriteLine(String.Format("{0} - {1}", "my3_code_is4_times_better", ToUnderscore("My3CodeIs4TimesBetter")));
            Console.WriteLine(String.Format("{0} - {1}", "arbitrarily_sending_different_types_to_functions_makes_katas_cool", ToUnderscore("ArbitrarilySendingDifferentTypesToFunctionsMakesKatasCool")));
            Console.WriteLine(String.Format("{0} - {1}", "1", ToUnderscore(1)));


        }
    }
}
