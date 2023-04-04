using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedSum = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double anualPercent = double.Parse(Console.ReadLine());

            double finalSum = depositedSum + (months * ((depositedSum * anualPercent/100) / 12));
            Console.WriteLine(finalSum);


        }
    }
}