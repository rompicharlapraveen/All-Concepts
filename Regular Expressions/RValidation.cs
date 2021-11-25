using System;

namespace Regular_Expressions
{
    class RValidation
    {
        public static void Main(string[] args)
        {
            Validation regex = new Validation();
            bool result1 = regex.Name();
            Console.WriteLine(result1);
            bool result2 = regex.MobileNumber();
            Console.WriteLine(result2);
            bool result3 = regex.Email();
            Console.WriteLine(result3);
            bool result4 = regex.Password();
            Console.WriteLine(result4);
            Console.ReadLine();
        }

    }
}
