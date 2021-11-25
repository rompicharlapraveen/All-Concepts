using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EmployeeDB;

namespace ExtensionMethod
{
    public static class ExtensionLibrary
    {
        public static double CalculateSalary(this Employee empobj)
        {
            var basic = empobj.BasicSalary;
            double hra = 2000;
            double pf = 3000;
            double ASalary = (basic + hra + pf) * 12;

            return ASalary;

        }
    }
}
