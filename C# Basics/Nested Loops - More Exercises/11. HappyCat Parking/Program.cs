﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            for (int i = 1; i <= days; i++)
            {
                double price = 0;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        price += 2.50;
                        
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        price += 1.25;
                    }
                    else
                    {
                        price += 1.00;
                    }
                }
                totalPrice += price;
                Console.WriteLine($"Day: {i} - {price:f2} leva");
            }
            Console.WriteLine($"Total: {totalPrice:f2} leva");
        }
    }
}