using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Class2
    {
        public static void Main()
        {
            var employee = new {Id=101,Name="ABC" };
            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.Name);
            Console.ReadLine();
        }
    }
}
