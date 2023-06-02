using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Tire[]> listOfTireSets = new List<Tire[]>();

            while ("No more tires" != (input = Console.ReadLine()))
            {
                string[] tireInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Tire[] tires = new Tire[4];

                int currentTireCount = 0;

                for (int i = 0; i < tireInfo.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        tires[currentTireCount] = new Tire();
                        tires[currentTireCount].Year = int.Parse(tireInfo[i]);
                    }
                    else
                    {
                        tires[currentTireCount].Pressure = double.Parse(tireInfo[i]);
                        currentTireCount++;
                    }
                }
                listOfTireSets.Add(tires);
            }

            input = string.Empty;

            List<Engine> engines = new List<Engine>();

            while ("Engines done" != (input = Console.ReadLine()))
            {
                string[] engineInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int horsePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]);

                Engine engine = new Engine(horsePower,cubicCapacity);
                engines.Add(engine);
            }

            input = string.Empty;

            List<Car> cars = new List<Car>();

            while ("Show special" != (input = Console.ReadLine()))
            {
                string[] carInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string carMake = carInfo[0];
                string carModel = carInfo[1];
                int carYear = int.Parse(carInfo[2]);
                double carFuelQuantity = double.Parse(carInfo[3]);
                double carFuelConsumption = double.Parse(carInfo[4]);
                int carEngineIndex = int.Parse(carInfo[5]);
                int carTiresIndex = int.Parse(carInfo[6]);

                Car car = new Car(carMake, carModel, carYear, carFuelQuantity, carFuelConsumption, engines[carEngineIndex], listOfTireSets[carTiresIndex]);
                cars.Add(car);
            }

            foreach (Car car in cars.Where(n => n.Year >= 2017 && n.Engine.HorsePower > 330))
            {
                double pressureSum = 0;
                foreach (Tire tire in car.Tires)
                {
                    pressureSum += tire.Pressure;
                }

                if (pressureSum >= 9 && pressureSum <= 10)
                {
                    car.Drive(20);
                    Console.WriteLine(car.PrintCar());
                }
            }
        }
    }
}