using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startInterval = int.Parse(Console.ReadLine());
            int endInterval = int.Parse(Console.ReadLine());

            for (int i = startInterval; i <= endInterval; i++)
            {
                for (int j = startInterval; j <= endInterval; j++)
                {
                    for (int k = startInterval; k <= endInterval; k++)
                    {
                        for (int l = startInterval; l <= endInterval; l++)
                        { 
                            if ((i % 2 == 0) && (l % 2 != 0) && (i > l) && (((j + k) % 2) == 0))
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                            else if ((i % 2 == 1) && (l % 2 != 1) && (i > l) && (((j + k) % 2) == 0))
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}