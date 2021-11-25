using System;
using System.Collections.Generic;
using System.Linq;

namespace OfType
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Collections.ArrayList fruits = new System.Collections.ArrayList(4);
            fruits.Add("Mango");
            fruits.Add("Orange");
            fruits.Add("Apple");
            fruits.Add(3.2);
            fruits.Add("Banana");

            // Apply OfType() to the ArrayList.
            IEnumerable<double> query1 = fruits.OfType<double>();

            Console.WriteLine("Elements of type 'Double' are:");
            foreach (double fruit in query1)
            {
                Console.WriteLine(fruit);
            }

            // The following query shows that the standard query operators such as
            // Where() can be applied to the ArrayList type after calling OfType().
            IEnumerable<string> query2 =
                fruits.OfType<string>().Where(fruit => fruit.ToLower().Contains("n"));

            Console.WriteLine("\n The following strings contain 'n':");
            foreach (string fruit in query2)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
