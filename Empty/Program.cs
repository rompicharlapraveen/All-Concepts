using System;
using System.Linq;
using System.Collections.Generic;

namespace Empty
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names1 = { "Praveen, Sai" };
            string[] names2 = { "Madhu, Sai", "Kumar, Sai", };
            string[] names3 = { "Solanki, Ajay", "Hoeing, Helge", "Andersen, Henriette Thaulow", "abc,def" };

            List<string[]> namesList = new List<string[]> { names1, names2, names3 };

            // Only include arrays that have four or more elements
            IEnumerable<string> allNames = namesList.Aggregate(Enumerable.Empty<string>(),
                (current, next) => next.Length > 3 ? current.Union(next) : current);

            foreach (string name in allNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
