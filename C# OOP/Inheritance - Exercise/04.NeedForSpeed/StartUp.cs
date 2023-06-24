using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(100, 1000);
            Console.WriteLine(vehicle);
            
            vehicle.Drive(100);
            Console.WriteLine(vehicle);

            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(100, 1000);
            Console.WriteLine(raceMotorcycle);

            raceMotorcycle.Drive(100);
            Console.WriteLine(raceMotorcycle);

            Car car = new Car(100, 1000);
            Console.WriteLine(car);

            car.Drive(100);
            Console.WriteLine(car);
        }
    }
}
