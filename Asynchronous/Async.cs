using System;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Asynchronous
{
    class Async
    {
        public static void Main(string[] args)
        {
            var sw = new Stopwatch();

            sw.Start();

            // Task.WaitAny(Praveen(), Sasi(), Madhu());


            Task.WaitAll(Praveen(), Sasi(), Madhu());

            sw.Stop();

            var elapsed = sw.ElapsedMilliseconds;
            Console.WriteLine($"elapsed: {elapsed} ms");

            async Task Praveen()
            {
                await Task.Delay(4000);
                Console.WriteLine("Praveen Task is Finished:" + DateTime.Now);
            }

            async Task Sasi()
            {
                await Task.Delay(7000);
                Console.WriteLine("Sasi Task is Finished:" + DateTime.Now);
            }

            async Task Madhu()
            {
                await Task.Delay(2000);
                Console.WriteLine("Madhu Task is Finished:" + DateTime.Now);
            }
        }
    }
}
