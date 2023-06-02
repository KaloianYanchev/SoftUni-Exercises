using CarSalesman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Car
    {
        private string _model;
        private Engine _engine;
        private int _weight;
        private string _color;

        public Car()
        {

        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public Engine Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Model}:");
            sb.AppendLine($"  {Engine.Model}:");
            sb.AppendLine($"    Power: {Engine.Power}");
            if (Engine.Displacement == default)
            {
                sb.AppendLine($"    Displacement: n/a");
            }
            else
            {
                sb.AppendLine($"    Displacement: {Engine.Displacement}");
            }

            if (Engine.Efficiency == default)
            {
                sb.AppendLine($"    Efficiency: n/a");
            }
            else
            {
                sb.AppendLine($"    Efficiency: {Engine.Efficiency}");
            }

            if (Weight == default)
            {
                sb.AppendLine($"  Weight: n/a");
            }
            else
            {
                sb.AppendLine($"  Weight: {Weight}");
            }

            if (Color == default)
            {
                sb.AppendLine($"  Color: n/a");
            }
            else
            {
                sb.AppendLine($"  Color: {Color}");
            }
            

            return sb.ToString().Trim();
        }

    }
}