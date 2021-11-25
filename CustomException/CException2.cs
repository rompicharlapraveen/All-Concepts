using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException
{
    public class AgeException : Exception
    {
        public AgeException(string Message) : base(Message)
        {
        }
    }
    class CException2
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("Your age is lessthan 18");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your age is greaterthan 18");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            try
            {
                validate(15);
            }
            catch(AgeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}