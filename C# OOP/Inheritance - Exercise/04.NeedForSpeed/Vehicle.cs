using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
		private double _defalutFuelConsumption = 1.25;
        private double _fuelConsumption;
        private double _fuel;
        private int _horsePower;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
			Fuel = fuel;
			FuelConsumption = DefalutFuelConsumption;
        }

        public double DefalutFuelConsumption
        {
			get { return _defalutFuelConsumption; }
			set { _defalutFuelConsumption = value; }
		}

		public virtual double FuelConsumption
		{
			get { return _fuelConsumption; }
			set { _fuelConsumption = value; }
		}

		public double Fuel
		{
			get { return _fuel; }
			set { _fuel = value; }
		}

		public int HorsePower
		{
			get { return _horsePower; }
			set { _horsePower = value; }
		}

		public virtual void Drive(double kilometers)
		{
			Fuel -= DefalutFuelConsumption * kilometers;
        }

        public override string ToString()
        {
			return $"Default Fuel Consumption: {DefalutFuelConsumption} Fuel Consumption: {FuelConsumption} Fuel: {Fuel}";
        }

    }
}
