using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            double sum = 0;
            int numbersCount = 0;



            for (int i = 1; input >= i; i++)
            {
                sum += int.Parse(Console.ReadLine());
                numbersCount++;
            }
            double average = sum / numbersCount;
            Console.WriteLine($"{average:f2}");
        }
    }
}