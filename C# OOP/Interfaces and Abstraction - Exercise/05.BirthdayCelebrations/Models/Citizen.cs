using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations.Models
{
    public class Citizen : IIdentifiable, IBirthable
    {
        private string _name;
        private int _age;
        private string _id;
        private string _birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get => _name; private set => _name = value; }

        public int Age { get => _age; private set => _age = value; }

        public string Id { get => _id; private set => _id = value; }

        public string Birthdate { get => _birthdate; private set => _birthdate = value; }
    }
}
