using System;

namespace Generics
{
    class GenericMethod
    {
        public void Show<T>(T msg)
        {
            Console.WriteLine("{0}", msg);
        }
    }
    class GMethod
    {
        static void Main(string[] args)
        {
            GenericMethod gc = new GenericMethod();
            gc.Show("This is GenericMethod");
            gc.Show(101);
            gc.Show('P');
            gc.Show(10.1f);
            gc.Show(8.2222d);
            Console.ReadLine();
        }
    }
}
