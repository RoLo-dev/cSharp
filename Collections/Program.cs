using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int[] arr = {0,1,2,3,4,5,6,7,8,9};
            string[] names = {"Tim", "Martin", "Niki", "Sara"};
            bool[] tF = {true, false, true, true, false, true, false, true, false, true};

            List<string> iceCream = new List<string>();
            iceCream.Add("Chocolate");
            iceCream.Add("Vanilla");
            iceCream.Add("Rocky Road");
            iceCream.Add("Durian");
            iceCream.Add("Pistachio");
            Console.WriteLine($"{iceCream.Count}");
            Console.WriteLine(iceCream[2]);
            iceCream.RemoveAt(2);
            Console.WriteLine($"{iceCream.Count}");
            foreach(string flavor in iceCream){
                Console.WriteLine("-" + flavor);
            }

            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("Tim", "Chocolate");
            test.Add("Martin", "Vanilla");
            test.Add("Niki", "Durian");
            test.Add("Sara", "Pistachio");
            foreach(KeyValuePair<string, string> entry in test){
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
