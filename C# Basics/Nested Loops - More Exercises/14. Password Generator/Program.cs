using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            for (int i = 1; i < a; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    for (int k = (char)97; k < (char)97 + b; k++)
                    {
                        for (int l = (char)97; l < (char)97 + b; l++)
                        {
                            for (int m = 1; m < a + 1; m++)
                            {
                                if ((m > i) && (m > j))
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)l}{m} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}