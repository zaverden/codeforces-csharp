using System.Linq;

namespace Tests
{
    static class Extensions
    {
        public static int[] ToInts(this string str)
        {
            return str
                .Split(' ')
                .Select(s => int.Parse(s))
                .ToArray();
        }
    }
}
