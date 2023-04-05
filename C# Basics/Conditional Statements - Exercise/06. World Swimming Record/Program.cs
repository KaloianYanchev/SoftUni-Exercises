using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double SecondsPerMeter = double.Parse(Console.ReadLine());


            double slowDown = Math.Floor(distanceInMeters / 15);

            double attempt = slowDown*12.50 + distanceInMeters * SecondsPerMeter;

            if (attempt < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {attempt:f2} seconds."); ////tuka e reshka
            }
            else
                Console.WriteLine($"No, he failed! He was {attempt - recordInSeconds:f2} seconds slower.");
        }
    }
}