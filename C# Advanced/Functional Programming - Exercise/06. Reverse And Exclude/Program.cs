using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int divider = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> reverse = numbers =>
            {
                List<int> reversedList = new List<int>();

                for (int i = 0; i < numbers.Count; i++)
                {
                    reversedList.Add(numbers[numbers.Count - 1 - i]);
                }

                return reversedList;
            };

            Func<List<int>, Predicate<int>, List<int>> filter = (numbers, match) =>
            {
                List<int> filteredNumbers = new List<int>();

                foreach (int number in numbers)
                {
                    if (match(number))
                    {
                        filteredNumbers.Add(number);
                    }
                }

                return filteredNumbers;
            };

            listOfNumbers = reverse(listOfNumbers);
            listOfNumbers = filter(listOfNumbers, n => n % divider != 0);

            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}