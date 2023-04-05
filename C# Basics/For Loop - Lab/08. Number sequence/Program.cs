using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int maxValue = int.MinValue;
            int minValue = int.MaxValue;


            for (int i = 0; i < num; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input > maxValue)
                {
                    maxValue = input;
                }
                if (input < minValue)
                {
                    minValue = input;
                }

            }

            Console.WriteLine($"Max number: {maxValue}");
            Console.WriteLine($"Min number: {minValue}");
        }
    }
}