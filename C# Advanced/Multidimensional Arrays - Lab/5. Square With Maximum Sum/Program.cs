using System;
using System.Linq;
using System.Text;

namespace _05_Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int maxSum = int.MinValue;

            StringBuilder maxValueSubMatrix = new StringBuilder();

            for (int row = 0; row < rows -1; row++)
            {

                for (int col = 0; col < cols -1; col++)
                {
                    int currentSum = 0;
                    currentSum += matrix[row, col] + matrix[row, col + 1];
                    currentSum += matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxValueSubMatrix.Clear();
                        maxValueSubMatrix.AppendLine($"{matrix[row, col]} {matrix[row, col + 1]}");
                        maxValueSubMatrix.Append($"{matrix[row + 1, col]} {matrix[row + 1, col + 1]}");
                    }
                }
            }

            Console.WriteLine(maxValueSubMatrix);
            Console.WriteLine(maxSum);
        }
    }
}