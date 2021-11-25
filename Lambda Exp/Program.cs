using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>() {2,5,6,15};
            Console.WriteLine("Square Numbers:");
            var square = list.Select(x=>x*x);
            foreach(var value in square)
            {
                Console.WriteLine("{0}",value);
            }
            List<int> div = list.FindAll(x => (x % 3 == 0));
            Console.WriteLine("Divided by 3:");
            foreach(var value in div)
            {
                Console.WriteLine("{0}",value);
            }
            Console.ReadLine();
        }
    }
}
