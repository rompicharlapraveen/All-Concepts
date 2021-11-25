using System;
using System.Collections.Generic;
using System.Linq;

namespace Min
{

    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        /*
    //        double[] doubles = { 1.5E+104, 9E+103, -2E+103 };

    //        double min = doubles.Min();

    //        Console.WriteLine("The smallest number is {0}.", min);
    //        */

    //        /*
    //        int?[] grades = { 78, 92, null, 99, 37, 81 };

    //        int? min = grades.Min();

    //        Console.WriteLine("The lowest grade is {0}.", min);
    //        */


    //    }
    // }


    class Pet2
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        public static void Main()
        {
            Pet2[] pets = { new Pet2 { Name="Barley", Age=8 },
                   new Pet2 { Name="Boots", Age=4 },
                   new Pet2 { Name="Whiskers", Age=1 } };

            int min = pets.Min(pet2 => pet2.Age);

            Console.WriteLine("The youngest animal is age {0}." + min);
        }
    }
}
