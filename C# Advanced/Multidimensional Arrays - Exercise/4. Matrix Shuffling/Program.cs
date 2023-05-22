using System;
using System.Linq;


namespace _04_Matrix_Shuffling
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

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            string input = string.Empty;

            while ("END" != (input = Console.ReadLine()))
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string operation = command[0];

                if (operation == "swap" && command.Length == 5)
                {
                    matrix = ValidOperation(matrix, command);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        static string[,] ValidOperation(string[,] matrix, string[] command)
        {
            bool isNumber = true;

            for (int i = 1; i < 4; i++)
            {
                isNumber = int.TryParse(command[i], out int value);

                if (isNumber == false)
                {
                    Console.WriteLine("Invalid input!");
                    return matrix;
                }
            }

            int firstNumberRow = int.Parse(command[1]);
            int firstNumberCol = int.Parse(command[2]);
            int secondNumberRow = int.Parse(command[3]);
            int secondNumberCol = int.Parse(command[4]);

            if(!ValidIndex(matrix, firstNumberRow, firstNumberCol, secondNumberRow, secondNumberCol))
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                //int tempRow = firstNumberRow;
                //int tempCol = firstNumberCol;

                string temp = matrix[firstNumberRow, firstNumberCol];

                matrix[firstNumberRow, firstNumberCol] = matrix[secondNumberRow, secondNumberCol];
                matrix[secondNumberRow, secondNumberCol] = temp;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for(int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write($"{matrix[row,col]} ");
                    }
                    Console.WriteLine();
                }
            }

            return matrix;
        } 

        static bool ValidIndex(string[,] matrix, int firstNumberRow, int firstNumberCol, int secondNumberRow, int secondNumberCol)
        {
            bool isValid = true;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            if (!(firstNumberRow >= 0 && firstNumberRow < rows))
            {
                isValid = false;
            }
            if (!(firstNumberCol >= 0 && firstNumberCol < cols))
            {
                isValid = false;
            }
            if (!(secondNumberRow >= 0 && secondNumberRow < rows))
            {
                isValid = false;
            }
            if (!(secondNumberCol >= 0 && secondNumberCol < cols))
            {
                isValid = false;
            }

            return isValid;
        }
    }
}