using System;

namespace algorithm
{
    class Boj2908
    {
        static void Solution()
        {
            string[] s = Console.ReadLine().Split();

            char[] c0 = s[0].ToCharArray();
            Array.Reverse(c0);
            string s0 = new string(c0);
            int i0 = int.Parse(s0);

            char[] c1 = s[1].ToCharArray();
            Array.Reverse(c1);
            string s1 = new string(c1);
            int i1 = int.Parse(s1);

            Console.WriteLine(i0 > i1 ? i0 : i1);
        }
    }
}