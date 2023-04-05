using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            string destination = Console.ReadLine();
            double cost = double.Parse(Console.ReadLine());
            string input = "";
            double money = 0;

            while (destination != "End")
            {
                while (money < cost)
                {
                    money += double.Parse(Console.ReadLine());
                    if (money >= cost)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        money = money - cost;
                        destination = (Console.ReadLine());
                        if (destination == "End")
                        {
                            break;
                        }
                        cost = double.Parse(Console.ReadLine());
                    }

                }
            }
        }
    }
}