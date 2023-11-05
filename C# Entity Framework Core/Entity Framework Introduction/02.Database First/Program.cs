using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using SoftUni.Models;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            //var employee = context.Employees.Find(2);

            //Console.WriteLine(employee.FirstName);

            //string name = GetEmployeesFullInformation(context);
            GetEmployeesFullInformation(context);
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            DbSet<Employee> employees = context.Employees;
            Console.WriteLine(employees.ToQueryString());


            return "";
        }
    }
}