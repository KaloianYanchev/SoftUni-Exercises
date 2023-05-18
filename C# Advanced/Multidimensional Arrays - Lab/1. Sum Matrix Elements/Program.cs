using System;
using System.Collections;
using System.Text;

namespace _01_Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] matrixInput = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row,col] = matrixInput[col];
                }
            }

            int totalSumOfElements = 0;

            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    totalSumOfElements += matrix[row,col];
                }
            }

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{rows}");
            stringBuilder.AppendLine($"{cols}");
            stringBuilder.AppendLine($"{totalSumOfElements}");

            Console.WriteLine(stringBuilder);

        }
    }
}