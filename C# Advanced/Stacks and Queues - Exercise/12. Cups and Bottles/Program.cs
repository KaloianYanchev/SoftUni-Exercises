using System;
using System.Collections.Generic;

namespace _12_Cups_And_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bottlesInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> cups = new Queue<int>(cupsInput);
            Stack<int> bottles = new Stack<int>(bottlesInput);

            int wastedWater = 0;

            while (cups.Count > 0)
            {
                int currentCup = cups.Peek();

                while (bottles.Count > 0)
                {
                    int currentBottle = bottles.Pop();

                    if (currentBottle >= currentCup)
                    {
                        wastedWater += currentBottle - currentCup;
                        cups.Dequeue();
                        break;
                    }
                    else
                    {
                        currentCup = currentCup - currentBottle;
                    }

                }
                if (cups.Count == 0)
                {
                    Console.Write("Bottles: ");
                    Console.WriteLine(string.Join(" ", bottles));
                    break;
                }

                if (bottles.Count == 0)
                {
                    Console.Write("Cups: ");
                    Console.WriteLine(string.Join(" ", cups));
                    break;
                }
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}