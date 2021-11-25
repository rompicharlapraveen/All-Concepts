using System;
using System.Collections.Generic;
using System.Linq;

namespace Union
{
    class Program
    {
        public static void Main()
        {
            int[] u1 = { 5, 3, 9, 7, 5, 9, 3, 7 };
            int[] u2 = { 8, 3, 6, 4, 4, 9, 1, 0 };

            IEnumerable<int> union = u1.Union(u2);

            foreach (int num in union)
            {
                Console.Write("{0} ", num);
            }
        }
    }
}
