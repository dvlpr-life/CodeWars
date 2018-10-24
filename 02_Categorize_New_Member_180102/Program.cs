using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

// Categorize New Member
// https://www.codewars.com/kata/5502c9e7b3216ec63c0001aa

namespace _2_Categorize_New_Member
{
    class Kata
    {
        static IEnumerable<string> BestPractice(int[][] data)
        {
            return data.Select(member => member[0] >= 55 && member[1] > 7 ? "Senior" : "Open").ToList();
        }
        static IEnumerable<string> OpenOrSenior(int[][] data)
        {

            string[] memberResult = new string[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                int[] member = data[i];
                memberResult[i] = (member[0] < 55) | ((member[0] >= 55) && (member[1] <= 7))  ? "Open" : "Senior";
            }
            return memberResult;
        }

        static void Main(string[] args)
        {

           IEnumerable<string> Result = OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 7 }, new[] { 91, -2 }, new[] { 54, 23 } });

            foreach (var member in Result)
            {
                Console.WriteLine(member);
            }
        }
    }
}
