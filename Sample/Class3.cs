using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Class3
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> {3,5,2,6,8};
            List<int> even = list.FindAll(x=>(x% 2)== 0);
            foreach(var num in even)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
