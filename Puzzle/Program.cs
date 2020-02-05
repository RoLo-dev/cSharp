using System;
using System.Collections.Generic;

namespace Puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            RandomArray();
            TossCoin();
            Names();
        }
        public static int[] RandomArray(){
            int[] array = new int[10];
            Random num = new Random();
            for(int i = 0; i < array.Length; i++){
                array[i] = num.Next(5, 26);
                System.Console.WriteLine(array[i]);
            }
            int max = array[0];
            int min = array[0];
            int sum = 0;
            for(int i = 0; i < array.Length; i++){
                if(array[i] > max){
                    max = array[i];
                }
                if(array[i] < min){
                    min = array[i];
                }
                sum += array[i];
            }
            System.Console.WriteLine($"Max: {max}, Min: {min}, Sum: {sum}");
            return array;
        }
        public static string TossCoin(){
            System.Console.WriteLine("Flipping a coin");
            Random num = new Random();
            int result = num.Next(1,3);
            System.Console.WriteLine($"Result: {result}");
            if(result == 1){
                System.Console.WriteLine("TAILS");
                return "TAILS";
            } else{
                System.Console.WriteLine("HEADS");
                return "HEADS";
            }
        }
        public static List<string> Names(){
            List<string> names = new List<string>();
            names.Add("Todd");
            names.Add("Tiffany");
            names.Add("Charlie");
            names.Add("Geneva");
            names.Add("Sydney");
            Random str = new Random();
            List<string> newNames = new List<string>();
            for(int i = 0; i < 5; i++){
                int idx = str.Next(0, names.Count);
                newNames.Add(names[idx]);
                names.RemoveAt(idx);
                System.Console.WriteLine(newNames[i]);
            }
            for(int i = 0; i < newNames.Count; i++){
                if(newNames[i].Length < 5){
                    newNames.RemoveAt(i);
                }
            }
            System.Console.WriteLine("---- New list ----");
            for(int i = 0; i < newNames.Count; i++){
                System.Console.WriteLine(newNames[i]);
            }
            return newNames;
        }
    }
}
