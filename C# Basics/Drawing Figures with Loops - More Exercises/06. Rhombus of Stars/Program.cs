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
                Console.Write(new string(' ', input - i));

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write(new string(' ', input - i));
                Console.WriteLine();
            }
            for (int i = input - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', input - i));

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write(new string(' ', input - i));
                Console.WriteLine();
            }
        }
    }
}