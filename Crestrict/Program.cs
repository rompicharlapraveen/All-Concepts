using System;

namespace Crestrict
{
    class Praveen
    {

    }
    class Two
    {

    }
    class one<T> where T : Praveen
    {
        public void show()
        {
            Console.WriteLine("Hello");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            one<Praveen> o = new one<Praveen>();
            o.show();
        }
    }
}
