using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int engineCount = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < engineCount; i++)
            {
                string[] engineInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string engineModel = engineInfo[0];
                int enginePower = int.Parse(engineInfo[1]);
                int engineDisplacement = 0;
                string engineEfficiency = null;

                for (int j = 2; j < engineInfo.Length; j++)
                {
                    int result = 0;

                    if (int.TryParse(engineInfo[j], out result))
                    {
                        engineDisplacement = result;
                    }
                    else
                    {
                        engineEfficiency = engineInfo[j];
                    }
                }

                Engine engine = new Engine
                {
                    Model = engineModel,
                    Power = enginePower,
                    Displacement = engineDisplacement,
                    Efficiency = engineEfficiency,
                };
                
                engines.Add(engine);
            }

            int carCount = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < carCount; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = carInfo[0];
                string carEngine = carInfo[1];
                int carWeight = 0;
                string carColor = null;

                for (int j = 2; j < carInfo.Length; j++)
                {
                    int result = 0;

                    if (int.TryParse(carInfo[j], out result))
                    {
                        carWeight = result;
                    }
                    else
                    {
                        carColor = carInfo[j];
                    }
                }

                Car car = new Car
                {
                    Model = carModel,

                    Engine = engines.FirstOrDefault(n => n.Model == carEngine),

                    Weight = carWeight,
                    Color = carColor,
                };

                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }


        }
    }
}