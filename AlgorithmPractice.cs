using System;
using System.Numerics;
namespace repo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            Console.WriteLine(BigInteger.Parse(s[0]) / BigInteger.Parse(s[1]));
            Console.WriteLine(BigInteger.Parse(s[0]) % BigInteger.Parse(s[1]));
        }
    }
}