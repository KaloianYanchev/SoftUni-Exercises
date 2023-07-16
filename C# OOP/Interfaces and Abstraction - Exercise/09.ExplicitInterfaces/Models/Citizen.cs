using ExplicitInterfaces.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaces.Models
{
    public class Citizen : IPerson, IResident
    {
        private string name;
        private string country;
        private int age;

        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }

        public string Name { get => name; private set => name = value; }

        public string Country { get => country; private set => country = value; }

        public int Age { get => age; private set => age = value; }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {Name}";
        }
        string IPerson.GetName()
        {
            return $"{Name}";
        }
    }
}
