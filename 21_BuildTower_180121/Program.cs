using System;
using System.Linq;

namespace _21_BuildTower_180121
{
    // Build Tower
    // https://www.codewars.com/kata/576757b1df89ecf5bd00073b

    class Program
    {
        public static string[] TowerBuilder(int nFloors)
        {
            string[] tower = new string[nFloors];
            // Get odd numbers for base
            var o = Enumerable.Range(1, nFloors * 2).Where(n => n % 2 != 0);
            // Get last odd number for width
            int width = o.Last();

            for (int i = 0; i < nFloors; i++)
            {
                tower[i] = string.Format("{0}{1}{0}",new string(' ',(width - o.ElementAt(i)/2)),new string ('*',o.ElementAt(i)));
            }
            return tower;
        }

        static void Main(string[] args)
        {
            // '*'
            Console.WriteLine(string.Join(",", TowerBuilder(1)));
            // ' * ','***'
            Console.WriteLine(string.Join(",", TowerBuilder(2)));
            //   '  *  ',' *** ','*****'
            Console.WriteLine(string.Join(",", TowerBuilder(3)));
            //   '     *     ','    ***    ','   *****   ','  *******  ',' ********* ','***********'
            Console.WriteLine(string.Join(",", TowerBuilder(6)));

        }
    }
}
