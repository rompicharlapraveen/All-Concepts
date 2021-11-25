using System;

namespace NProperty
{
    class Emp
    {
        public int? Empid { get; set; }
        public string Empname { get; set; }
    }
    class Employee
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.Empid = null;
            e.Empname = "Praveen";
            Console.WriteLine("EmpId:{0} \n EmpName:{1}",e.Empid,e.Empname);
            Console.ReadLine();
        }
    }
}
