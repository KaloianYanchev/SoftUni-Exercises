using System;
using System.Collections.Generic;

namespace _11_Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pricePerBullet = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bulletInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] lockInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int inteligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletInput);
            Queue<int> locks = new Queue<int>(lockInput);
            int bulletsCost = 0;

            if (gunBarrelSize > bullets.Count)
            {
                gunBarrelSize = bullets.Count;
            }

            bool endProgramCondition = false;

            while (bullets.Count != 0 || locks.Count != 0)
            {
                if (endProgramCondition)
                {
                    break;
                }

                for (int i = 0; i < gunBarrelSize; i++)
                {
                    if (locks.Count == 0)
                    {
                        int moneyEarned = inteligenceValue - bulletsCost;
                        Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
                        endProgramCondition = true;
                        break;
                    }
                    if (bullets.Count == 0)
                    {
                        Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                        endProgramCondition = true;
                        break;
                    }

                    int currentBullet = bullets.Pop();
                    int currentLock = locks.Peek();
                    bulletsCost += pricePerBullet;

                    if (currentBullet <= currentLock)
                    {
                        Console.WriteLine("Bang!");
                        locks.Dequeue();
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }
                }
                if (bullets.Count != 0)
                {
                    Console.WriteLine("Reloading!");
                }

                //if (locks.Count == 0)
                //{
                //    int moneyEarned = inteligenceValue - bulletsCost;
                //    Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
                //    break;
                //}
                //else if (bullets.Count == 0)
                //{
                //    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                //    break;
                //}
            }
        }
    }
}