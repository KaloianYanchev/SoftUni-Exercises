using System;
using System.Collections.Generic;

namespace _09_Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string initialString = string.Empty;

            Stack<string> stack = new Stack<string>();
            stack.Push(initialString);

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string operation = input[0];

                if ("1" == operation)
                {
                    string stringToAppend = input[1];
                    initialString += stringToAppend;
                    stack.Push(initialString);
                }
                else if ("2" == operation)
                {
                    int count = int.Parse(input[1]);
                    initialString = initialString.Remove(initialString.Length - count, count);
                    stack.Push(initialString);
                }
                else if ("3" == operation)
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(initialString[index-1]);
                }
                else if ("4" == operation)
                {
                    stack.Pop();
                    initialString = stack.Peek();
                }
            }
        }
    }
}