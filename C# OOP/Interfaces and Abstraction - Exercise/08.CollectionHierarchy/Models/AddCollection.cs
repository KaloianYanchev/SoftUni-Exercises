using CollectionHierarchy.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy.Models
{
    public class AddCollection : IAddable
    {
        private readonly List<string> list;

        public AddCollection()
        {
            list = new List<string>();
        }

        public void Add(string item)
        {
            list.Add(item);
        }

        public string DisplayAddedOperations()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < list.Count; i++)
            {
                stringBuilder.Append($"{i} ");
            }
            return stringBuilder.ToString().Trim();
        }
    }
}
