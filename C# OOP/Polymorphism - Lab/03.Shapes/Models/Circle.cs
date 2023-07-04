using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    public class Circle : Shape
    {
        private const double pi = Math.PI;
        private double _radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get => _radius; private set => _radius = value; }

        public override double CalculateArea()
        {
            return pi * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * pi * Radius;
        }

        public override string Draw()
        {
            return base.Draw();
        }
    }
}
