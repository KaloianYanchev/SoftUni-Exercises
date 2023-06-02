using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
		private string _model;
        private double _fuelAmount;
        private double _fuelConsumptionPerKilometer;
        private double _travelledDistance;


        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
			FuelAmount = fuelAmount;
			FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
			TravelledDistance = 0;
        }

        public string Model
		{
			get { return _model; }
			set { _model = value; }
		}

		public double FuelAmount
		{
			get { return _fuelAmount; }
			set { _fuelAmount = value; }
		}


		public double FuelConsumptionPerKilometer
		{
			get { return _fuelConsumptionPerKilometer; }
			set { _fuelConsumptionPerKilometer = value; }
		}

		public double TravelledDistance
		{
			get { return _travelledDistance; }
			set { _travelledDistance = value; }
		}

		public void Drive(double distance)
		{
			double fuelNeeded = distance * FuelConsumptionPerKilometer;


            if (FuelAmount >= fuelNeeded)
			{
				FuelAmount -= fuelNeeded;
				TravelledDistance += distance;
			}
			else
			{
                Console.WriteLine("Insufficient fuel for the drive");
            }
		}
	}
}
