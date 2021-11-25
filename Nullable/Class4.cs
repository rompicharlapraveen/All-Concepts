using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable
{
    class Class4
    {
        static void Main(string[] args)
        {
            Nullable<int> a = 5;
            Nullable<double> d = 10.10;
            Nullable<char> c = 'S';
            Nullable<bool> b = false;
            Console.WriteLine(a.Value);
            a = null;
            d = null;
            c = null;
            b = null;
            // Checking "a" contain value ?  
            if (a.HasValue)
            {
                Console.WriteLine(a.Value);
            }
            if (a == null)
                Console.WriteLine("It contains null value");
        }
    }
}