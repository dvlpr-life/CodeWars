using System;
using System.Linq;
using System.Collections.Generic;

// GA-DE-RY-PO-LU-KI cypher vol 3 - Missing key
// https://www.codewars.com/kata/592bdf59912f2209710000e9

namespace _25_GA_DE_RY_PO_LU_KI_cypher_vol_3___Missing_key_180125
{
    class Program
    {
    public static string FindTheKey(string[] messages , string[] secrets)
    {
        List<string> keys = new List<string>();
        for (int i = 0; i < messages.Length; i++)
        {
            for (int c = 0; c < messages[i].Length; c++)
            {
                if (messages[i][c] != secrets[i][c])
                {
                    string s = messages[i][c].ToString() + secrets[i][c].ToString();
                    s = string.Join("",(messages[i][c].ToString() + secrets[i][c].ToString()).Select(k => k).OrderBy(k=>k).ToArray());
                    if (!keys.Contains(s))
                    { keys.Add(s);}
                }
            }
        }

       var v = string.Join("",keys.Select(k => k).OrderBy(k => k).ToArray());
       return v;
    }

        static void Main(string[] args)
        {
            string[] messages = { "dance on the table", "hide my beers", "scouts rocks" };
            string[] secretes = { "egncd pn thd tgbud", "hked mr bddys", "scplts ypcis" };
            Console.WriteLine("agdeikluopry");
            Console.WriteLine(FindTheKey(messages, secretes));
        }
    }
}
