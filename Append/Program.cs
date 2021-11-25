using System;
using System.Collections.Generic;
using System.Linq;

namespace Append
{

    // public static IEnumerable<TSource> Append<TSource>(this IEnumerable<TSource> source, TSource element);

    class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4 };

            // Trying to append any value of the same type
            numbers.Append(5);

            // It doesn't work because the original list has not been changed
            Console.WriteLine(string.Join(", ", numbers));

            // It works now because we are using a changed copy of the original list
            Console.WriteLine(string.Join(", ", numbers.Append(5)));

            // If you prefer, you can create a new list explicitly
            List<int> newNumbers = numbers.Append(5).ToList();

            // And then write to the console output
            Console.WriteLine(string.Join(", ", newNumbers));
            Console.ReadLine();
        }
    }
}
    



