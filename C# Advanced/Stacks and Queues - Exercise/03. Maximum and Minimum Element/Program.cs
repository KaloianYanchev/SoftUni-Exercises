using System;
using System.Collections.Generic;

namespace _03_Maximum_And_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfQueries = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numberOfQueries; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                int command = input[0];

                //Command == 1 <-- Push
                //Command == 2 <-- Pop
                //Command == 3 <-- Print Max
                //Command == 4 <-- Print Min

                if (command == 1)
                {
                    int elementToPush = input[1];
                    stack.Push(elementToPush);
                }
                else if (command == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (command == 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (command == 4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}