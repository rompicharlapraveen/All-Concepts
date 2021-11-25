using System;
using System.Threading;

namespace Synchronous
{
    public class Sync
    {

        public static void Main(string[] args)
        {

            int a = 10;
            int b = 5;

            Sync s = new Sync();

            Console.WriteLine("Additon result: " + s.Add(a, b));
            Console.WriteLine("Subtraction result: " + s.Sub(a, b));
            Console.WriteLine("Multiplication result: " + s.Multiply(a, b));
            Console.WriteLine("Division result: " + s.Divide(a, b));
            Console.ReadLine();

        }
        
        int Add(int a, int b)
        {
            Console.WriteLine("Inside Addition");
            Thread.Sleep(2000);
            return a + b;
        }

        int Sub(int a, int b)
        {
            Console.WriteLine("Inside Subtraction");
            Thread.Sleep(2000);
            return a - b;
        }

        int Multiply(int a, int b)
        {
            Console.WriteLine("Inside Multiplication");
            Thread.Sleep(2000);
            return a * b;
        }

        int Divide(int a, int b)
        {
            Console.WriteLine("Inside Division");
            Thread.Sleep(2000);
            return a / b;
        }
    }
}
