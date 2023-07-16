using FoodShortage.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        private const int FoodIncrementPerPurchase = 5;
        private string _name;
        private int _age;
        private string _group;
        private int _currentFood;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get => _name; private set => _name = value; }
        public int Age { get => _age; private set => _age = value; }
        public string Group { get => _group; private set => _group = value; }

        public int CurrentFood { get => _currentFood; private set => _currentFood = value; }

        public void BuyFood()
        {
            CurrentFood += FoodIncrementPerPurchase;
        }
    }
}
