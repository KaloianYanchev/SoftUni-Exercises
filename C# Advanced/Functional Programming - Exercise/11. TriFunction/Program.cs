using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> checkLargerOrEqualSumOfChars = (name, requirement) =>
            {
                int charSum = name.Sum(ch => ch);

                return charSum >= requirement;
            };

            Func<string[], int, Func<string, int, bool>, string> getName = (names, sum, match) =>
            {
                foreach (string name in names)
                {
                    if (match(name, sum))
                    {
                        return name;
                    }
                }
                return default;
            };

            int n = int.Parse(Console.ReadLine());

            string[] listOfNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(getName(listOfNames, n, checkLargerOrEqualSumOfChars));
        }
    }
}