// Single Contraint Example
// We can Specify the certain Types

using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Generic<T> where T: class
    {
        public T Genericvariable
        {
            get;
            set;
        }
    }
    class Gconstraint
    {
        static void Main(string[] args)
        {
            Generic<string> gc = new Generic<string>();
            gc.Genericvariable="Hello Praveen";
            Console.WriteLine(gc.Genericvariable);
            Console.ReadLine();
        }
    }
}
