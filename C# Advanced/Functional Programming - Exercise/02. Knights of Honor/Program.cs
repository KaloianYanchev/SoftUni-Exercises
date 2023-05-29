using System;
using System.Collections.Generic;

namespace _02_Knights_Of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Action<string> printName = n => Console.WriteLine($"Sir {n}");

            foreach (string name in listOfNames)
            {
                printName(name);
            }
        }
    }
}