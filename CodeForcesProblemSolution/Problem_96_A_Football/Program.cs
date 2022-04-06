using System;

namespace Problem_96_A_Football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player = Console.ReadLine();

            var zero = 0;
            var one = 0;
            var condition = false;

            for(int i = 0; i < player.Length; i++)
            {
                if(player[i] == '0')
                {
                    zero++;
                    one = 0;

                    if(zero == 7)
                    {
                        condition = true;
                        break;
                    }
                }

                else
                {
                    one++;
                    zero = 0;

                    if (one == 7)
                    {
                        condition |= true;
                        break;
                    }
                }
            }

            if (!condition)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");
        }
    }
}
