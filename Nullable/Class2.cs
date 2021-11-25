using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable
{
    class Class2
    {
        static void Main(string[] args)
        {
            int? x= null;
            int y = x ?? 1;
            Console.WriteLine("y={0}", y);
            Console.ReadLine();
        }
    }
}
