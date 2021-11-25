using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Program1
    {
        static void Main(string[] args)
        {
            Generics ac = new Generics();
            ac.Add(4,5);
        }
        class Generics
        {
            public void Add<T>(T a1, T a2)
            {
                dynamic a = a1;
                dynamic b = a2;
                Console.WriteLine(a+b);
                Console.ReadLine();
            }
        }
    }
}