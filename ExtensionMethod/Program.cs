using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeDB;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(122,"Praveen",4000);
            emp.EmployeeDetails();
            Console.WriteLine($"Annual Package {emp.CalculateSalary() }");
            Console.ReadLine();
        }
    }
}
