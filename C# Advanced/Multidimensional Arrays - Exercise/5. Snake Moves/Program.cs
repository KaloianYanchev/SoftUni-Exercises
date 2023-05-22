using System;
using System.Linq;

namespace _05_Snake_Moves
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

            string snake = Console.ReadLine();

            int letterCount = 0;

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snake[letterCount].ToString();
                        letterCount++;

                        if (letterCount == snake.Length)
                        {
                            letterCount = 0;
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1)-1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[letterCount].ToString();
                        letterCount++;

                        if (letterCount == snake.Length)
                        {
                            letterCount = 0;
                        }
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for(int col = 0; col< cols; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}