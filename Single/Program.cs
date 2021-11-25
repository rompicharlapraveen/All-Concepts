using System;
using System.Collections.Generic;
using System.Linq;

namespace Single
{
    class Program
    {
        public static void Main()
        {
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            string fruit1 = fruits.Single(fruit => fruit.Length > 5);

            Console.WriteLine(fruit1);
        }
    }
}
