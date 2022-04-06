using System;

namespace Problem_1220_A_Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var stringInput = Console.ReadLine();
            char[] aray = new char[n];
            var count = 0;

            foreach (var i in stringInput)
            {
                if (count == n)
                {
                    break;
                }

                aray[count] = i;
                count++;
            }

            var zero = 0;
            var one = 0;

            foreach (var i in aray)
            {
               if(i == 'z')
                {
                    zero++;
                }

               else if(i == 'n')
                {
                    one++;
                }
            }

            while (one != 0)
            {
                Console.Write("1 ");
                one--;
            }

            while (zero != 0)
            {
                Console.Write("0 ");
                zero--;
            }
        }
    }
}