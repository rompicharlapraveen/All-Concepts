using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class DValidation
    {
        public static void Main(string[] args)
        {
            const string date = "11/25/2021";
            string resultString = DateFormat(date);
            Console.WriteLine(resultString);
            Console.ReadLine();
        }
        static string DateFormat(string input)
        {
            try
            {
                return Regex.Replace(input, @"^(?<day>\\d{1,2})/(?<month>\\d{1,2})/(?<year>\\d{2,4})$", "${day}+${month}+${year}", RegexOptions.None);
            }
            catch (RegexMatchTimeoutException)
            {
                return input;
            }
        }
    }
}
