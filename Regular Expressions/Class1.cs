using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class Class1
    {
        public static void Main(string[] args)
        {
            // * Used to match the preceding character zero or more times.
            // Regex regex = new Regex(@"a*b");

            // + Used to match the preceding character one or more times.
            //Regex regex = new Regex(@"a+b");

            // ? Used to match the preceding character zero or one time.
            Regex regex = new Regex(@"a?b");
            Match match = regex.Match("aaaabcd");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
            Console.ReadLine();
        }
    }
}
