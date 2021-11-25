using System;
using System.Threading;
using System.Diagnostics;

namespace Synchronous
{
    class Sync1
    {
        public static void Main(string[] args)
        {
            Sync1 s1 = new Sync1();
            Stopwatch sw = new Stopwatch();
            sw.Start();

            s1.Method1();
            s1.Method2();
            s1.Method3();

            sw.Stop();
            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine($"Elapsed: {elapsed} ms");
        }
        void Method1()
        {
            Console.WriteLine("Method1 is Called");
            Thread.Sleep(2000);
        }
        void Method2()
        {
            Console.WriteLine("Method2 is Called");
            Thread.Sleep(2000);
        }
        void Method3()
        {
            Console.WriteLine("Method3 is Called");
            Thread.Sleep(2000);
        }
    }
}
