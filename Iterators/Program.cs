using System;
using System.Collections.Generic;
using System.Linq;

namespace Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> values= from value in Enumerable.Range(1, 10) select value;
            foreach(int a in values)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
