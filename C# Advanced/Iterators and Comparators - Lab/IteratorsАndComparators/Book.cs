using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
		private string _title;
        private int _year;
        private List<string> _authors;

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
			Year = year;
			Authors = authors.ToList();
        }

        public string Title
		{
			get { return _title; }
			set { _title = value; }
		}

		public int Year
		{
			get { return _year; }
			set { _year = value; }
		}

        public List<string> Authors
		{
			get { return _authors; }
			set { _authors = value; }
		}

        public int CompareTo(Book other)
        {
			int result = Year.CompareTo(other.Year);
            if (result == 0)
			{
				return Title.CompareTo(other.Title);
			}

			return result;
        }

        public override string ToString()
		{
			return $"{Title} - {Year}";
		}
	}
}
