using System;
using System.Text.RegularExpressions;

class Email
{
	public static void Main(string[] args)
	{
		string[] str = { "praveen@gmail.com", "Praveen_Rompicharlal@gmail.com", "tech@Cognine.in", "p@.com" };

		foreach (string s in str)
		{
			Console.WriteLine("{0} {1} a valid E-mail address.", s, isValidEmail(s) ? "is" : "is not");
		}
		Console.ReadLine();
	}
	public static bool isValidEmail(string inputEmail)
	{
		string strRegex = @"^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";

		Regex re = new Regex(strRegex);

		if (re.IsMatch(inputEmail))
			return true;
		else
			return false;
	}
}
