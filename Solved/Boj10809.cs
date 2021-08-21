using System;
namespace algorithm
{
    class Boj10809
    {
        static void Solution()
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