using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> _listOfPeople;

        public Family()
        {
            ListOfPeople = new List<Person>();
        }

        public List<Person> ListOfPeople
        {
            get { return _listOfPeople; }
            set { _listOfPeople = value; }
        }

        public void AddMember(Person member)
        {
            ListOfPeople.Add(member);
        }

        public Person GetOldestPerson()
        {
            Person oldestPerson = ListOfPeople.MaxBy(n => n.Age);

            return oldestPerson;
        }

        public void PrintFilteredPerson()
        {
            foreach (Person person in ListOfPeople.Where(a => a.Age > 30).OrderBy(n => n.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}