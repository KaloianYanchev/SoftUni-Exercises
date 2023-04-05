using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sectorRange = char.Parse(Console.ReadLine());
            int rowsCount = int.Parse(Console.ReadLine());
            int oddSeatsCount = int.Parse(Console.ReadLine());

            char sectorA = 'A';
            int totalSeatsCount = 0;

            for (int i = sectorA; i <= sectorRange; i++)
            {
                for (int j = 1; j <= rowsCount; j++) 
                {
                    char oddSeatsCharacter = (char)(oddSeatsCount + 97);
                    if (j % 2 == 0)
                    {
                        oddSeatsCharacter += (char)2;
                    }
                    for (int k = 'a'; k < oddSeatsCharacter; k++)
                    {
                        string seats = ($"{(char)i}{j}{(char)k}");
                        Console.WriteLine(seats);
                        totalSeatsCount++;
                    }
                }
                rowsCount++;
            }
            Console.WriteLine(totalSeatsCount);
        }
    }
}