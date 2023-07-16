using BorderControl.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl.Models
{
    public class Citizen : IIdentifiable
    {
        private string _name;
        private int _age;
        private string _id;

        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get => _name; private set => _name = value; }

        public int Age { get => _age; private set => _age = value; }

        public string Id { get => _id; private set => _id = value; }
    }
}
