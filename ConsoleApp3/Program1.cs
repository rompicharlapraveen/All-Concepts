using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp3
{
    class Emp1: IComparable<Emp1>
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public int Age { get; set; }

        public int CompareTo(Emp1 obj)
        {
            return EName.CompareTo(obj.EName);
        }
    }
    class Program2
    {
        public static void Main(string[] args)
        {
            List<Emp1> emp = new List<Emp1>()
            {
              new Emp1() { EId = 1, EName = "John",  Age = 18 } ,
              new Emp1() { EId = 2, EName = "Steve",  Age = 15 } ,
              new Emp1() { EId = 3, EName = "Bill",  Age = 25 } ,
              new Emp1() { EId = 4, EName = "Ram" , Age = 20 } ,
              new Emp1() { EId = 5, EName = "Ron" , Age = 19 },
              new Emp1() { EId = 6, EName = "Ram" , Age = 18 }
            };
            emp.Sort();
            foreach (var item in emp)
            {
                Console.WriteLine("EId:{0} Name:{1} Age:{2}", item.EId, item.EName, item.Age);
            }
            Console.ReadLine();
        }
    }
}
