﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    if(n > 14)
                    {
                        studioPrice -= studioPrice * 0.30;
                    }else if (n > 7)
                    {
                        studioPrice -= studioPrice * 0.05;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    if (n > 14)
                    {
                        studioPrice -= studioPrice * 0.20;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    break;
            }
            if (n > 14)
            {
                apartmentPrice -= apartmentPrice * 0.1;
            }

            Console.WriteLine($"Apartment: {n * apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {n * studioPrice:f2} lv.");
        }
    }
}