using CollectionHierarchy.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy.Models
{
    public class AddRemoveCollection : IRemovable
    {
        private const int AddIndex = 0;
        
        private readonly List<string> list;
        private string addedItems = string.Empty;
        private string removedItems = string.Empty;

        public AddRemoveCollection()
        {
            list = new List<string>();
        }

        public void Add(string item)
        {
            list.Insert(AddIndex, item);
            addedItems += $"{AddIndex} ";
        }
        public void Remove()
        {
            string removedItem = string.Empty;
            if (list.Count > 0)
            {
                removedItem = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
            }
            removedItems += $"{removedItem} ";
        }

        public string DisplayAddedOperations()
        {
            return addedItems.Trim();
        }

        public string DisplayRemovedItems()
        {
            return removedItems.Trim();
        }

        

        
    }
}
