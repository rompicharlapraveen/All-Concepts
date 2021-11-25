using System;

namespace Dynamic
{
    class Class2
    {
        static void Main(string[] args)
        {
            var a = 10;
            Console.WriteLine("Value:{0} Type:{1}", a, a.GetType());

            var b = 100.11;
            Console.WriteLine("Value:{0} Type:{1}", b, b.GetType());


            var c = "Praveen";
            Console.WriteLine("Value:{0} Type:{1}", c, c.GetType());

            var d = true;
            Console.WriteLine("Value:{0} Type:{1}", d, d.GetType());

            var e = 'P';
            Console.WriteLine("Value:{0} Type:{1}", e, e.GetType());

            var f = DateTime.Now;
            Console.WriteLine("Value:{0} Type:{1}", f, f.GetType());

            Console.ReadLine();
        }
    }
}
