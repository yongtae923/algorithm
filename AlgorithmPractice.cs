using System;
namespace repo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());    // first input is repeatition number

            for (int j = 0; j < num; j++)
            {
                string s = Console.ReadLine();          // input is OX quiz result
                char[] c = s.ToCharArray(0, s.Length);  // split input to char array
                int score = 0, sum = 0;

                foreach (char i in c)
                {
                    if (i == 'O')                       // if O then get score
                    {
                        score += 1;
                        sum += score;
                    }
                    else                                // if X then no score
                    {
                        score = 0;
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}