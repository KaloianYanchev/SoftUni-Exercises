using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            
            string input = string.Empty;

            while ("Beast!" != (input = Console.ReadLine()))
            {
                string animalType = input;
                string[] animalInformation = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
                string name = animalInformation[0];
                int age = int.Parse(animalInformation[1]);
                string gender = animalInformation[2];

                try
                {
                    switch (animalType)
                    {

                        case "Dog":
                            Dog dog = new Dog(name, age, gender);
                            animals.Add(dog);
                            Console.WriteLine(dog.ToString());
                            break;
                        case "Cat":
                            Cat cat = new Cat(name, age, gender);
                            animals.Add(cat);
                            Console.WriteLine(cat.ToString());
                            break;
                        case "Frog":
                            Frog frog = new Frog(name, age, gender);
                            animals.Add(frog);
                            Console.WriteLine(frog.ToString());
                            break;
                        case "Kitten":
                            Kitten kitten = new Kitten(name, age);
                            animals.Add(kitten);
                            Console.WriteLine(kitten.ToString());
                            break;
                        case "Tomcat":
                            Tomcat tomcat = new Tomcat(name, age);
                            animals.Add(tomcat);
                            Console.WriteLine(tomcat.ToString());
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
