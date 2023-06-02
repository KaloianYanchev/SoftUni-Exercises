using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tires
    {
		private int _age;
        private double _pressure;

        public Tires(double pressure, int age)
        {
            Pressure = pressure;
			Age = age;
        }

        public int Age
		{
			get { return _age; }
			set { _age = value; }
		}

		public double Pressure
		{
			get { return _pressure; }
			set { _pressure = value; }
		}

	}
}
