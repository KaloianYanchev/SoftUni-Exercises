using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) 
            : base(name, age)
        {
        }

        private int _age;

        public override int Age
        {
            get { return _age; }
            set 
            { 
                if (value <= 15)
                {
                    _age = value;
                }
            }
        }
    }
}
