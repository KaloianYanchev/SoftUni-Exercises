using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int junior = int.Parse(Console.ReadLine());
            int senior = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            int totalBikers = junior + senior;
            double juniorFee = 0;
            double seniorFee = 0;

            if (type == "trail")
            {
                juniorFee = 5.50;
                seniorFee = 7.00;
            }else if (type == "cross-country")
            {
                juniorFee = 8.00;
                seniorFee = 9.50;
                if (totalBikers >= 50)
                {
                    juniorFee -= juniorFee * 0.25;
                    seniorFee -= seniorFee * 0.25;

                }
            }
            else if (type == "downhill")
            {
                juniorFee = 12.25;
                seniorFee = 13.75;
            }
            else if (type == "road")
            {
                juniorFee = 20.00;
                seniorFee = 21.50;
            }

            double totalMoney = junior * juniorFee + senior * seniorFee;
            double eventFee = totalMoney * 0.05;

            Console.WriteLine($"{totalMoney - eventFee:f2}");

        }
    }
}