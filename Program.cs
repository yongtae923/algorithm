﻿using System;
using System.Collections.Generic;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
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
