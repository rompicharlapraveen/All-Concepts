using System;
using System.Collections;

namespace Generics
{
    class NGHashtable
    {
        static void Main(string[] args)
        {
            Hashtable gh = new Hashtable();
            gh.Add(1,"Praveen");
            gh.Add(2, "Sasi");
            gh.Add(3, "Sai");
            ICollection key = gh.Keys;
            foreach(var val in key)
            {
                Console.WriteLine(val +"-" +gh[val]);
            }
        }
    }
}
