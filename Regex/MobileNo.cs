using System;
using System.Text.RegularExpressions;

namespace Regex
{
    public class MobileNo
    {
        private string str1;

        public MobileNo(string str1)
        {
            this.str1 = str1;
        }

        public static void Main(string[] args)
        {
            string[] str = { "9848606944", "8985688510", "09484236985" };

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid mobile number.", s, isValidMobileNumber(s) ? "is" : "is not");
            }
            Console.ReadLine();
        }

        public static bool isValidMobileNumber(string inputMobileNumber)
        {
            string str1 = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

            MobileNo m = new MobileNo(str1);

            if (m.IsMatch(inputMobileNumber))
                return (true);
            else
                return (false);
        }

        private bool IsMatch(string inputMobileNumber)
        {
            throw new NotImplementedException();
        }
    }
}
