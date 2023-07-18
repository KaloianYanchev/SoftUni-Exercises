using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double additionalConsumption;
        private double fuelQuantity;
        private double fuelConsumption;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double additionalConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            this.additionalConsumption = additionalConsumption;
        }

        public double FuelQuantity { get => fuelQuantity; private set => fuelQuantity = value; }

        public double FuelConsumption { get => fuelConsumption; private set => fuelConsumption = value; }

        public void Drive(double distance)
        {
            double fuelNeeded = distance * (FuelConsumption + additionalConsumption);
            if (fuelNeeded > fuelQuantity)
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
                FuelQuantity -= fuelNeeded;
            }
        }

        public virtual void Refuel(double litters)
        {
            FuelQuantity += litters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
