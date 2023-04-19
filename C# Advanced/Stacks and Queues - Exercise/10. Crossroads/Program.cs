using System;
using System.Collections.Generic;

namespace _10_Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            string input = string.Empty;

            Queue<string> queue = new Queue<string>();
            bool crashHappend = false;
            int carsPassed = 0;

            while ("END" != (input = Console.ReadLine()))
            {
                if ("green" == input)
                {
                    int currentLightDuration = greenLightDuration;
                    int currentWindow = freeWindowDuration;

                    while (queue.Count > 0)
                    {
                        string currentCar = queue.Peek();
                        int characterCount = currentCar.Length;

                        if (currentLightDuration > 0)
                        {
                            for (int i = 0; characterCount > i; i++)
                            {
                                char currentCharacter = currentCar[i];
                                currentLightDuration--;

                                if (currentLightDuration <= 0)
                                {
                                    if (currentWindow == -1)
                                    {
                                        crashHappend = true;
                                        Console.WriteLine("A crash happened!");
                                        Console.WriteLine($"{currentCar} was hit at {currentCharacter}.");
                                        break;
                                    }
                                    currentWindow--;
                                }
                            }
                            queue.Dequeue();
                            carsPassed++;
                            if (crashHappend)
                            {
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }
            }
            if (!crashHappend)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
            }
        }
    }
}