using System;
using System.Collections.Generic;

namespace algorithm
{
    class Boj3052
    {
        static void Solution()
        {
            SortedSet<int> hset = new SortedSet<int>();

            for (int i = 0; i < 10; i++)
            {
            int num = int.Parse(Console.ReadLine());
            hset.Add(num % 42);
            }

            Console.WriteLine(hset.Count);
        }
    }
}