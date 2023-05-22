using System;
using System.Linq;
using System.Text;

namespace _03_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            StringBuilder stringBuilder = new StringBuilder();

            int maxSum = int.MinValue;
            string maxSumSquare = string.Empty;

            for (int row = 0; row < rows; row++)
            {
            
                for (int col = 0; col < cols; col++)
                {
                    int currentSum = 0;
            
                    if (row < matrix.GetLength(0) - 2 && col < matrix.GetLength(1) - 2)
                    {
                        int rowCount = 0;

                        for (int subMatrixRow = row; rowCount < 3; subMatrixRow++)
                        {
                            int colCount = 0;

                            for (int subMatrixCol = col; colCount < 3; subMatrixCol++)
                            {
                                currentSum += matrix[subMatrixRow, subMatrixCol];
                                stringBuilder.Append($"{matrix[subMatrixRow, subMatrixCol].ToString()} ");
                                colCount++;
                            }
                            stringBuilder.Append(Environment.NewLine);
                            rowCount++;
                        }
                    }
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxSumSquare = stringBuilder.ToString();
                    }
                    stringBuilder.Clear();
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine(maxSumSquare);
        }
    }
}