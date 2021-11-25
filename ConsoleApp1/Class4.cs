using System;

namespace ConsoleApp1
{
    class Class4
    {
        static void Main(string[] args)
        {
            try
            {
                GetDetails();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        private static void GetDetails()
        {
            string name = "";
            // string name=null;
            // string name="Praveen";
            if (string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Name is Empty");
            }
            else
            {
                Console.WriteLine("Name: " + name);
            }
        }
    }
}
