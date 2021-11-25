using System;
using System.Collections.Generic;
using System.Linq;

namespace Cast
{
    // public static IEnumerable<TResult> Cast<TResult>(this IEnumerable source);
    class Program
    {
        public static void Main(string[] args)
        {
            System.Collections.ArrayList fruits = new System.Collections.ArrayList();
            fruits.Add("mango");
            fruits.Add("apple");
            fruits.Add("lemon");

            IEnumerable<string> query = fruits.Cast<string>().OrderBy(fruit => fruit).Select(fruit => fruit);

            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }
        }
    }


    // public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second);
    /*
    class Rides
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
    class Program
    { 
    private static Rides[] GetClass()
    {
        Rides[] classics = { new Rides { Name="Chevy", Year=66 },
    new Rides { Name="Pontiac", Year=64 },
    new Rides { Name="Porche", Year=60 } };
        return classics;
    }

    private static Rides[] GetMods()
    {
        Rides[] mods = { new Rides { Name="Chevy", Year=16 },
                    new Rides { Name="Porche", Year=16 },
                    new Rides { Name="Jaguar", Year=17 } };
        return mods;
    }
        public static void Main(string[] args)
        {
            Rides[] classics = GetClass();
            Rides[] mods = GetMods();

            IEnumerable<string> query = classics.Select(classic =>
        classic.Name).Concat(mods.Select(mod => mod.Name));

            foreach (string name in query)
            {
                Console.WriteLine(name);
            }
        }
    }
    */
}
