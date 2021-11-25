using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
	class ValidateAddress
	{
		public static void Main(string[] args)
		{
			string[] str = { " 9/7 Balajirao Peta Near Avsm Bvrm West Godavari Pin-534199" };

			foreach (string s in str)
			{
				Console.WriteLine("{0} {1} a valid  Address.", s, isValidAddress(s) ? "is" : "is not");
			}
			Console.ReadLine();
		}
		public static bool isValidAddress(string inputAddress)
		{
			string strRegex = @"^[0-9A-Za-z\s-/][^,:#.]+$";

			Regex re = new Regex(strRegex);

			if (re.IsMatch(inputAddress))
				return true;
			else
				return false;
		}
	}
}
