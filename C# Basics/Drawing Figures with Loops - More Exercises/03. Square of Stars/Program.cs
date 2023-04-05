using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= input; j++)
                {
                    Console.Write("* ");
                    if (j == input)
                    {
                        Console.WriteLine();
                    }
                }
            }


        }
    }
}