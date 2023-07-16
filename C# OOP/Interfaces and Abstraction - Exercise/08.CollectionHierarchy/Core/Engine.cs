using CollectionHierarchy.Core.Interfaces;
using CollectionHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int removeOperations = int.Parse(Console.ReadLine());

            foreach (string inputItem in input)
            {
                addCollection.Add(inputItem);
                addRemoveCollection.Add(inputItem);
                myList.Add(inputItem);
            }

            for (int i = 0; i < removeOperations; i++)
            {
                addRemoveCollection.Remove();
                myList.Remove();
            }

            Console.WriteLine(addCollection.DisplayAddedOperations());
            Console.WriteLine(addRemoveCollection.DisplayAddedOperations());
            Console.WriteLine(myList.DisplayAddedOperations());
            Console.WriteLine(addRemoveCollection.DisplayRemovedItems());
            Console.WriteLine(myList.DisplayRemovedItems());
        }
    }
}
