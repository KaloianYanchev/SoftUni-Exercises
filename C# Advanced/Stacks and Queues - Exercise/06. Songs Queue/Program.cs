using System;
using System.Collections.Generic;

namespace _06_Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] listOfSongs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queue = new Queue<string>(listOfSongs);

            while (queue.Count > 0)
            {
                string[] commandInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string operation = commandInput[0];

                if ("Play" ==  operation)
                {
                    queue.Dequeue();
                }
                else if ("Add" == operation)
                {
                    string song = string.Join(" ", commandInput).Replace("Add", "").TrimStart(); // <- Could be better!

                    if (!queue.Contains(song))
                    {
                        queue.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if ("Show" == operation)
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}