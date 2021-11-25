using System;

namespace Events
{
    public delegate void EventHandle();
    class Master
    {
        public string name;
        public Master(string argname)
        {
            name = argname;
        }
        public void eventhandler()
        {
            Console.WriteLine("Notification From: {0}", name);
        }
    }
    class Program
    {
        public static event EventHandle Evt;
        public static void sendeventnotification()
        {
            if(Evt!=null)
            {
                Evt();
            }
        }
        static void Main(string[] args)
        {
            Master m = new Master("Praveen");
            Evt += new EventHandle(m.eventhandler);
            sendeventnotification();
            Console.ReadLine();
        }
    }
}
