using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Models.Interfaces
{
    public interface IBuyer
    {
        public int CurrentFood { get; }
        public string Name { get; }
        public int Age { get; }

        public void BuyFood();

    }
}
