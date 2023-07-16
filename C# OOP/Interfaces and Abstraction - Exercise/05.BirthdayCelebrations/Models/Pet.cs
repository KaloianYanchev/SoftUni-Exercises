using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations.Models
{
    public class Pet : IBirthable
    {
        private string _name;
        private string _birthdate;

        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get => _name; private set => _name = value; }
        public string Birthdate { get => _birthdate; private set => _birthdate = value; }
    }
}
