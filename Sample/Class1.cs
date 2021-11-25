using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Emp
    {
        public int? Empid
        {
            get;
            set;
        }
        public string? Empname
        {
            get;
            set;
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            List<Emp> e1 = new List<Emp>()
            {
                new Emp{Empid=121,Empname=null},
                new Emp{Empid=null,Empname="Praveen"}
            };
            foreach (Emp e in e1)
            {
                Console.WriteLine("EmpId:{0} \n EmpName:{1}", e.Empid, e.Empname);
            }
            Console.ReadLine();
        }
    }
}
