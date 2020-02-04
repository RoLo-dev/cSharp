using System;
using System.Collections.Generic;

namespace Boxing_unbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            
            object BoxedData = "This is clearly a string";
            if(BoxedData is int){
                System.Console.WriteLine("I guess we have an integer value in this box?");
            } if(BoxedData is string){
                System.Console.WriteLine("It is a string in the box");
            }
            object ActuallyString = "a string";
            string ExplicitString = ActuallyString as string;

            System.Console.WriteLine(ActuallyString);
            System.Console.WriteLine(ExplicitString);

            // int ExplicitInt = ActuallyString as int:
            // System.Console.WriteLine(ExplicitInt);

            List<object> Test = new List<object>();
            Test.Add(7);
            Test.Add(28);
            Test.Add(-1);
            Test.Add(true);
            Test.Add("chair");
            foreach(object item in Test){
                System.Console.WriteLine($"- {item}");
            }
            int sum = 0;
            foreach(int item in Test){
                sum += item;
                System.Console.WriteLine(sum);
            }

        } 
    }
}
