﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    public class Citizen : IPerson, IBirthable, IIdentifiable
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Name { get => name; private set => name = value; }

        public int Age { get => age; private set => age = value; }

        public string Id { get => id; private set => id = value; }

        public string Birthdate { get => birthdate; private set => birthdate = value; }
    }
}