using System;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic a = 10;
            Console.WriteLine("Value:{0} Type:{1}", a, a.GetType());

            dynamic b = 100.11;
            Console.WriteLine("Value:{0} Type:{1}", b, b.GetType());

            dynamic c = "Praveen";
            Console.WriteLine("Value:{0} Type:{1}", c, c.GetType());

            dynamic d = true;
            Console.WriteLine("Value:{0} Type:{1}", d, d.GetType());

            dynamic e = DateTime.Now;
            Console.WriteLine("Value:{0} Type:{1}", e, e.GetType());

            Console.ReadLine();
        }
    }
}
