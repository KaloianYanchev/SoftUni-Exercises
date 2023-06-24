using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Beverage : Product
    {
        private double _milliliters;

        public Beverage(string name, decimal price, double milliliters) 
            : base(name, price)
        {
            Milliliters = milliliters;
        }

        public double Milliliters
        {
            get { return _milliliters; }
            private set { _milliliters = value; }
        }
    }
}