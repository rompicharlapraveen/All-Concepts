using System;

namespace ConsoleApp1
{
    class Class3
    {
        static void Main(String[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter x Value:");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter y Value");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result is:" + x / y);
                    Console.ReadLine();
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Cannot Divided by Zero");
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Exception:{0}" + ex.Message);
            }
        }
    }
}