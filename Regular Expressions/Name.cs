using System;

namespace Regular_Expressions
{
    class Name
    {
        public static void Main(string[] args)
        {
            //string str = "Praveen";
            string str = "Narendhar";

            string a = "";
            //string b = "";

            foreach(char i in str)
            {
                if (i == 'r' || i == 'R')
                {
                    a = a + i + i;
                }
                else
                {
                    a = a + i;
                }
            }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
