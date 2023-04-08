using System;
using System.Collections.Generic;

namespace _06_Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            Queue<string> queue = new Queue<string>();

            while ("End" != (input = Console.ReadLine()))
            {
                if (input == "Paid")
                {
                    while (queue.Count != 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}