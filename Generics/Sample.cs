using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Sample
    {
        static void Main(string[] args)
        {
            GenericDemo<object> obj1 = new GenericDemo<object>(10);
            obj1.display();
            obj1.Property1 = "Praveen";
            // new GenericDemo<string>("Sasi").display(); By using new keywork it call the constructor
            obj1.display();
            obj1.Property1 = 124.2F;
            obj1.display();
            obj1.Property1 = 164.484847545D;
            obj1.display();
            Console.ReadLine();
        }
    }
    public class GenericDemo<T>
    {
        public T Property1 { get; set; }
        public GenericDemo(T t1)
        {
            Property1 = t1;
        }
        public void display()
        {
            Console.WriteLine(Property1);
        }
    }
}
