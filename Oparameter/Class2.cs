using System;
using System.Collections.Generic;
using System.Text;

namespace Oparameter
{
    class Class2
    {
       static public void Scholar(string fname,string lname,int age=20)
        {
            Console.WriteLine("First Name:{0}",fname);
            Console.WriteLine("Last Name:{0}",lname);
            Console.WriteLine("Age:{0}",age);
        }
        public static void Main(string[] args)
        {
            Scholar("Praveen", "Rompicharla");
            Scholar("Sasi", "Kunuku", 23);
            Console.ReadLine();
        }
    }
}
