using System;
using System.Collections.Generic;
using System.Linq;

namespace Select
{
    class Program
    {
        public static void Main()
        {
            string[] names = { "Praveen", "Sai", "Sasi Kumar" };

            var query = names.Select((name, index) => new { index, str = name.Substring(0, index) });

            foreach (var obj in query)
            {
                Console.WriteLine("{0}", obj);
            }
        }
    }
}
