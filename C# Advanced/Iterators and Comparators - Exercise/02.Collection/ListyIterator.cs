using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int _index = 0;
        private List<T> _list;

        public ListyIterator()
        {
            _list = new List<T>();
        }

        public List<T> List
        {
            get { return _list; }
            set { _list = value; }
        }

        public int Index
        {
            get { return _index; }
            private set { _index = value; }
        }

        public bool Move()
        {
            if (HasNext())
            {
                Index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (Index < List.Count - 1)
            {
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (List.Count == 0)
            {
                throw new Exception("Invalid operation!");
            }

            Console.WriteLine(List[Index]);
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ", List));
        }

        public void Create(params T[] input)
        {
            List = input.ToList();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in List)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
            
        }
    }
}