using System;
using System.Linq;

// Best Parking Spot
// https://www.codewars.com/kata/5859aaf04facfeb0d4002051

namespace _17_Best_Parking_Spot_180117
{
    class Program
    {
        public static int BestParkingSpot(string[] arr)
        {
            int[] o = arr.Select((b, i) => b == "OPEN" ? i : -1).Where(i => i != -1).ToArray();
            int[] c = arr.Select((b, i) => b == "CORRAL" ? i : -1).Where(i => i != -1).ToArray();

            int[] v = new int[o.Length];

            for (int i = 0; i < o.Length; i++)
            {
                for (int p = 0; p < c.Length; p++)
                {
                    // calculate steps and store open spot index
                    v[i] = v[i] == 0 ? Math.Abs(c[p] - o[i]) + o[i] : Math.Min(v[i], Math.Abs(c[p] - o[i]) + o[i]);
                }
            }

            int x = Array.LastIndexOf(v, v.Min());
            return o[x];
        }

        static void Main(string[] args)
        {
            // 1
            Console.WriteLine(BestParkingSpot(new string[] { "STORE", "OPEN", "CORRAL" }).ToString());
            // 3
            Console.WriteLine(BestParkingSpot(new string[] { "STORE", "OPEN", "TAKEN", "OPEN", "CORRAL" }).ToString());
            // 4
            Console.WriteLine(BestParkingSpot(new string[] { "STORE", "TAKEN", "CORRAL", "TAKEN", "OPEN", "CORRAL", "OPEN" }).ToString());
            // 5
            Console.WriteLine(BestParkingSpot(new string[] { "STORE", "TAKEN", "TAKEN", "CORRAL", "TAKEN", "OPEN", "OPEN", "TAKEN", "CORRAL" }).ToString());
            // 3
            Console.WriteLine(BestParkingSpot(new string[] { "STORE", "CORRAL", "TAKEN", "OPEN", "TAKEN", "TAKEN", "OPEN", "CORRAL", "OPEN" }).ToString());
            // 4
            Console.WriteLine(BestParkingSpot(new string[] { "STORE", "OPEN", "OPEN", "OPEN", "OPEN", "CORRAL", "OPEN" }).ToString());
            // 6
            Console.WriteLine(BestParkingSpot(new string[] { "STORE", "TAKEN", "TAKEN", "TAKEN", "TAKEN", "CORRAL", "OPEN" }).ToString());
        }
    }
}
