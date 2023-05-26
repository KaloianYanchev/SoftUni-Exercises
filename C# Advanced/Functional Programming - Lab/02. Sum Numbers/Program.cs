using System;
using System.Linq;

namespace _02_Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], string> sumFunk = SumNumbers;
            Func<int[], int> countFunk = CountNumbers;

            Console.WriteLine(countFunk(numbers));
            Console.WriteLine(sumFunk(numbers));
        }

        static string SumNumbers(int[] numbers)
        {
            return $"{numbers.Sum(x => x)}";
        }
        static int CountNumbers(int[] numbers)
        {
            return numbers.Count();
        }
    }
}