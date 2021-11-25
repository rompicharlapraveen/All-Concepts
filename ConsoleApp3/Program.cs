using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Emp
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
       public static void Main(string[] args)
        {
          List<Emp> emp2 = new List<Emp>() 
          {
              new Emp() { EId = 1, EName = "John",  Age = 18 } ,
              new Emp() { EId = 2, EName = "Steve",  Age = 15 } ,
              new Emp() { EId = 3, EName = "Bill",  Age = 25 } ,
              new Emp() { EId = 4, EName = "Ram" , Age = 20 } ,
              new Emp() { EId = 5, EName = "Ron" , Age = 19 },
              new Emp() { EId = 6, EName = "Ram" , Age = 18 }
          };
            emp2.Sort((x, y) =>
            {
                int ret = String.Compare(x.EName, y.EName);
                int value = (ret != 0 ? ret : x.Age.CompareTo(y.Age));
                return value != 0 ? value : x.EId.CompareTo(y.EId);
            });

            // IEnumerable<Emp> orderby = emp2.OrderBy(e => e.EName).ThenBy(e => e.Age);

            foreach (var item in emp2)
            {
                Console.WriteLine(item.EId +" "+ item.EName + " " + item.Age);
            }
            Console.ReadLine();
        }
    }
}
