using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Product
    {
		private string _name;
        private decimal _price;

        public Product(string name, decimal price)
        {
            Name = name;
			Price = price;
        }

        public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public decimal Price
		{
			get { return _price; }
			set { _price = value; }
		}
	}
}
