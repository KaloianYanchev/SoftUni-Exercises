using System;

namespace Animals.Models
{
    public abstract class Animal
    {
        private string _name;
        private string _favouriteFood;

        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public string Name 
        { 
            get => _name; 
            private set => _name = value; 
        }

        public string FavouriteFood 
        { 
            get => _favouriteFood; 
            private set => _favouriteFood = value; 
        }

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my favourite food is {FavouriteFood}";
        }
    }
}