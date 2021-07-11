using System;
using System.Numerics;
namespace repo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            Double sum = 0;
            foreach (string i in s)
            {
                Double t = Double.Parse(i);
                sum += Math.Pow(t, 2.0);
            }
            Console.WriteLine(sum%10);
        }
    }
}