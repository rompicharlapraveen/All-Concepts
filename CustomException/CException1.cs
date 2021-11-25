using System;

namespace CustomException
{
    class PraveenException : Exception
    {
        public override string Message
        {
            get
            {
                return "It is Praveen Exception";
            }
        }
    }
    class CException1
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                if(b>0)
                {
                    int c = a / b;
                }
                else 
                    
                    throw new PraveenException();
            }
            catch(PraveenException pe)
            {
                Console.WriteLine(pe.Message);
            }
            Console.ReadLine();
        }
    }
}
