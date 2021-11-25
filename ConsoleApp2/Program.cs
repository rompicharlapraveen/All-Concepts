using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator(10.3,23.9);
        }
        private static void Calculator(double width,double height)
        {
            Console.WriteLine("Area:"+(width*height));
            Console.ReadLine();
        }
    }
}
