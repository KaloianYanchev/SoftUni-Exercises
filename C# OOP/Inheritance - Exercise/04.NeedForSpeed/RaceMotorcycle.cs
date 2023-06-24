using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private double _defaultFuelConsumption = 8;
        public RaceMotorcycle(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption
        {
            get { return _defaultFuelConsumption; }
        }

        public double DefaultFuelConsumption
        {
            get { return _defaultFuelConsumption; }
        }

        public override void Drive(double kilometers)
        {
            Fuel -= FuelConsumption * kilometers;
        }
    }
}
