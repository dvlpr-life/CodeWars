using System;
using System.Linq;

// Moves in squared strings (III)
// https://www.codewars.com/kata/56dbeec613c2f63be4000be6

namespace _23_Movesinsquared_strings_III__180123
{
    class Program
    {
        public delegate string MyFunction(string strng);
        public static string Rot90Clock(string strng)
        {
            var st = strng.Split('\n');
            string[] nst = new string[st.Length];
            for (int i = 0; i < st.Length; i++)
            {
                for (int y = 0; y < st.Length; y++)
                {
                    nst[i] += st[st.Length - 1 - y][i];
                }
            }

        return string.Join("\n",nst);
        }

        public static string Diag1Sym(string strng)
        {
            var st = strng.Split('\n');
            string[] nst = new string[st.Length];
            for (int i = 0; i < st.Length; i++)
            {
                for (int y = 0; y < st.Length; y++)
                {
                    nst[i] += st[y][i];
                }
            }

            return string.Join("\n", nst);
        }

        public static string SelfieAndDiag1(string strng)
        {
            var selfie = strng.Split('\n');
            var diag1 = Diag1Sym(strng).Split('\n');
            string[] nst = new string[selfie.Length];
            for (int i = 0; i < selfie.Length; i++)
            {
                nst[i] = string.Format("{0}|{1}",selfie[i],diag1[i]);
            }
            return string.Join("\n",nst);
        }

        public static string Oper(MyFunction fct, string s)
        {
            return fct(s);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Fixed Tests Rot90Clock");
            Console.WriteLine("Sixdvr\ndJNCGg\nmBWhca\nEYgZEv\nKDXVKc\nbORWle");
            Console.WriteLine("");
            Console.WriteLine(Oper(Rot90Clock,"rgavce\nvGcEKl\ndChZVW\nxNWgXR\niJBYDO\nSdmEKb"));

            Console.WriteLine("Fixed Tests Diag1Sym");
            Console.WriteLine("wuUyPC\neNHWxw\nehifmi\ntBTlFI\nvWNpdv\nIFkGjZ");
            Console.WriteLine("");
            Console.WriteLine(Oper(Diag1Sym,
                    "weetvI\nuNhBWF\nUHiTNk\nyWflpG\nPxmFdj\nCwiIvZ"));
            Console.WriteLine("");
            Console.WriteLine("Fixed Tests SelfieAndDiag1");
            Console.WriteLine("NJVGhr|NMtsrz\nMObsvw|JOPotj\ntPhCtl|VbhEQl\nsoEnhi|GsCnRi\nrtQRLK|hvthLW\nzjliWg|rwliKg");
            Console.WriteLine("");
            Console.WriteLine(Oper(SelfieAndDiag1,"NJVGhr\nMObsvw\ntPhCtl\nsoEnhi\nrtQRLK\nzjliWg"));
        }
    }
}
