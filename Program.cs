﻿using System;
using System.Collections.Generic;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = Console.ReadLine().ToCharArray();
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            for (int i = 0; i < alphabet.Length; i++)
            {
                int index = Array.IndexOf(s, alphabet[i]);
                Console.Write($"{index} ");
            }
        }
    }
}
