using System;
using System.Linq;

namespace ContestSolutions
{
    public static class ProblemA
    {
        private

        static void Main(string[] args)
        {
            int t = ReadInt();
            for (int i = 1; i <= t; i++)
            {
                var parts = Console.ReadLine().Split(' ');
                int? result = Solve(int.Parse(parts[0]), parts[1]);
                Console.WriteLine("Case #{0}: {1}", i, result == null ? "IMPOSSIBLE" : result.ToString());
            }
        }

        public static int? Solve(int d, string progStr)
        {
            char[] prog = progStr.ToArray();

            //do nothing and path
            if (d >= CalcDamage(prog)) return 0;

            //can't do anything
            if (progStr.IndexOf('C') < 0) return null;

            int i = 0;
            while (ReduceDmg(prog))
            {
                i++;
                if (d >= CalcDamage(prog)) return i;
            }
            return null;
        }

        public static int CalcDamage(char[] prog)
        {
            int total = 0;
            int curr = 1;
            foreach (char instruction in prog)
            {
                switch (instruction)
                {
                    case 'C':
                        curr *= 2;
                        break;
                    case 'S':
                        total += curr;
                        break;
                    default:
                        break;
                }
            }

            return total;
        }

        public static bool ReduceDmg(char[] prog)
        {
            for (int i = prog.Length - 1; i > 0; i--)
            {
                if (prog[i] == 'S' && prog[i - 1] == 'C')
                {
                    prog[i] = 'C';
                    prog[i - 1] = 'S';
                    return true;
                }
            }

            return false; // run to first - no replaces
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
