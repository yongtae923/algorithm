using System;
namespace repo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            string[] t = Console.ReadLine().Split(' ');
            int num = int.Parse(s[0]) * int.Parse(s[1]);

            foreach (string i in t)
            {
                Console.Write($"{int.Parse(i)-num} ");
            }
        }
    }
}