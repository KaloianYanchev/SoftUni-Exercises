using System;
using System.Collections;
using System.Collections.Generic;

namespace _02_Basic_Queue_Operations
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

            int numberOfElementsToEnqueue = input[0];
            int numberOfElementsToDequeue = input[1];
            int elementToFind = input[2];

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numberOfElementsToEnqueue; i++)
            {
                queue.Enqueue(listOfElements[i]);
            }

            for (int i = 0; i < numberOfElementsToDequeue; i++)
            {
                queue.Dequeue();
            }

            bool isFound = queue.Contains(elementToFind);
            int smallestElement = 0;

            if (queue.Count > 0)
            {
                smallestElement = queue.Min();
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