using System;

namespace Events
{
    public delegate void EventHandler();
    class Master1
    {
        public string name;
        public Master1()
        {
            name = null;
        }
    }
    class NoEvent
    {
        public static event EventHandle Evt;
        public static void sendeventnotification()
        {

            if (Evt != null)
            {
                Evt();
            }
            else
            {

                Console.WriteLine("No Events is There");
            }
        }

        public static void Main(string[] args)
        {
            Master1 m1 = new Master1();
            sendeventnotification();
            Console.ReadLine();
        }
    }
}
