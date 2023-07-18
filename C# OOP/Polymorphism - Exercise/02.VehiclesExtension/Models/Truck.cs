using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension.Models
{
    public class Truck : Vehicle
    {
        private const double AdditionalFuelConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double fuelTankCapacity)
            : base(fuelQuantity, fuelConsumption, AdditionalFuelConsumption, fuelTankCapacity)
        {

        }

        public override void Refuel(double litters)
        {
            if (litters + FuelQuantity > FuelTankCapacity)
            {
                throw new ArgumentException($"Cannot fit {litters} fuel in the tank");
            }

            base.Refuel(0.95 * litters);
        }
    }
}
