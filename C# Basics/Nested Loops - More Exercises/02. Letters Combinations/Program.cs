using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char starterRange = char.Parse(Console.ReadLine());
            char endRange = char.Parse(Console.ReadLine());
            char forbidenLetter = char.Parse(Console.ReadLine());

            //int starterRangeInAscii = (int)starterRange;
            //int endRangeInAscii = (int)endRange;
            int validCombinations = 0;

            for (int i = (int)starterRange; i <= (int)endRange; i++)
            {
                if (i != (int)forbidenLetter) 
                {
                    for (int j = (int)starterRange; j <= (int)endRange; j++)
                    {
                        if (j != (int)forbidenLetter)
                        {
                            for (int k = (int)starterRange; k <= (int)endRange; k++)
                            {
                                if (k != (int)forbidenLetter)
                                {
                                    validCombinations++;
                                    Console.Write($"{(char)i}{(char)j}{(char)k} ");
                                }
                            }
                        }
                    }
                }

            }
            Console.Write(validCombinations);
        }
    }
}