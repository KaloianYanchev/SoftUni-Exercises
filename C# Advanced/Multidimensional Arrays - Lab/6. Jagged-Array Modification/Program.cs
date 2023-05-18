using System;
using System.Linq;

namespace _06_Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] rowInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[row] = rowInput;
            }

            string input = string.Empty;

            while ("END" != (input = Console.ReadLine()))
            {
                string[] command = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                string operation = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if ("Add" ==  operation)
                {
                    if (ValidIndexCheck(row, col, matrix))
                    {
                        matrix = Add(row, col, value, matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }

                }
                else if ("Subtract" == operation)
                {
                    if (ValidIndexCheck(row, col, matrix))
                    {
                        matrix = Subtract(row, col, value, matrix);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write($"{matrix[row][col]} ");
                }
                Console.WriteLine();
            }

        }

        static int[][] Add(int row, int col, int value, int[][] matrix)
        {
            
            matrix[row][col] += value;
            return matrix;
        }
        static int[][] Subtract(int row, int col, int value, int[][] matrix)
        {
            matrix[row][col] -= value;
            return matrix;
        }

        static bool ValidIndexCheck(int row, int col, int[][] matrix)
        {
            bool isValid = false;
            if (row >= 0 && row < matrix.Length && 
                col >= 0 && col < matrix[row].Length)
            {
                isValid = true;
            }
            return isValid;
        }
    }
}