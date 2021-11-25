// Generic Example

using System;

namespace Generics
{
    class GenericClass<T>
    {
        public GenericClass(T msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> s = new GenericClass<string>("This is GenericClass");
            GenericClass<int> i = new GenericClass<int>(122);
            GenericClass<char> ch = new GenericClass<char>('P');
            GenericClass<float> f = new GenericClass<float>(10.1f);
            GenericClass<double> d = new GenericClass<double>(8.3586);
            Console.ReadLine();
        }
    }
}