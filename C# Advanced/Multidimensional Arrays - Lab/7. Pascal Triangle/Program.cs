using System;

namespace _07_Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long rows = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[rows][];

            pascalTriangle[0] = new long[1] {1};

            for (int row = 1; row <= rows -1; row++)
            {
                pascalTriangle[row] = new long[row+1];
                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    long sum = 0;

                    if (col == 0)
                    {
                        sum = pascalTriangle[row-1][col];
                    }
                    else if (col == pascalTriangle[row -1].Length)
                    {
                        sum = pascalTriangle[row-1][col-1];
                    }
                    else
                    {
                        sum = pascalTriangle[row - 1][col] + pascalTriangle[row - 1][col - 1];
                    }

                    pascalTriangle[row][col] = sum;
                }
            }

            for (int row = 0; row < pascalTriangle.Length; row++)
            {
                for(int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    Console.Write($"{pascalTriangle[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}