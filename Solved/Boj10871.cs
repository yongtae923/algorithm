using System;
namespace algorithm
{
    class Boj10871
    {
        static void Solution()
        {
            int[] nx = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach (int i in a)
            {
                if (i < nx[1])
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}