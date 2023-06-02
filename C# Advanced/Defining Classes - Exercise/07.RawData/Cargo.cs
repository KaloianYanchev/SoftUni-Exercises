using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Cargo
    {
		private string _type;
        private int _weight;

        public Cargo(string type, int weight)
        {
            Type = type;
			Weight = weight;
        }

        public string Type
		{
			get { return _type; }
			set { _type = value; }
		}

		public int Weight
		{
			get { return _weight; }
			set { _weight = value; }
		}

	}
}
