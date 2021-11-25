using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse
{
    class Program
    {
        public static void Main()
        {
            char[] ch = { 'P', 'r', 'a', 'v', 'e', 'e', 'n' };

            char[] reversed = ch.Reverse().ToArray();

            foreach (char chr in reversed)
            {
                Console.Write(chr + " ");
            }
            Console.WriteLine();
        }
    }
}
