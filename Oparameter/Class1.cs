using System;
using System.Collections.Generic;
using System.Text;

namespace Oparameter
{
    class Class1
    {
        static void Main()
        {
            Add(10,20,20);
        }
        public static void Add(int a,int b,params object[] res)
        {
            int sum = a + b;
            if(res!=null)
            {
                foreach(int i in res)
                {
                    sum =sum + i;
                }
            }
            Console.WriteLine("Sum is:" + sum);
            Console.ReadLine();
        }
    }
}
