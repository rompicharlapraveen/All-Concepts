using System;
using System.Collections.Generic;
using System.Linq;

namespace Skip
{
    class Program
    {
        public static void Main()
        {
            int[] grades = { 59, 82, 70, 56, 92, 98, 85 };

            //IEnumerable<int> lowerGrades = grades.OrderBy(g => g).Skip(3);

            IEnumerable<int> lowerGrades = grades.OrderBy(g => g).SkipLast(3);

            // Console.WriteLine("All grades except the top three are:");
            Console.WriteLine("All grades except the last three are:");
            foreach (int grade in lowerGrades)
            {
                Console.WriteLine(grade);
            }
            Console.ReadLine();
        }
    }
}
