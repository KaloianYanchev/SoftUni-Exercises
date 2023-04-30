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

            int barrelCount = 0;

            while (bullets.Count >= 0)
            {
                barrelCount++;
                if (locks.Count == 0)
                {
                    int moneyEarned = inteligenceValue - bulletsCost;
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
                    break;
                }
                if (bullets.Count == 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
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

                if (barrelCount == gunBarrelSize && bullets.Count != 0)
                {
                    Console.WriteLine("Reloading!");
                    barrelCount = 0;
                }
            }
        }
    }
}