using System;
using System.Collections.Generic;
using System.Linq;

namespace ToList
{
    class Program
    {
        public static void Main()
        {
            string[] fruits = { "apple", "passionfruit", "banana", "mango", "orange", "blueberry", "grape", "strawberry" };

            // ToList returns a new List of string instances.
            List<int> lengths = fruits.Select(fruit => fruit.Length).ToList();

            foreach (int length in lengths)
            {
                Console.WriteLine(length);
            }
        }
    }
}
