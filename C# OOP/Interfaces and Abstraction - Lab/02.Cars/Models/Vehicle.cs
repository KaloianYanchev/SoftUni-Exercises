using Cars.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models
{
    public abstract class Vehicle : ICar
    {
        private string _model;
        private string _color;
        protected Vehicle(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get => _model; set => _model = value; } 
        public string Color { get => _color; set => _color = value; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{Color} {GetType().Name} {Model}{Environment.NewLine}{Start()}{Environment.NewLine}{Stop()}";
        }
    }
}
