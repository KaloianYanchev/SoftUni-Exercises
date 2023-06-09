﻿using System;
using System.Collections.Generic;

namespace _01_Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] listOfElements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberOfElementsToPush = input[0];
            int numberOfElementsToPop = input[1];
            int elementToFind = input[2];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numberOfElementsToPush; i++)
            {
                stack.Push(listOfElements[i]);
            }

            for (int i = 0; i < numberOfElementsToPop; i++)
            {
                int currentElement = stack.Pop();
            }

            bool isFound = stack.Contains(elementToFind);
            int smallestElement = 0;

            if (stack.Count > 0)
            {
                smallestElement = stack.Min();
            }

            if (isFound)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(smallestElement);
            }
        }
    }
}