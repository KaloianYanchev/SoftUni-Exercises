using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hundredsRange = int.Parse(Console.ReadLine());
            int tenthsRange = int.Parse(Console.ReadLine());
            int onesRange = int.Parse(Console.ReadLine());
            
            for (int i = 2; i <= hundredsRange; i +=2) 
            {
                for (int j = 1; j <= tenthsRange; j++)
                {
                    if ((j / 2 == 1 && j % 2 == 0) || (j / 3 == 1 && j % 3 == 0) || (j / 5 == 1 && j % 5 == 0) || (j / 7 == 1 && j % 7 == 0))
                    {
                        for (int k = 2; k <= onesRange; k += 2)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}