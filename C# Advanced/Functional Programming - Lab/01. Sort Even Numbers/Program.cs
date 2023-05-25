﻿using System;
using System.Linq;

namespace _01_Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray();

            //int[] evenNumbers = numbers.Where(n => n % 2 == 0).OrderBy(n => n).ToArray();
            
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}