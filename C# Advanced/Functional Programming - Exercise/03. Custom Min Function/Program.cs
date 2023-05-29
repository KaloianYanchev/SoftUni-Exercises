using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            Func<int[], int> minNumberFunc = n =>
            {
                int minNumber = int.MaxValue;

                foreach (int number in numbers)
                {
                    if (number < minNumber)
                    {
                        minNumber = number;
                    }
                }

                return minNumber;
            };

            Console.WriteLine(minNumberFunc(numbers));
        }
    }
}