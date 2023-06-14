using System;

namespace TheSquirrel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());

            string[] directions = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            char[,] matrix = new char[dimensions, dimensions];

            int squireRow = 0;
            int squireCol = 0;
            int totalNuts = 0;

            for (int row = 0; row < dimensions; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < dimensions; col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 's')
                    {
                        squireRow = row;
                        squireCol = col;
                    }

                    if (matrix[row, col] == 'h')
                    {
                        totalNuts++;
                    }
                }
            }

            int nutsCollected = 0;
            bool gameOverCondition = false;

            foreach (string direction in directions)
            {
                if (nutsCollected == 3)
                {
                    break;
                }

                if (direction == "left")
                {
                    if (squireCol == 0)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        gameOverCondition = true;
                        break;
                    }
                    else if (matrix[squireRow ,squireCol - 1] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        gameOverCondition = true;
                        break;
                    }
                    else
                    {
                        if (matrix[squireRow, squireCol - 1] == 'h')
                        {
                            nutsCollected++;
                            matrix[squireRow, squireCol - 1] = '*';
                        }

                        matrix[squireRow, squireCol] = '*';
                        squireCol--;
                    }
                }
                else if (direction == "right")
                {
                    if (squireCol == matrix.GetLength(1) - 1)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        gameOverCondition = true;
                        break;
                    }
                    else if (matrix[squireRow, squireCol + 1] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        gameOverCondition = true;
                        break;
                    }
                    else
                    {
                        if (matrix[squireRow, squireCol +1] == 'h')
                        {
                            nutsCollected++;
                            matrix[squireRow, squireCol + 1] = '*';
                        }

                        matrix[squireRow, squireCol] = '*';
                        squireCol++;
                    }
                }
                else if (direction == "up")
                {
                    if (squireRow == 0)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        gameOverCondition = true;
                        break;
                    }
                    else if (matrix[squireRow -1, squireCol] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        gameOverCondition = true;
                        break;
                    }
                    else
                    {
                        if (matrix[squireRow -1, squireCol] == 'h')
                        {
                            nutsCollected++;
                            matrix[squireRow -1, squireCol] = '*';
                        }

                        matrix[squireRow, squireCol] = '*';
                        squireRow--;
                    }
                }
                else if (direction == "down")
                {
                    if (squireRow == matrix.GetLength(0) - 1)
                    {
                        Console.WriteLine("The squirrel is out of the field.");
                        gameOverCondition = true;
                        break;
                    }
                    else if (matrix[squireRow + 1, squireCol] == 't')
                    {
                        Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
                        gameOverCondition = true;
                        break;
                    }
                    else
                    {
                        if (matrix[squireRow +1, squireCol] == 'h')
                        {
                            nutsCollected++;
                            matrix[squireRow +1, squireCol] = '*';
                        }

                        matrix[squireRow, squireCol] = '*';
                        squireRow++;
                    }
                }
            }

            if (nutsCollected == totalNuts)
            {
                Console.WriteLine("Good job! You have collected all hazelnuts!");
            }
            else if (nutsCollected < totalNuts && gameOverCondition == false)
            {
                Console.WriteLine("There are more hazelnuts to collect.");
            }

            Console.WriteLine($"Hazelnuts collected: {nutsCollected}");
        }
    }
}