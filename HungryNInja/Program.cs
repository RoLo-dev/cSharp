using System;
using System.Collections.Generic;

namespace HungryNInja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet toast = new Buffet();
            Ninja Po = new Ninja();
            while(Po.isFull != true){
                Po.Eat(toast.Serve());
            }
        }
    }

    class Food{
        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }
    class Buffet{
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Fried rice", 900, false, false),
                new Food("Com tam", 1000, false, false),
                new Food("Pineapple fried rice", 1100, false, true),
                new Food("Uncrustables", 2000, false, true),
                new Food("Banh mi", 1200, false, false),
                new Food("Poke", 1200, true, false),
                new Food("Com chien bo", 900, false, false)
            };
        }
        public Food Serve()
        {
            Random food = new Random();
            int randFood = food.Next(Menu.Count);
            return Menu[randFood];
        }
    }
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        public Ninja(){
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        // private bool isFull;
        public bool isFull{
            get{
                if(calorieIntake > 1200){
                    return true;
                }
                return false;
            }
        }
        public void Eat(Food item){
            if(isFull == false){
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                System.Console.WriteLine($"Eaten food {item.Name}");
                if(item.IsSpicy){
                    System.Console.WriteLine($"{item.Name} is spicy");
                }
                if(item.IsSweet){
                    System.Console.WriteLine($"{item.Name} is sweet");
                }
            }
            else{System.Console.WriteLine("Ninja is full");}
        }
    }
}
