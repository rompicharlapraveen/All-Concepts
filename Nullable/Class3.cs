using System;
using System.Collections.Generic;
using System.Text;

namespace Nullable
{
    class Class3
    {
        static void Main(string[] args)
        {
            int? x = 10;
            if (x != null)
            {
                Console.WriteLine("x={0}", x.Value);
            }
            else
                Console.WriteLine("Empty value");
        }
    }
}
