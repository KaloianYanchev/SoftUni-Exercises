using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Engine
    {
        private string _model;
        private int _power;
        private int _displacement;
        private string _efficiency;

        public Engine()
        {
            
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Power
        {
            get { return _power; }
            set { _power = value; }
        }

        public int Displacement
        {
            get { return _displacement; }
            set { _displacement = value; }
        }

        public string Efficiency
        {
            get { return _efficiency; }
            set { _efficiency = value; }
        }


    }
}