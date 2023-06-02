using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string _make;
        private string _model;
        private int _year;
        private double _fuelQuantity;
        private double _fuelConsumption;
        private Engine _engine;
        private Tire[] _tires;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public double FuelQuantity
        {
            get { return _fuelQuantity; }
            set { _fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return _fuelConsumption; }
            set { _fuelConsumption = value; }
        }

        public Engine Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }

        public Tire[] Tires
        {
            get { return _tires; }
            set { _tires = value; }
        }

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
            Engine = new Engine(100, 1500);
            Tires = new Tire[4]
            {
                new Tire(1, 1),
                new Tire(1, 1),
                new Tire(1, 1),
                new Tire(1, 1),
            };

        }
        public Car(string make, string model, int year) 
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) 
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) 
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            _engine = engine;
            _tires = tires;
            Engine = engine;
            Tires = tires;
        }
        
        public string PrintCar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Year: {Year}".ToString());
            sb.AppendLine($"Quantity: {FuelQuantity:f2}".ToString());
            sb.AppendLine($"Consumption: {FuelConsumption:f2}".ToString());
            sb.AppendLine($"Engine - HorsePower: {Engine.HorsePower:f2}".ToString());
            sb.AppendLine($"Engine - CubicCapacity: {Engine.CubicCapacity:f2}".ToString());

            for (int i = 0; i < Tires.Length; i++)
            {
                sb.AppendLine($"Tyre {i+1} - Year: {Tires[i].Year}, Pressure: {Tires[i].Pressure}");
            }

            //int count = 1;
            //foreach (Tire tire in Tires )
            //{
            //    sb.AppendLine($"Tyre{count++} - Year: {tire.Year}, Pressure: {tire.Pressure}");
            //}
            sb.AppendLine();

            return sb.ToString();
        }
    }
}
