using System;

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
        }
    }
}
