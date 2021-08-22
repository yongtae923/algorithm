using System;
namespace algorithm
{
    class Boj18111
    {
        static void Solution()
        {
            int[] nmb = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[,] ground =  new int[nmb[0], nmb[1]];
            for (int n = 0; n < nmb[0]; n++)
            {
                int[] line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int m = 0; m < nmb[1]; m++)
                {
                    ground[n, m] = line[m];
                }
            }

            int minTime = int.MaxValue, floor = 0, time, min, max;
            for (int i = 0; i < 257; i++)
            {
                max = 0; min = 0;
                for (int n = 0; n < nmb[0]; n++)
                {
                    for (int m = 0; m < nmb[1]; m++)
                    {
                        if (ground[n, m] < i)
                        {
                            min += (i - ground[n, m]);
                        }
                        else
                        {
                            max += (ground[n, m] - i);
                        }
                    }
                }

                if (max + nmb[2] < min)
                {
                    continue;
                }

                time = 2 * max + min;
                if (time <= minTime)
                {
                    minTime = time;
                    floor = i;
                }
            }
            
            Console.WriteLine($"{minTime} {floor}");
        }
    }
}