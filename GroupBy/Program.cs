using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupBy
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            List<User> users = new List<User>()
            {
                new User { Name = "Praveen", Age = 23, Country = "USA" },
                new User { Name = "Sasi", Age = 28, Country = "USA" },
                new User { Name = "Sai", Age = 19, Country = "Germany" },
                new User { Name = "Madhu", Age = 19, Country = "Germany" },
                new User { Name = "Swaroop", Age = 30, Country = "USA" }
            };
            var groupby = users.GroupBy(user => user.Country);
            foreach (var group in groupby)
            {
                Console.WriteLine("Users from " + group.Key + ":");
                foreach (var user in group)
                    Console.WriteLine(user.Name);
            }
        }
    }
}
