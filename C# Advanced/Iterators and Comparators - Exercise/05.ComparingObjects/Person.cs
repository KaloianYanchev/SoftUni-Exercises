using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class Person : IComparable<Person>
    {
		private string _name;
        private int _age;
        private string _town;

        public Person(string name, int age, string town)
        {
			Name = name;
			Age = age;
			Town = town;
        }

        public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}

		public string Town
		{
			get { return _town; }
			set { _town = value; }
		}

        public int CompareTo(Person other)
        {
			int result = Name.CompareTo(other.Name);

            if (result == 0)
			{
				if (Age.CompareTo(other.Age) == 0)
				{
					if (Town.CompareTo(other.Town) == 0)
					{
						return result;
					}
				}
			}
			return result;
        }
    }
}
