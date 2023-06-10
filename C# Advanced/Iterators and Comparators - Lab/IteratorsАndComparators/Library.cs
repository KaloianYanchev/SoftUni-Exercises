using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
		private List<Book> _books;

        public Library(params Book[] books)
        {
            Books = books.ToList();
        }

        public List<Book> Books
		{
			get { return _books; }
			set { _books = value; }
		}

        public IEnumerator<Book> GetEnumerator()
        {
            Books.Sort(new BookComparator());
            return new LibraryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex = -1;

            public LibraryIterator(List<Book> books)
            {
                this.Books = books;
            }

            public List<Book> Books
            {
                get { return books; }
                set { books = value; }
            }


            public Book Current => Books[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                currentIndex++;
                return currentIndex < books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}
