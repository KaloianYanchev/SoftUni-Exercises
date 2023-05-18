using System;
using System.Linq;

namespace _03_Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimesions = int.Parse(Console.ReadLine());

            int[,] matrix = new int[dimesions , dimesions];

            for (int row = 0; row < dimesions; row++)
            {
                int[] cols = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < dimesions; col++)
                {
                    matrix[row, col] = cols[col];
                }
            }

            int diagonalSum = 0;

            for (int row = 0 ; row < dimesions; row++)
            {
                diagonalSum += matrix[row, row];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}