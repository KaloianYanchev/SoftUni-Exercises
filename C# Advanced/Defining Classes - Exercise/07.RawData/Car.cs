using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
		private string _model;
        private Engine _engine;
        private Cargo _cargo;
        private Tires[] _tires;

        public Car(string model, Engine engine, Cargo cargo, Tires[] tires)
        {
            Model = model;
			Engine = engine;
			Cargo = cargo;
			Tires = tires;
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

		public Cargo Cargo
		{
			get { return _cargo; }
			set { _cargo = value; }
		}

		public Tires[] Tires
		{
			get { return _tires; }
			set { _tires = value; }
		}



	}
}
