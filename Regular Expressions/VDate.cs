using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class VDate
    {
		public static void Main(string[] args)
		{
			string[] date = { "2019-09-22", "2021-11-23", "2020-22-12" };

			foreach (string d in date)
			{
				Console.WriteLine("{0} {1} a valid Date.", d, isValidDate(d) ? "is" : "is not");
			}
			Console.ReadLine();
		}
		public static bool isValidDate(string inputDate)
		{
			string dateRegex = @"^\d{4}-(0[1-9]|1[0-2])-(0[1-9]|[12][0-9]|3[01][1,])$";
			Regex re = new Regex(dateRegex);

			if (re.IsMatch(inputDate))
				return true;
			else
				return false;
		}
	}
}
