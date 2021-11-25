using System;
using System.Text.RegularExpressions;
using System.Globalization;

//namespace regular_expressions
//{
    //class DateFormat
    //{
    //    public static void Main(string[] args)
    //    {
    //        string[] date = { "11-09-2021", "12/11/21", "08-29-2020" };

    //        foreach (string d in date)
    //        {
    //            Console.WriteLine("{0} {1} a valid Date.", d, Date(d) , "is" , "is not");
    //        }
    //    }

    //    public static string Date(string dateinput)
    //    {
    //        return Regex.Replace(dateinput, "(?<month>\\d{1,2})/(?<day>\\d{1,2})/(?<year>\\d{2,4})", "${day}/${month}/${year}");
    //    }

    //public static string Format(string input)
    //{
    //    try
    //    {
    //        return Regex.Replace(input, "(?<year>\\d{2,4})/(?<month>\\d{1,2})/(?<day>\\d{1,2})", "${year}/${month}/${day}",
    //              RegexOptions.Multiline | RegexOptions.IgnoreCase,
    //              TimeSpan.FromMilliseconds(1000));
    //    }
    //    catch (RegexMatchTimeoutException)
    //    {
    //        return input;
    //    }
    //}
    //    }
    //}

    namespace regular_expressions
    {
        class DateFormat
        {
            static void Main(string[] args)
            {
                string str = "20/2021/11";

                string result = Regex.Replace(str, "\\b(?<month>\\d{1,2})/(?<day>\\d{1,2})/(?<year>\\d{2,4})\\b", "${day}-${month}-${year}");

                Console.WriteLine("{0} ", result);

                Console.ReadLine();
            }
        }
    }