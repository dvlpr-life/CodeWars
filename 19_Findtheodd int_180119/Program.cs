using System;
using System.Linq;

// Find the odd int
// https://www.codewars.com/kata/54da5a58ea159efa38000836

namespace _19_Findtheodd_int_180119
{
    class Program
    {
        public static int find_it(int[] seq)
        {
            var g = seq.GroupBy(x => x).Where(x => (x.Count() % 2 != 0)).Select(x => x.First());

            return g.First();
        }
        static void Main(string[] args)
        {
            // 5
            Console.WriteLine(find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }
    }
}
