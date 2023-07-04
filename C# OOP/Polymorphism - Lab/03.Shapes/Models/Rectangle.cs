using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Models
{
    public class Rectangle : Shape
    {
        private double _height;
        private double _width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get => _height; private set => _height = value; }
        public double Width { get => _width; private set => _width = value; }

        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Height + 2 * Width;
        }
        public override string Draw()
        {
            return base.Draw();
        }
    }
}
