// Multiple Generic Constraints Example

using System;

namespace Generics
{
    class Generic<T,U>where T: class where U: struct
    {
        public T value1
        {
            get;
            set;
        }

        // U Means dirive from the argument supplied for U
        public U value2
        {
            get;
            set;
        }
    }
    class GMConstraints
    {
        static void Main(string[] args)
        {
            Generic<string, int> g = new Generic<string, int>();
            g.value1 = "Praveen";
            g.value2 = 122;
            Console.WriteLine("Value1 is:"+ g.value1);
            Console.WriteLine("Value2 is:"+ g.value2);
            Console.ReadLine();
        }
    }
}