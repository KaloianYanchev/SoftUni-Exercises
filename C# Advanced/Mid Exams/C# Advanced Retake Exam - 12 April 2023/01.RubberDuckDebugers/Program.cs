using System;
using System.Collections.Generic;
using System.Linq;

namespace RubberDuckDebugers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] timeInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] tasksInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(timeInput);

            Stack<int> stack = new Stack<int>(tasksInput);

            Dictionary<string, int> ducks = new Dictionary<string, int>
            {
                { "Darth Vader Ducky",  0 },
                { "Thor Ducky", 0},
                { "Big Blue Rubber Ducky", 0},
                { "Small Yellow Rubber Ducky", 0},
            };

            while (stack.Count > 0 && queue.Count > 0)
            {
                int currentTimeValue = queue.Dequeue();
                int currentTaskValue = stack.Pop();

                int result = currentTaskValue * currentTimeValue;

                if (result > 240)
                {
                    queue.Enqueue(currentTimeValue);
                    stack.Push(currentTaskValue - 2);
                }
                else if (result >= 0 && result <= 60)
                {
                    ducks["Darth Vader Ducky"] += 1;
                }
                else if (result > 60 && result <= 120)
                {
                    ducks["Thor Ducky"] += 1;
                }
                else if (result > 120 && result <= 180)
                {
                    ducks["Big Blue Rubber Ducky"] += 1;
                }
                else if (result > 180 && result <= 240)
                {
                    ducks["Small Yellow Rubber Ducky"] += 1;
                }
            }

            Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");

            foreach (KeyValuePair<string, int> duck in ducks)
            {
                Console.WriteLine($"{duck.Key}: {duck.Value}");
            }
        }
    }
}