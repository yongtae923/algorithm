using System;
using System.Linq;
namespace repo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            double[] s = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            double max = s.Max();
            double sum = 0;
            
            foreach (double i in s)
            {
                sum += i / max * 100;
            }

            Console.WriteLine(sum);
        }
    }
}