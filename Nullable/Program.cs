using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
          /* Nullable<int> i = null;
            if (i.HasValue)
            {
               Console.WriteLine(i);
            }
            else

              Console.WriteLine("Null");
          */

            /* Console.WriteLine(i.GetValueOrDefault());
            Console.ReadLine(); */

             int? i = null;
            int j = i ?? 0;
            Console.WriteLine(j);
        }
    }
}
