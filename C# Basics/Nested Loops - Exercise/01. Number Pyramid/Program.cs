using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int currentRow = 1;
            bool isBigger = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int col = 1; col <= rows; col++)
                {
                    if (currentRow > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write($"{currentRow} ");
                    currentRow++;
                    

                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }



        }
    }
}