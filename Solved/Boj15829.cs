using System;
namespace algorithm
{
    class Boj15829
    {
        static void Solution()
        {
            int num = int.Parse(Console.ReadLine());
            char[] str = Console.ReadLine().ToCharArray(0, num);
            long hash = 0, r = 1;
            for (int i = 0; i < num; i++)
            {
                hash += ((str[i] - 'a' + 1) * r) % 1234567891;
                r = r * 31 % 1234567891;
            }
            Console.WriteLine($"{hash % 1234567891}");
        }
    }
}