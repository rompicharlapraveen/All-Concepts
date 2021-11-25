using System;

namespace Dynamic
{
    class Class1
    {
        public static void values(dynamic v1, dynamic v2)
        {

           // dynamic a = "PPPPPP";
            // var b=a.length;

            //var a = "PPPPPP";
            //var b = a.length;

            Console.WriteLine(v1 + v2);
        }
        public static void Main(string[] args)
        {
           values('R', 'P');
           values("Praveen", "Rompicharla");
           values("Hello", 122);
           values(10, 20);

            Console.ReadLine();
        }
    }
}
