using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string carMake = "Peugeot";
            string carModel = "206";
            int carYear = 2008;
            double carFuelQuantity = 120.00;
            double carFuelConsumption = 6.5;
            Engine engine = new Engine(560, 6300);

            Tire[] tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.5),
                new Tire(2, 0.5),
                new Tire(2, 2.3),
            };
            
            Car firstCar = new Car();
            Car secondCar = new Car(carMake,carModel, carYear);
            Car thirdCar = new Car(carMake,carModel, carYear, carFuelQuantity, carFuelConsumption);
            Car forthCar = new Car(carMake, carModel, carYear, carFuelQuantity, carFuelConsumption, engine, tires);

            Console.WriteLine(firstCar.PrintCar());
            Console.WriteLine(secondCar.PrintCar());
            Console.WriteLine(thirdCar.PrintCar());
            Console.WriteLine(forthCar.PrintCar());
        }
    }
}