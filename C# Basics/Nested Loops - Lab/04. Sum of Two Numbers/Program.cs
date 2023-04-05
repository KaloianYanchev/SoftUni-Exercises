using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rangeMin = int.Parse(Console.ReadLine());
            int rangeMax = int.Parse(Console.ReadLine());
            int goal = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = rangeMin; i <= rangeMax; i++)
            {
                for (int j = rangeMin; j <= rangeMax; j++)
                {
                    count++;
                    if (i + j == goal)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {goal})");
                        break;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {goal}");

        }
    }
}