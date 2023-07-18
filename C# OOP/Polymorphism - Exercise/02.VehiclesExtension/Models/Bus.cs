using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        private const double AdditionalFuelConsumption = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double fuelTankCapacity) 
            : base(fuelQuantity, fuelConsumption, AdditionalFuelConsumption, fuelTankCapacity)
        {
        }

        public void DriveEmpty(double distance)
        {
            double fuelNeeded = distance * FuelConsumption;
            if (fuelNeeded > FuelQuantity)
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
                FuelQuantity -= fuelNeeded;
            }
        }
    }
}
