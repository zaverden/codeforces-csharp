using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContestSolutions
{
    public static class ProblemD
    {
        static void Main(string[] args)
        {
            int n = ReadInt();
            var result = Solve(n);
            WriteYesNo(result);
        }

        public static bool Solve(int n)
        {
            return true;
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
