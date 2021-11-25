using System;
using System.Linq;
using System.Collections.Generic;

namespace AsEnumerable
{
    // Custom class.
    class Clump<T> : List<T>
    {
        // Custom implementation of Where().
        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
            Console.WriteLine("In Clump's implementation of Where().");
            return Enumerable.Where(this, predicate);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // Create a new Clump<T> object.
            Clump<string> fruitClump =
                new Clump<string> { "apple", "passionfruit", "banana",
            "mango", "orange", "blueberry", "grape", "strawberry" };

            // First call to Where():
            // Call Clump's Where() method with a predicate.
            IEnumerable<string> query1 =
                fruitClump.Where(fruit => fruit.Contains("o"));

            Console.WriteLine("query1 has been created.");

            // Second call to Where():
            // First call AsEnumerable() to hide Clump's Where() method and thereby
            // force System.Linq.Enumerable's Where() method to be called.
            IEnumerable<string> query2 =
                fruitClump.AsEnumerable().Where(fruit => fruit.Contains("o"));

            // Display the output.
            Console.WriteLine("query2 has been created.");
        }
    }
}
