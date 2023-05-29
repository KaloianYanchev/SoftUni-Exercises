using System;
using System.Collections.Generic;

namespace _01_Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Action<string> printName  = n => Console.WriteLine(n);

            foreach (string name in listOfNames)
            {
                printName(name);
            }
        }
    }
}