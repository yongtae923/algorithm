using System;
using System.Collections.Generic;

namespace algorithm
{
    class Boj4949
    {
        static void Solution()
        {
            Stack<int> stack = new Stack<int>();

            while (true)
            {
                string str = Console.ReadLine();
                if (str == ".") { break; }
                char[] strChar = str.ToCharArray();
                string answer = "yes";

                foreach (char c in strChar)
                {
                    if (c == '(') { stack.Push(1); }
                    if (c == '[') { stack.Push(2); }
                    if (c == ')')
                    {
                        if (stack.TryPop(out int result))
                        {
                            if (result != 1) { answer = "no"; }
                        }
                        else { answer = "no"; }
                    }
                    if (c == ']')
                    {
                        if (stack.TryPop(out int result))
                        {
                            if (result != 2) { answer = "no"; }
                        }
                        else { answer = "no"; }
                    }
                }
                if (stack.Count > 0)
                {
                    answer = "no";
                    stack.Clear();
                }
                Console.WriteLine(answer);
            }
        }
    }
}