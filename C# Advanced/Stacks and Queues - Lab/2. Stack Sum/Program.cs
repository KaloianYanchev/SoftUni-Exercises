using System;
using System.Collections.Generic;

namespace _02_Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            Stack<int> stack = new Stack<int>(list);

            string input = string.Empty;

            while (!(input = Console.ReadLine()).Contains("end", StringComparison.OrdinalIgnoreCase))
            {
                
                string[] operation = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = operation[0];

                if (command.Contains("add", StringComparison.OrdinalIgnoreCase))
                {
                    int firstNumber = int.Parse(operation[1]);
                    int secondNumber = int.Parse(operation[2]);

                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                if (command.Contains("remove", StringComparison.OrdinalIgnoreCase))
                {
                    int count = int.Parse(operation[1]);

                    if (count <= stack.Count)
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}