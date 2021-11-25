using System;
using System.Collections.Generic;
using System.Linq;

namespace Count
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            try
            {
                int number = fruits.Count();
                Console.WriteLine("There are {0} fruits in the collection.", number);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The count is too large to store as an Int32.");
                Console.WriteLine("Try using the LongCount() method instead.");
            }
        }
    }
}
