using System;

// Common Denominators
// https://www.codewars.com/kata/54d7660d2daf68c619000d95

namespace _11_CommonDenominators_180111
{
    class Program
    {
        public static long GetLCD(long num1, long num2)
        {
            long a = Math.Max(num1, num2);
            long b = Math.Min(num1, num2);
            long lcm = 1;

            while (b != 0)
            {
                 lcm = b;
                b = a % b;
                a = lcm;
            }
            return ((num1/lcm) * num2);
        }
        public static string convertFrac(long[,] lst)
        {
            long lcd = 1;
            string s = string.Empty;

                if (lst.GetLength(0) == 1)
                {
                    lcd = lst[0,1];
                }
                for (int i = 0; i < lst.GetLength(0) - 1; i++)
                {
                    var l = i == 0 ? GetLCD(lst[i, 1], lst[i + 1, 1]) : GetLCD(lcd, lst[i + 1, 1]);
                    lcd = Math.Max(l, lcd);
                }

                for (int i = 0; i < lst.GetLength(0); i++)
                {
                    s = string.Format("{0}({1},{2})",s, (lcd / lst[i, 1]) * lst[i, 0], lcd.ToString());
                }

            return s;
        }

        static void Main(string[] args)
        {
            long[,] lst = new long[,] { { 1, 2 }, { 1, 3 }, { 1, 4 } };
            Console.WriteLine(convertFrac(lst));

            long [,] lst2 = new long[,] {{69,130},{87, 1310},{3, 4}};
            Console.WriteLine(convertFrac(lst2));

            long[,] lst3 = new long[,] {{ 69, 130 }};
            Console.WriteLine(convertFrac(lst3));

        }
    }
}
