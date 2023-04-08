using System;
using System.Collections.Generic;

namespace _08_Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightCapacity = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            string input = string.Empty;
            int totalCarsPassed = 0;
             
            while ("end" != (input = Console.ReadLine()))
            {
                if ("green" == input)
                {
                    for (int i = 0; i < greenLightCapacity; i++)
                    {
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            totalCarsPassed++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            Console.WriteLine($"{totalCarsPassed} cars passed the crossroads.");
        }
    }
}