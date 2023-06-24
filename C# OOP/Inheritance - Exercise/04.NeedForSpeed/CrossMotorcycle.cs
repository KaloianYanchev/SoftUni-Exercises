using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class CrossMotorcycle : Motorcycle
    {
        private double _defaultFuelConsumption = 8;
        public CrossMotorcycle(int horsePower, double fuel)
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
    }
}