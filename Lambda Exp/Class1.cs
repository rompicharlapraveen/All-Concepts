using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Lexp
    {
        public string name { get; set; }
        public int age { get; set; }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            List<Lexp> l = new List<Lexp>()
            {
                new Lexp {name="Praveen",age=11 },
                new Lexp {name="Sasi",age=22 }
            };
            var exp=l.Select(x => new { Name = x.name, Age = x.age, });
            foreach (var item in exp)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
