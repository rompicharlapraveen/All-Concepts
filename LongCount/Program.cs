using System;
using System.Collections.Generic;
using System.Linq;

namespace LongCount
{
    class Program
    {
        class Pet
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public static void Main(string[] args)
        {
            Pet[] pets = { new Pet { Name="Barley", Age=8 },
                   new Pet { Name="Boots", Age=4 },
                   new Pet { Name="Whiskers", Age=1 } };

            const int Age = 3;

            long count = pets.LongCount(pet => pet.Age > Age);

            Console.WriteLine("There are {0} animals over age {1}.", count, Age);
        }
    }
}
