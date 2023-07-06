using Cars.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class Tesla : Vehicle, IElectricCar
    {
        private int _battery;

        public Tesla(string model, string color, int battery) 
            : base(model, color)
        {
            Battery = battery;
        }
        
        public int Battery { get => _battery; set => _battery = value; }

        public override string ToString()
        {
            return $"{Color} {GetType().Name} {Model} {Battery}{Environment.NewLine}{Start()}{Environment.NewLine}{Stop()}";
        }
    }
}
