using System;
using System.Collections.Generic;

namespace _05_Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] boxOfClothes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int initialRackCapacity = int.Parse(Console.ReadLine());
            int currentRackCapacity = 0;

            Stack<int> stack = new Stack<int>(boxOfClothes);
            int numberOfRacksNeeded = 0;

            while (stack.Count > 0)
            {
                int currentClothValue = stack.Pop();
                if (currentClothValue + currentRackCapacity > initialRackCapacity)
                {
                    numberOfRacksNeeded++;
                    stack.Push(currentClothValue);
                    currentRackCapacity = 0;
                }
                else if (currentClothValue <= initialRackCapacity)
                {
                    currentRackCapacity += currentClothValue;
                }

            }

            if (currentRackCapacity > 0)
            {
                numberOfRacksNeeded++;
            }

            Console.WriteLine(numberOfRacksNeeded);
        }
    }
}