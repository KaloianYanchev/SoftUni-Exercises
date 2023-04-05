using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aRange = int.Parse(Console.ReadLine());
            int bRange = int.Parse(Console.ReadLine());
            int maxPasswordCount = int.Parse(Console.ReadLine());

            char firstAndLastSymbol = (char)35;
            char secondAndFourthSymbol = (char)64;
            for (int i = 1; i <= aRange; i++)
            {
                if (maxPasswordCount == 0)
                {
                    break;
                }
                for (int j =1; j <= bRange; j++)
                {
                    Console.Write($"{firstAndLastSymbol}{secondAndFourthSymbol}{i}{j}{secondAndFourthSymbol}{firstAndLastSymbol}|");
                    firstAndLastSymbol++;
                    secondAndFourthSymbol++;
                    if (firstAndLastSymbol > 55) 
                    {
                        firstAndLastSymbol = (char)35;
                    }
                    if (secondAndFourthSymbol > 96)
                    {
                        secondAndFourthSymbol = (char)64;
                    }
                    maxPasswordCount--;
                    if (maxPasswordCount == 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}