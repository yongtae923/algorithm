using System;
using System.Numerics;
namespace repo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int integer = Convert.ToInt32(s, 16);
            Console.WriteLine(integer);
        }
    }
}