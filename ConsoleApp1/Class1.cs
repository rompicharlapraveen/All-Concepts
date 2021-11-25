using System;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args)
        {
            //string name = null;
            //try
            //{
            //    if (name.Length > 0) // Exception will occur
            //    {
            //        Console.WriteLine("Name: " + name);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception: {0}", ex.Message);
            //}
            //Console.ReadLine();
        }
    }
    public class Emp
    {
        public string Name { get; set; }
        public Emp()
        {
            Name = null;
        }
        public string GetName()
        {
            try
            {
                var rrr = Name.ToCharArray();
                return Name;
            }
            catch (System.Exception ex)
            {
                return null;
            }
            
        }
    }
}
