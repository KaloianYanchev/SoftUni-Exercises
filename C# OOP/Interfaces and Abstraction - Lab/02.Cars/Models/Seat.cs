using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class Seat : Vehicle
    {
        public Seat(string model, string color) 
            : base(model, color)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
