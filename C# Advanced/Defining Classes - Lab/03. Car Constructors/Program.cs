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

            Car firstCar = new Car();
            Car secondCar = new Car(carMake, carModel, carYear);
            Car thirdCar = new Car(carMake, carModel, carYear, carFuelQuantity, carFuelConsumption);

            Console.WriteLine(firstCar.PrintCar());
            Console.WriteLine(secondCar.PrintCar());
            Console.WriteLine(thirdCar.PrintCar());
        }
    }
}