using System;
using System.Collections.Generic;
using System.Linq;

namespace Repeat
{
    class Program
    {
        public static void Main()
        {
            IEnumerable<string> strings = Enumerable.Repeat("Hello", 5);

            foreach (String str in strings)
            {
                Console.WriteLine(str);
            }
        }
    }
}
