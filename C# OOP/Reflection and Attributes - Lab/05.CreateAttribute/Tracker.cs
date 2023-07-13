using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type type = typeof(StartUp);

            MethodInfo[] methodInfo = type.GetMethods((BindingFlags)60);

            foreach (MethodInfo method in methodInfo)
            {
                AuthorAttribute[] attributes = method.GetCustomAttributes<AuthorAttribute>().ToArray();

                foreach (AuthorAttribute authorAttribute in attributes)
                {
                    Console.WriteLine($"{method.Name} is written by {authorAttribute.Name}");
                }
            }
        }
    }
}
