using System;
using System.Collections.Generic;

// Integer depth
// https://www.codewars.com/kata/59b401e24f98a813f9000026

namespace _12_Integerdepth_180112
{
    class Program
    {
        public static int ComputeDepth_1(int n)
        {
            var intArray = new HashSet<char>(new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
            var i = 1;
            for (; intArray.Count > 0; i++)
            {
                foreach (var c in (i * n).ToString()) intArray.Remove(c);
            }
            return i - 1;
        }
        public static int ComputeDepth(int n)
        {
            string set = "0123456789";
           int i = 0;
            while (set.Length > 0)
            {
                i++;
                var s = (n * i).ToString();
                foreach (var ch in s)
                {
                    int d = set.IndexOf(ch);
                    if (d >= 0)
                    {
                        set = set.Remove(d,1);
                    }
                }
            }
            return i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ComputeDepth(42).ToString());
        }
    }
}
