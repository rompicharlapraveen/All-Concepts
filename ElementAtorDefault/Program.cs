using System;
using System.Linq;

namespace ElementAtorDefault
{
    class Program
    {
        public static void Main()
        {
            string[] names = { "Praveen", "Sasi" };

            int index = 2;

            string name = names.ElementAtOrDefault(index);

            Console.WriteLine("The name chosen at index {0} is '{1}' ", index,
                String.IsNullOrEmpty(name) ? "<no name at this index>" : name);
        }
    }
}
