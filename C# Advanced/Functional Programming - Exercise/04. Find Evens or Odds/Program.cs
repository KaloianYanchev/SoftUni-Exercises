using System;
using System.Linq;

namespace _04_Find_Evens_Or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputRange = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string condition = Console.ReadLine();

            int startRange = inputRange[0];
            int endRange = inputRange[1];

            Func<string, int, bool> oddOrEvenFunc = (condition, number) =>
            {
                if (condition == "even")
                {
                    return number % 2 == 0;

                }
                else if (condition == "odd")
                {
                    return number % 2 != 0;
                }
                else
                {
                    return false;
                }
            };

            for (int i = startRange; i <= endRange; i++)
            {
                if (oddOrEvenFunc(condition, i))
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}