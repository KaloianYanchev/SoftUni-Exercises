using FoodShortage.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Models
{
    public class Citizen : IBuyer
    {
        private const int FoodIncrementPerPurchase = 10;
        private string _name;
        private int _age;
        private string _id;
        private string _birthdate;
        private int _currentFood;

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

        public int CurrentFood { get => _currentFood; private set => _currentFood = value; }

        public void BuyFood()
        {
            CurrentFood += FoodIncrementPerPurchase;
        }

    }
}
