using System;
using System.Threading.Tasks;

namespace Asynchronous
{
    class Program
    {
        static void Main(string[] args)
        {
           var result= Doaction1();
           var ret=  Doaction2();
           Console.ReadLine();
        }
        public static async Task Doaction1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("Method 1:" +" "+ DateTime.Now.Millisecond);
                }
            });
        }
        public static async Task Doaction2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("Method 2:" + " " + DateTime.Now.Millisecond);
                }
            });
        }
    }
}
