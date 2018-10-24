using System;
using System.Linq;

// Which are in?
// https://www.codewars.com/kata/550554fd08b86f84fe000a58

namespace _9_Which_are_in_180109
{
    class Program
    {
        static string[] inArray(string[] array1, string[] array2)
        {
           var list1 = array1.ToList();
           var list2 = array2.ToList();

            //var results = list1.Where(x => list2.Contains(x, StringComparer.OrdinalIgnoreCase));
            var results = list1.Where(s => (list2.Count(y => y.Contains(s)) > 0));

            return results.OrderBy(x => x).ToArray();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(inArray(new string[] { "live","arp", "strong" },new string[] { "lively", "alive", "arp", "harp", "armstrong" }).ToString());
        }
    }
}
