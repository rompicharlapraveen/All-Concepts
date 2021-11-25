using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class Class2
    {
        public static void Main(string[] args)
        {
            // Regex regex = new Regex(@"^Sasi");
            // Regex regex = new Regex(@"Friend$");
            Regex regex = new Regex("F.....d");
            Match match = regex.Match("Sasi is my Friend");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
            Console.ReadLine();
        }
    }
}



//class Class2
//{
//    public static void Main(string[] args)
//    {
//        Regex regex = new Regex(@"\d");
//        Match match = regex.Match("Hello 19 World");
//        if (match.Success)
//        {
//            Console.WriteLine("Match Value: " + match.Value);
//        }
//        Console.ReadLine();
//    }
//}
//}