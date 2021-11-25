using System;
using System.Diagnostics;
namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Debugger.IsAttached);
            Console.ReadLine();
        }
    }
}
