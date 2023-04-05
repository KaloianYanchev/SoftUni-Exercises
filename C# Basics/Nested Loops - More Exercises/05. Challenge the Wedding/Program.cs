using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int availableTables = int.Parse(Console.ReadLine());
            int tablesTaken = 0;

            for (int i = 1; i <= men; i++)
            {
                for (int j = 1; j <= women; j++) 
                { 
                    
                    if (availableTables > tablesTaken)
                    {
                        tablesTaken++;
                        Console.Write($"({i} <-> {j}) ");
                    }
                    else if (availableTables < tablesTaken)
                    {
                        return;
                    }
                }
            }
        }
    }
}