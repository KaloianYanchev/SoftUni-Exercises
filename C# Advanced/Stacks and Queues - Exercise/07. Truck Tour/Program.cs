﻿using System;
using System.Collections.Generic;

namespace _07_Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int litersPerKilometer = 1;

            int count = int.Parse(Console.ReadLine());

            Queue<int[]> pumps = new();

            for (int i = 0; i < count; i++)
            {
                int[] pumpInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                pumps.Enqueue(pumpInfo);
            }

            int startIndex = 0;

            while (true)
            {
                bool isComplete = true;
                int totalLiters = 0;

                foreach (var pump in pumps)
                {
                    int liters = pump[0];
                    int distance = pump[1];

                    totalLiters += liters;

                    if (totalLiters - distance * litersPerKilometer < 0)
                    {
                        startIndex++;

                        int[] currentPump = pumps.Dequeue();
                        pumps.Enqueue(currentPump);

                        isComplete = false;

                        break;
                    }

                    totalLiters -= distance * litersPerKilometer;
                }

                if (isComplete)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
        }
    }
}