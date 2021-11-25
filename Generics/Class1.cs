using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Class1
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Praveen");
            d.Add(2, "Sasi");
            d.Add(3, null);
            d[4] = "Sai";
            try
            {
                d.Add(2,"Kumar");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("An element with Key = '2' already exists");
            }
            foreach(KeyValuePair<int,string> item in d)
            {
                Console.WriteLine("Key={0},Value={1}",item.Key,item.Value);
            }
            Console.ReadLine();
        }
    }
}