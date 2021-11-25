using System;

namespace Dynamic
{
    class Class3
    {
        public static void Main(string[] args)
        {
            dynamic emp = new
            {
                Eid = 1,
                Ename = "Sasi",
                EAge= 24,

                Cid = 22,
                Cname = "Sai",
                CAge = 25

            };
            Console.WriteLine("Employee Id:" + emp.Eid +" " + "Employee Name:" + emp.Ename + " " + "Employee Age:" + emp.EAge);

            Console.WriteLine("Customer Id:" + emp.Cid + " " + "Customer Name:" + emp.Cname + " " + "Customer Age:" + emp.CAge);
            Console.ReadLine();

            //var cust = new
            //{
            //    Cid = 22,
            //    Cname = "Sai",
            //    Age = 25
            //};
            //Console.WriteLine("Customer Id:" + cust.Cid + " " + "Customer Name:" + cust.Cname + " " + "Customer Age:" + cust.Age);
            //Console.ReadLine();
        }
    }
}
