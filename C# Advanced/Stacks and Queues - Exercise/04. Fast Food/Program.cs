using System;
using System.Collections.Generic;

namespace _04_Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodAvailable = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(orders);
            int biggestOrder = 0;

            while (queue.Count > 0)
            {
                int currentOrder = queue.Peek();

                if (currentOrder > biggestOrder)
                {
                    biggestOrder = currentOrder;
                }

                if (currentOrder <= foodAvailable)
                {
                    foodAvailable -= currentOrder;
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(biggestOrder);

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}