using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtension.Models.Interfaces;

namespace VehiclesExtension.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double additionalConsumption;
        private double fuelQuantity;
        private double fuelConsumption;
        private double fuelTankCapacity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double additionalConsumption, double fuelTankCapacity)
        {
            FuelTankCapacity = fuelTankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            this.additionalConsumption = additionalConsumption;
        }

        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            protected set
            {
                if (FuelTankCapacity >= value)
                {
                    fuelQuantity = value;
                }
                else
                {
                    fuelQuantity = 0;
                }
            }
        }

        public double FuelConsumption { get => fuelConsumption; private set => fuelConsumption = value; }
        public double FuelTankCapacity { get => fuelTankCapacity; private set => fuelTankCapacity = value; }

        public void Drive(double distance)
        {
            double fuelNeeded = distance * (FuelConsumption + additionalConsumption);
            if (fuelNeeded > fuelQuantity)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
                FuelQuantity -= fuelNeeded;
            }
        }

        public virtual void Refuel(double litters)
        {
            if (litters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (litters + FuelQuantity > FuelTankCapacity)
            {
                throw new ArgumentException($"Cannot fit {litters} fuel in the tank");
            }

            FuelQuantity += litters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {FuelQuantity:f2}";
        }
    }
}
