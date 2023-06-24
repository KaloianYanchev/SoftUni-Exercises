using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Animal
    {
		private string _name;

        public Animal(string name)
        {
            Name = name;
        }

        public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
	}
}
