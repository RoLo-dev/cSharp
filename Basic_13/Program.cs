using System;
using System.Collections.Generic;

namespace Basic_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            PrintNumbers();
            PrintOdds();
            PrintSum();
            LoopArray(new int[] {3,5,9,0,2});
            FindMax(new int[] {12,32,10,9,28});
            GetAvg(new int[] {4,9,10,23,2,1,34});
            OddArray();
            System.Console.WriteLine(GreaterThanY(new int[] {4,3,10,7,2,11}, 9));
            EliminateNegatives(new int[] {2,-5,-7,8,10,23});
            SquareArrayValues(new int[] {2,7,10,12,1,5});
            ShiftValues(new int[] {5,7,10,3,1-3,-1,5,-9});
            MinMaxAvg(new int[] {3,2,7,10,1,17});
            NumToString(new int[] {-1,10,7,9,2,3,4});
        }
        public static void PrintNumbers(){
            for(int i = 1; i <= 255; i++){
                System.Console.WriteLine(i);
            }
        }
        public static void PrintOdds(){
            for(int i = 1; i <= 255; i++){
                if(i % 2 != 0){
                    System.Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum(){
            int sum = 0;
            for(int i = 0; i <= 255; i++){
                System.Console.WriteLine($"Number is {i} Sum: {sum += i}");
            }
        }
        public static void LoopArray(int[] numbers){
            for(int i = 0; i < numbers.Length; i++){
                System.Console.WriteLine(numbers[i]);
            }
        }
        public static void FindMax(int[] numbers){
            int max = numbers[0];
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] > max){
                    max = numbers[i];
                    System.Console.WriteLine(max);
                }
            }
        }
        public static void GetAvg(int[] numbers){
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
            }
            float avg = sum / numbers.Length;
            System.Console.WriteLine(avg);
        }
        public static int[] OddArray(){
            List<int> numList = new List<int>();
            for(int i = 1; i <= 255; i= i + 2){
                numList.Add(i);
            }
            int[] numArray = numList.ToArray();
            for(int i = 0; i < numArray.Length; i++){
                System.Console.WriteLine(numArray[i]);
            }
            return numArray;
        }
        public static int GreaterThanY(int[] numbers, int y){
            int count = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] > y){
                    count++;
                }
            }
            return count;
        }
        public static void EliminateNegatives(int[] numbers){
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    numbers[i] = 0;
                }
                System.Console.WriteLine(i);
            }
        }
        public static void SquareArrayValues(int[] numbers){
            for(int i = 0; i < numbers.Length; i++){
                numbers[i] *= numbers[i];
                System.Console.WriteLine(numbers[i]);
            }
        }
        public static void ShiftValues(int[] numbers){
            for(int i = 0; i < numbers.Length-1; i++){
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = 0;
            for(int i = 0; i < numbers.Length; i++){
                System.Console.WriteLine(numbers[i]);
            }
        }
        public static void MinMaxAvg(int[] numbers){
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] > max){
                    max = numbers[i];
                }
                if(numbers[i] < min){
                    min = numbers[i];
                }
                sum += numbers[i];
            }
            float avg = sum / numbers.Length;
            System.Console.WriteLine($"{max}, {min}, {avg}");
        }
        public static object[] NumToString(int[] numbers){
            object[] numbObject = new Object[numbers.Length];
            for(int i = 0; i < numbers.Length; i++){
                if(numbers[i] < 0){
                    numbObject[i] = "Dojo";
                } else{
                    numbObject[i] = numbers[i];
                }
                System.Console.WriteLine(numbObject[i]);
            }
            return numbObject;
        }

    }
}
