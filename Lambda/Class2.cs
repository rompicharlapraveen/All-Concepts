using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Class2
    {
        public static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ ID = 101, Name = "Praveen"},
                new Employee{ ID = 102, Name = "Sasi"}
            };

            Employee employee = listEmployees.Find(
                                    delegate (Employee x)
                                    {
                                        return x.ID == 101;
                                    }
                                );
            Console.WriteLine(@"ID : {0}, Name : {1}",
                employee.ID, employee.Name);
            Console.ReadKey();
        }
    }
}
