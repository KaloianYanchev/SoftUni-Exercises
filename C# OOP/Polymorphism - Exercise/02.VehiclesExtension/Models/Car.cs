using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        private const double AdditionalFuelConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, double fuelTankCapacity) 
            : base(fuelQuantity, fuelConsumption, AdditionalFuelConsumption, fuelTankCapacity)
        {

        }


    }
}
