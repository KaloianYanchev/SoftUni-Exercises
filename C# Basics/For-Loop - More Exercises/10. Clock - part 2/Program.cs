using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {

                for (int j = 0; j < 60; j++)
                {
                    for (int k = 0; k < 60; k++)
                    {
                        Console.Write($"{i} : ");
                        Console.Write($"{j} : ");
                        Console.WriteLine(k);
                    }

                }
            }


        }
    }
}