﻿using System;
namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                if (s == "0")
                {
                    break;
                }
                else
                {
                    char[] c = s.ToCharArray();
                    string res = "yes";
                    for (int i = 0; i < c.Length / 2; i++)
                    {
                        if (c[i] != c[c.Length - i - 1])
                        {
                            res = "no";
                            break;
                        }
                    }
                    Console.WriteLine(res);
                }
            }
        }
    }
}
