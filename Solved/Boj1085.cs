using System;
namespace algorithm
{
    class Boj1085
    {
        static void Solution()
        {
            int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            num[2] = num[2] - num[0];
            num[3] = num[3] - num[1];

            int min = int.MaxValue;
            foreach (int i in num)
            {
                if (i < min)
                {
                    min = i;
                }
            }

            Console.WriteLine(min);
        }
    }
}