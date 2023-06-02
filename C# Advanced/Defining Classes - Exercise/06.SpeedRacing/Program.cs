using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumption = double.Parse(carInfo[2]);

                Car currentCar = new Car(carModel, fuelAmount, fuelConsumption);
                cars.Add(currentCar);
            }

            string input = string.Empty;

            while("End" != (input = Console.ReadLine()))
            {
                string[] command = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = command[1];
                double distance = double.Parse(command[2]);

                cars.FirstOrDefault(n => n.Model == carModel).Drive(distance);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}