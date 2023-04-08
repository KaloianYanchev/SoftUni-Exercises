using System;
using System.Collections.Generic;

namespace _07_Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> players = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int numberOfTosses = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(players);

            int currentToss = 1;
            while (queue.Count != 0)
            {
                string currentPlayer = queue.Dequeue();
                if (currentToss != numberOfTosses)
                {
                    queue.Enqueue(currentPlayer);
                    currentToss++;
                }
                else
                {
                    if (queue.Count == 0)
                    {
                        Console.WriteLine($"Last is {currentPlayer}");
                        break;
                    }
                    Console.WriteLine($"Removed {currentPlayer}");
                    currentToss = 1;
                }
            }
        }
    }
}