using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStackImplementation
{
    public class CustomStack<T> : IEnumerable<T>
    {
		private const int InitialCapacity = 4;
		private T[] _collection = new T[InitialCapacity];
		private int _count = 0;

        public CustomStack()
        {

        }

        public T[] Collection
		{
			get { return _collection; }
			set { _collection = value; }
		}

		public int Count
		{
			get { return _count; }
			private set { _count = value; }
		}

		public void Push(T item)
		{
			if (Count >= Collection.Length)
			{
				Resize();
			}

			Collection[Count] = item;
			Count++;
		}

        public void Push(params T[] item)
        {
            if (Count >= Collection.Length)
            {
                Resize();
            }

            Collection = item;
			Count += item.Length;
        }

        private void Resize()
        {
			T[] copy = new T[Collection.Length * 2];

			for (int i = 0; i < Collection.Length; i++)
			{
				copy[i] = Collection[i];
			}

			Collection = copy;
        }

        public void Pop()
		{
			if (Count == 0)
			{
				throw new Exception("No elements");
			}

			Collection[Count-1] = default(T);
			Count--;
		}

        public IEnumerator<T> GetEnumerator()
        {
			for (int i = Count -1; i >= 0; i--)
			{
				yield return Collection[i];
			}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
			return GetEnumerator();
        }
    }
}
