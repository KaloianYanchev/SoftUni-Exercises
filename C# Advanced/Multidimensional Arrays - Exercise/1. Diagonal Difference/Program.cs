using System;
using System.Linq;

namespace _01_Diagonl_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());

            int[,] matrix = new int[dimension, dimension];

            for (int row = 0; row < dimension; row++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < dimension; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int leftDiagonal = 0;
            int rightDiagonal = 0;

            for (int row = 0; row < dimension; row++)
            {
                int col = row;
                leftDiagonal += matrix[row, col];
                rightDiagonal += matrix[row, matrix.GetLength(1) - 1 - col];
            }

            int diagonalDifference = Math.Abs(leftDiagonal - rightDiagonal);

            Console.WriteLine(diagonalDifference);
        }
    }
}