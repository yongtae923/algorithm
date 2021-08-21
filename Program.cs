using System;
using System.Collections.Generic;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = a * b * c;
            char[] sumChar = sum.ToString().ToCharArray();
            List<int> counts = new List<int>(new int[10]);

            foreach (char s in sumChar)
            {
                counts[int.Parse(s.ToString())]++;
            }

            foreach (int i in counts)
            {
                Console.WriteLine(i);
            }
        }
    }
}
