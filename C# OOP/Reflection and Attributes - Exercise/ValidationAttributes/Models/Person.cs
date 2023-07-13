using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models
{
    public class Person
    {
        private string name;
        private int age;
        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        [MyRequired]
        public string Name { get => name; private set => name = value; }

        [MyRange(12, 90)]
        public int Age { get => age; private set => age = value; }
    }
}
