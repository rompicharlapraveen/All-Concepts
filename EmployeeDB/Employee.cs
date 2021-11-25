using System;
using System.Linq;
using System.Collections.Generic;

namespace EmployeeDB
{
    public class Employee
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public double BasicSalary { get; set; }
        public Employee(int eid, string ename, double salary)
        {
            Eid = eid;
            Ename = ename;
            BasicSalary = salary;
        }
        public void EmployeeDetails()
        {
            Console.WriteLine($"EmpN0: {Eid}");
            Console.WriteLine($"EmpName: {Ename}");
            Console.WriteLine($"Salary: {BasicSalary}");
        }
    }
}
