using System;

namespace Problem_118_A_StringTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputstring = Console.ReadLine();
            var input = inputstring.ToLower();

            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == 'a' || input[i] =='e'|| input[i] == 'i' || input[i] == 'o'|| input[i] =='u' || input[i] == 'y')
                {
                    continue;
                }
                else
                    Console.Write($".{input[i]}");
            }
        }
    }
}