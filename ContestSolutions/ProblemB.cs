using System;
using System.Collections.Generic;
using System.Linq;

namespace ContestSolutions
{
    public static class ProblemB
    {
        static void Main(string[] args)
        {
            int t = ReadInt();
            for (int i = 1; i <= t; i++)
            {
                int n = ReadInt();
                int[] arr = ReadInts();
                int? result = Solve(arr);
                Console.WriteLine("Case #{0}: {1}", i, result == null ? "OK" : result.ToString());
            }
        }

        public static int? Solve(int[] arr)
        {
            var odds = new List<int>(arr.Length / 2 + 1);
            var evens = new List<int>(arr.Length / 2 + 1);
            for (int i = 0; i < arr.Length; i += 2)
            {
                evens.Add(arr[i]);
            }
            for (int i = 1; i < arr.Length; i += 2)
            {
                odds.Add(arr[i]);
            }
            evens.Sort();
            odds.Sort();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                arr[2 * i] = evens[i];
                arr[2 * i + 1] = odds[i];
            }

            if (evens.Count > odds.Count)
            {
                arr[arr.Length - 1] = evens[evens.Count - 1];
            }

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] > arr[i]) return i - 1;
            }

            return null;
        }

        #region helpers
        static int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }
        static int[] ReadInts()
        {
            int[] arr = Console.ReadLine().Split(' ')
                .Select(s => int.Parse(s))
                .ToArray();
            return arr;
        }
        static void ReadInts(out int i0, out int i1)
        {
            int[] arr = ReadInts();
            i0 = arr[0];
            i1 = arr[1];
        }
        static void ReadInts(out int i0, out int i1, out int i2)
        {
            int[] arr = ReadInts();
            i0 = arr[0];
            i1 = arr[1];
            i2 = arr[2];
        }
        static void WriteYesNo(bool value)
        {
            Console.WriteLine(value ? "YES" : "NO");
        }
        #endregion helpers
    }
}
