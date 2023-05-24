using System;
using System.Linq;
using System.Numerics;

namespace _06_Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];


            for (int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            matrix = AnalyzeMatrix(matrix);

            string input = string.Empty;
            
            while ("End" != (input = Console.ReadLine()))
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string operation = command[0];
                int rowIndex = int.Parse(command[1]);
                int colIndex = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (ValidateIndex(matrix, rowIndex, colIndex))
                {
                    if (operation == "Add")
                    {
                        matrix[rowIndex][colIndex] += value;
                    }
                    else if (operation == "Subtract")
                    {
                        matrix[rowIndex][colIndex] -= value;
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }

        }

        static int[][] AnalyzeMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length-1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row+1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                    }

                    for (int col = 0; col < matrix[row+1].Length; col++)
                    {
                        matrix[row + 1][col] /= 2;
                    }
                }
            }
            return matrix;
        }

        static bool ValidateIndex(int[][] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}