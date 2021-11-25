using System;
using System.Collections.Generic;
using System.Linq;

namespace ElementAt
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] names = { "Praveen", "Sasi" };
            Random random = new Random(DateTime.Now.Millisecond);

            string name = names.ElementAt(random.Next(0, names.Length));

            Console.WriteLine("The name chosen at random is '{0}'.", name);
        }
    }
}
