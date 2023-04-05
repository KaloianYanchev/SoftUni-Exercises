using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstPairOfNumbers = int.Parse(Console.ReadLine());
            int secondPairOfNumbers = int.Parse(Console.ReadLine());
            int firstPairOfNumbersRange = int.Parse(Console.ReadLine());
            int secondPairOfNumbersRange = int.Parse(Console.ReadLine());

            for (int i = firstPairOfNumbers; i <= firstPairOfNumbersRange + firstPairOfNumbers; i++)
            {
                if ((i % 2 != 0) && (i % 3 != 0) && (i % 5 != 0) && (i % 7 != 0))
                {
                    for (int j = secondPairOfNumbers; j <= secondPairOfNumbersRange + secondPairOfNumbers; ++j)
                    {
                        if ((j % 2 != 0) && (j % 3 != 0) && (j % 5 != 0) && (j % 7 != 0))
                        {
                            Console.WriteLine($"{i}{j}");
                        }
                    }
                }
            }
        }
    }
}