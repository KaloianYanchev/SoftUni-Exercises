using CollectionHierarchy.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy.Models
{
    public class MyList : IRemovable
    {
        private const int AddIndex = 0;
        private const int RemoveIndex = 0;
        private readonly List<string> list;
        private string addedItems = string.Empty;
        private string removedItems = string.Empty;

        public MyList() 
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
                removedItem = list[RemoveIndex];
                list.RemoveAt(RemoveIndex);
            }
            removedItems += $"{removedItem} ";
        }

        public string Used()
        {
            StringBuilder sb = new StringBuilder();

            foreach (string item in list)
            {
                sb.Append($"{item} ");
            }
            return sb.ToString().Trim();
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
