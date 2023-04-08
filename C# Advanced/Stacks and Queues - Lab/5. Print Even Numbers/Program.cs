using System;
using System.Collections.Generic;

namespace _05_Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            foreach (int number in ints)
            {
                if (number % 2 == 0)
                {
                    queue.Enqueue(number);
                }
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}