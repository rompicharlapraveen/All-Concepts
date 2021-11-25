using System;
using System.Collections.Generic;

namespace Optional
{
    class Program
    {
       public static void Main()
        {
            Calculator(14.5,10.5);
        }
        public static void Calculator(double width, double height)
        {
            Console.WriteLine("Result is:", +(width * height));
            Console.ReadLine();
        }
    }
}
