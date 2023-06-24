using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
		private string _name;
        private int _age;

        public Person(string name, int age)
        {
            Name = name;
			Age = age;
        }

        public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public virtual int Age
		{
			get { return _age; }
			set 
			{ 
				if (value >= 0)
				{
                    _age = value;
                }
			}
		}

		public override string ToString()
		{
			return $"Name: {Name}, Age: {Age}";
		}
	}
}
