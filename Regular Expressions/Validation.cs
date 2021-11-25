using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class Validation
    {
        public static string UserName = @"^[A-Z]{1}[A-Za-z]{6,}$";
        public static string UserMobileNumber = @"(^[6-9]{1}[0-9]{9}$)";
        public static string UserEmail= @"^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static string UserPassword = @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$";

        public bool Name()
        {
            return Regex.IsMatch("Praveen", UserName);
        }

        public bool MobileNumber()
        {
            return Regex.IsMatch("9848606944", UserMobileNumber);
        }

        public bool Email()
        {
            return Regex.IsMatch("praveen.rompicharla@cognine.com", UserEmail);
        }

        public bool Password()
        {
            return Regex.IsMatch("Praveen@1700", UserPassword);
        }
    }
}
