using System;

namespace ConsoleApp1
{
    class Exception
    {
        static void Main(string[] args)
        {
            string name = null;
            if(name.Length>0) // Null Reference Exception Error
            {
                Console.WriteLine("Name:" + name);
            }
        }
    }
}
