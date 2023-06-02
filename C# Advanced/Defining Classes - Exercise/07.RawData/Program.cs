using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //"{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType}
            //{tire1Pressure}
            //{tire1Age} {tire2Pressure} {tire2Age}
            //{tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"

            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                int weight = int.Parse(input[3]);
                string type = input[4];
                double firstTirePressure = double.Parse(input[5]);
                int firstTireAge = int.Parse(input[6]);
                double secondTirePressure = double.Parse(input[7]);
                int secondTireAge = int.Parse(input[8]);
                double thirdTirePressure = double.Parse(input[9]);
                int thirdTireAge = int.Parse(input[10]);
                double forthTirePressure = double.Parse(input[11]);
                int forthTireAge = int.Parse(input[12]);

                Engine engine = new Engine(speed, power);
                Cargo cargo = new Cargo(type, weight);
                Tires[] tires = new Tires[4]
                {
                    new Tires(firstTirePressure, firstTireAge),
                    new Tires(secondTirePressure, secondTireAge),
                    new Tires(thirdTirePressure, thirdTireAge),
                    new Tires(forthTirePressure, forthTireAge),
                };

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);

            }

            string condition = Console.ReadLine();

            //foreach (Car car in cars)
            //{
            //    if (condition == "fragile")
            //    {
            //        foreach (Tires tire in car.Tires)
            //        {
            //            if (tire.Pressure < 1 && car.Cargo.Type == "fragile")
            //            {
            //                Console.WriteLine(car.Model);
            //                break;
            //            }
            //        }
            //    }
            //    else if (condition == "flammable" && car.Cargo.Type == "flammable" && car.Engine.Power > 250)
            //    {
            //        Console.WriteLine(car.Model);
            //
            //        //if (car.Engine.Power > 250)
            //        //{
            //        //    Console.WriteLine(car.Model);
            //        //}
            //    }
            //}

            foreach (Car car in cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1) && condition == "fragile"))
            {
                Console.WriteLine(car.Model);
            }

            foreach (Car car in cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250 && condition == "flammable"))
            {
                Console.WriteLine(car.Model);
            }

        }
    }
}