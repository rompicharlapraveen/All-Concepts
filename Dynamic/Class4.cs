using System;

namespace Dynamic
{
    public class Sample
    {
        // Define a dynamic field.   
        dynamic name;
        // Define a dynamic property.  
        dynamic NameProperty { get; set; }
        // Define a dynamic method with a dynamic parameter type.   
        public dynamic FullNameMethod(dynamic d)
        {
            name = "Praveen";
            dynamic Firstname = name;
            return Firstname + " " + d;
        }
    }
    class Class4
    {
        static void Main(string[] args)
        {
            dynamic LastName = "Rompicharla";
            dynamic sample = new Sample();
            Console.WriteLine(sample.FullNameMethod(LastName));

            Console.ReadKey();
        }
    }
}
