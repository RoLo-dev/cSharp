using System;
using System.Collections.Generic;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i <= 255; i++)
            {
                System.Console.WriteLine(i);
            }

            for (int i = 0; i <= 100; i++){
                if(i % 3 == 0 && i % 5 == 0){
                    System.Console.WriteLine(i);
                }
            }

            for (int i = 0; i <= 100; i++){
                if(i % 3 == 0){
                    System.Console.WriteLine("Fizz");
                } else if(i % 5 == 0){
                    System.Console.WriteLine("Buzz");
                } else if(i % 3 == 0 && i % 5 == 0){
                    System.Console.WriteLine("FizzBuzz");
                } else{
                    System.Console.WriteLine(i);
                }
            }
            int[] arr = {1,2,3,4,5};
            System.Console.WriteLine($"The first number is {arr[0]}");
            arr[0] = 8;
            System.Console.WriteLine($"The first number is {arr[0]}");

            for(int i = 0; i < arr.Length; i++){
                System.Console.WriteLine(i);
            }

            List<string> bikes = new List<string>();
            bikes.Add("Volvo");
            bikes.Add("Mini");

            System.Console.WriteLine(bikes[0]);
            System.Console.WriteLine(bikes.Count);

            Dictionary<string, string> profile = new Dictionary<string, string>();
            profile.Add("Name", "Speros");
            profile.Add("Language", "PHP");
            profile.Add("Location", "Greece");
            System.Console.WriteLine("Instructor profile");
            System.Console.WriteLine("Name - " + profile["Name"]);
            System.Console.WriteLine("From - " + profile["Location"]);
            System.Console.WriteLine("Favorite Language - " + profile["Language"]);

            foreach(KeyValuePair<string, string> entry in profile){
                System.Console.WriteLine(entry.Key + " - " + entry.Value);
            }
            


        }
    }
}
