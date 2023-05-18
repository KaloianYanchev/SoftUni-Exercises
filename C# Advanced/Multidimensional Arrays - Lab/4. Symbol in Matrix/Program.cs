using System;

namespace _04_Symbol_In_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] input = Console.ReadLine()
                    .ToCharArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool symbolFound = false;

            for (int row = 0; row < size; row++)
            {
                if (symbolFound)
                {
                    break;
                }

                for (int col = 0; col< size; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        symbolFound = true;
                        break;
                    }
                }
            }

            if (!symbolFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}