using System;
using System.Collections.Generic;
using System.Linq;

namespace First
{
    /*
    class Program
    {
        public static void Main()
        {
            int[] numbers = { };

            int first = numbers.First();

            Console.WriteLine("Result is:" + first);
            Console.ReadLine();
        }
    }
    */


    class Program
    {
        public static void Main()
        {
            int[] numbers = { 9, 34, 65, 92, 87, 435 };

            int first = numbers.First(number => number == 0);

            Console.WriteLine(first);
        }
    }
}
