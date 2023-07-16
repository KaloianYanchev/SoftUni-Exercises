﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    public class Citizen : IPerson
    {
        private string name;
        private int age;
        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; private set => name = value; }
        public int Age { get => age; private set => age = value; }
    }
}
