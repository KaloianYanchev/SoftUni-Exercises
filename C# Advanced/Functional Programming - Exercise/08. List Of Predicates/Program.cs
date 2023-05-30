using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int[]> getNumbers = endRange =>
            {
                int[] result = new int[endRange];

                for (int i = 1; i <= endRange; i++)
                {
                    result[i-1] = i;
                }
                return result;
            };

            int endRange = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] listOfNumbers = getNumbers(endRange);

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (int divider in dividers)
            {
                predicates.Add(n => n % divider == 0);
            }

            foreach (int number in listOfNumbers)
            {
                bool isValid = true;

                foreach (Predicate<int> match in predicates)
                {
                    if (!match(number))
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}