using System;
using System.Collections.Generic;
using System.Linq;

namespace ToLookup
{
    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string Country { get; set; }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee(){Name="Praveen", Department="IT", Country="India"},
                new Employee(){Name="Sasi",Department="Non-IT",Country="US"},
                new Employee(){Name="Madhu",Department="HR",Country="India"}
            };
            //emp.ToLookup() method is used to print the value of the data in the pair/collection of items.
            var Emp = emp.ToLookup(x => x.Department);
            Console.WriteLine("Grouping Employees by Department:");
            foreach (var value in Emp)
            {
                Console.WriteLine(value.Key);
                foreach (var item in Emp[value.Key])
                {
                    Console.WriteLine(" " + item.Name + " " + item.Department + " " + item.Country);
                }
            }
            Console.ReadLine();
        }
    }
}
