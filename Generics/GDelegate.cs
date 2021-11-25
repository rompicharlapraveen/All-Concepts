using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public delegate T Sample<T>(T a, T b);
    class Math
    {
        public int add(int a,int b)
        {
            return a + b;
        }
        public int sub(int x,int y)
        {
            return x - y;
        }
        public int mul(int c ,int d)
        {
            return c * d;
        }
    }
    class GDelegate
    {
        static void Main(string[] args )
        {
            Math m = new Math();
            Sample<int> dl = new Sample<int>(m.add);
            Console.WriteLine("Addition is:" + dl(10, 20));
            dl = m.sub;
            Console.WriteLine("Subtraction is:" + dl(20,10));
            dl = m.mul;
            Console.WriteLine("Multiplication is:" + dl(5, 5));
            Console.ReadLine();
        }
    }
}