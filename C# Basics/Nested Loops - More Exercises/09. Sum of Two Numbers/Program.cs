using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startRange = int.Parse(Console.ReadLine());
            int endRange = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int combinationCounter = 0;
            bool magicNumberFound = false;

            for (int i = startRange; i <= endRange; i++)
            {
                if (magicNumberFound == true)
                {
                    break;
                }
                for (int j = startRange; j <= endRange; j++)
                {
                    combinationCounter++;
                    if (i + j == magicNumber)
                    {
                        magicNumberFound = true;
                        Console.Write($"Combination N:{combinationCounter} ");
                        Console.Write($"({i} + {j} = {magicNumber})");
                        break;
                    }
                }
            }
            if (magicNumberFound == false)
            {
                Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNumber}");
            }
        }
    }
}