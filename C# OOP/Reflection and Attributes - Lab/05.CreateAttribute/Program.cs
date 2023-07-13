using System;
using System.Reflection;

namespace AuthorProblem
{
    [Author("Victor")]
    [Author("George")]
    public class StartUp
    {
        [Author("George")]
        public static void Main(string[] args)
        {
            new Tracker().PrintMethodsByAuthor();
        }

        [Author("Petkan")]
        void SomeMethod()
        {

        }

    }
}