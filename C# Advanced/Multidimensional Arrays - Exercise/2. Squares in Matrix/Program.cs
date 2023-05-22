using System;
using System.Linq;

namespace _02_Squares_In_Matrix
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

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine().Replace(" ", "").ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int squaresCount = 0;
            
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row < rows-1 && col < cols - 1)
                    {
                        if (matrix[row, col] == matrix[row, col+1] && matrix[row+1, col] == matrix[row + 1, col+1]
                            && matrix[row,col] == matrix[row+1,col] && matrix[row, col] == matrix[row+1,col+1])
                        {
                            squaresCount++;
                        }
                    }
                }
            }
            
            Console.WriteLine(squaresCount);
        }
    }
}