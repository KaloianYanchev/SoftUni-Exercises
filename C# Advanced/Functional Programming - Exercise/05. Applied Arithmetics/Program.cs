using System;
using System.Linq;

namespace _05_Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] listOfNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Action<int[]> printNumbers = str =>
            {
                Console.WriteLine(string.Join(" ", str));
            };

            Func<string, int[], int[]> operation = (str, array) =>
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (str == "add")
                    {
                        array[i] = array[i]+1;
                    }
                    else if (str == "multiply")
                    {
                        array[i] = array[i] * 2;
                    }
                    else if (str == "subtract")
                    {
                        array[i] = array[i] - 1;
                    }

                }
                return array;
            };

            string command = string.Empty;

            while ("end" != (command = Console.ReadLine()))
            {
                if (command == "print")
                {
                    printNumbers(listOfNumbers);
                }
                else
                {
                    listOfNumbers = operation(command, listOfNumbers);
                    //Operation(command, listOfNumbers);
                }

            }
        }

        static int[] Operation(string command, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (command == "add")
                {
                    array[i] = array[i] + 1;
                }
                else if (command == "multiply")
                {
                    array[i] = array[i] * 2;
                }
                else if (command == "subtract")
                {
                    array[i] = array[i] - 1;
                }
            }
            return array;
        }
    }
}