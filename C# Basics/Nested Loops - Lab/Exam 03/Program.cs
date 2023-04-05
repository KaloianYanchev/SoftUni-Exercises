using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double weight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double cost = 0;
            double addedFee = 0;
            double totalCost = 0;

            if (type == "standard")
            {
                if (weight < 1)
                {
                    cost = 0.03;
                }else if (weight < 10)
                {
                    cost = 0.05;
                }else if (weight < 40)
                {
                    cost = 0.10;
                }else if (weight < 90)
                {
                    cost = 0.15;
                }
                else if (weight < 150)
                {
                    cost = 0.20;
                }
                totalCost = distance * cost;

            }
            
            
            
            else if (type == "express")
            {
                if (weight < 1)
                {
                    cost = 0.03;
                    addedFee = cost * 0.80;
                    
                }
                else if (weight < 10)
                {
                    cost = 0.05;
                    addedFee = cost * 0.40;
                }
                else if (weight < 40)
                {
                    cost = 0.10;
                    addedFee = cost * 0.05;
                }
                else if (weight < 90)
                {
                    cost = 0.15;
                    addedFee = cost * 0.02;
                }
                else if (weight < 150)
                {
                    cost = 0.20;
                    addedFee = cost * 0.01;
                }
                totalCost = distance * (cost + addedFee * weight);


            }

            Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {totalCost:f2} lv.");


        }
    }
}