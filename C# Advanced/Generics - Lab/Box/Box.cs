using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
		private Stack<T> items;

		public Box() 
		{
			items = new Stack<T>();
		}

		public void Add(T element)
		{
			items.Push(element);
		}

		public T Remove()
		{
			return items.Pop();
		}

        public int Count
		{
			get { return items.Count; }
		}
    }
}
