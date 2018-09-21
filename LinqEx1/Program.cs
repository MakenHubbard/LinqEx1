using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var LFruits =
                from l in fruits
                where l.StartsWith("L")
                select l;

            foreach (var fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
