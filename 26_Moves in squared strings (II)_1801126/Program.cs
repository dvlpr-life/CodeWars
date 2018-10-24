using System;
using System.Linq;

// Moves in squared strings (II)
// https://www.codewars.com/kata/56dbe7f113c2f63570000b86

namespace _26_Moves_in_squared_strings__II__1801126
{
    class Program
    {
        public delegate string MyFunction(string strng);
        public static string Rot(string strng)
        {
            // Best Practice
            //  return string.Join("",s.Reverse());

            var st = strng.Split('\n');
            string[] nst = new string[st.Length];
            for (int i = 0; i < st.Length; i++)
            {
                for (int y = st[i].Length - 1; y >= 0 ; y--)
                {
                    nst[st.Length - i - 1] += st[i][y];
                }
            }

            return string.Join("\n", nst);
        }
        public static string SelfieAndRot(string strng)
        {
            // Best Practice
            // return string.Join("\n", s.Split('\n').Select(x => x + new string('.', x.Length)).Concat(
            //   Rot(s).Split('\n').Select(x => new string('.', x.Length) + x)));

            var r = string.Join("\n",Rot(strng).Split('\n').Select(x => new string('.',x.Length) + x));
            var s = string.Join("\n", strng.Split('\n').Select(x => x + new string('.', x.Length)));
            return s + "\n" + r;
        }

        public static string Oper(MyFunction fct, string s)
        {
            return fct(s);
        }
        static void Main(string[] args)
        {
            string s = "abcd\nefgh\nijkl\nmnop";
            Console.WriteLine(s);
            Console.WriteLine("ponm\nlkji\nhgfe\ndcba");
            Console.WriteLine(Oper(Rot,s));
            Console.WriteLine(Oper(SelfieAndRot,s));

        }
    }
}
