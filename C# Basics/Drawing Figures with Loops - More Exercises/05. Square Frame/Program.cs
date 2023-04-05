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
                    if ((i == 1) || (i == input))
                    {
                        if ((j == 1) || (j == input))
                        {
                            Console.Write("+ ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                    else if ((i > 1) || (i < input))
                    {
                        if ((j == 1) || (j == input))
                        {
                            Console.Write("| ");
                        }
                        else
                        {
                            Console.Write("- ");
                        }
                    }
                    if (j == input)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}