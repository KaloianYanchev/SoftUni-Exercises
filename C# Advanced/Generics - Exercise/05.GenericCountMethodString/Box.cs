using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountMethodString
{
    public class Box<T> where T : IComparable<T>
    {
		private List<T> _items = new List<T>();

        public Box()
        {
            
        }
        public Box(T item)
        {
            Items.Add(item);
        }

        public List<T> Items
		{
			get { return _items; }
			set { _items = value; }
		}

        public int CompareTo(T itemToCompare)
        {
            int count = 0;

            foreach (T item in Items)
            {
                if (item.CompareTo(itemToCompare) > 0)
                {
                    count++;
                }
            }
            return count;
        }
	}
}
