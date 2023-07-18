using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double AdditionalFuelConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption) 
            : base(fuelQuantity, fuelConsumption, AdditionalFuelConsumption)
        {
        }

        public override void Refuel(double litters)
        {
            
            base.Refuel(0.95 * litters);
        }
    }
}
