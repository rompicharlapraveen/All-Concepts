using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] str = { "9848606944", "8238783138", "2812451830" };

			foreach (string s in str)
			{
				Console.WriteLine("{0} {1} a valid mobile number.", s, isValidMobileNumber(s) ? "is" : "is not");
			}

			Console.ReadKey();
		}
		public static bool isValidMobileNumber(string inputMobileNumber)
		{
			string strRegex = "(^[6-9]{1}[0-9]{9}$)";
			Regex re = new Regex(strRegex);
			if (re.IsMatch(inputMobileNumber))
				return true;
			else
				return false;
		}
	}
}
