using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


        }
    }

    class Human{
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;

        public int health{
            get{ return health; }
        }
        public Human(string name){
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        public Human(string name, int strength, int intelligence, int dexterity, int hp)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = hp;
        }
        public int Attack(Human target){
            int dmg = Strength * 5;
            target.Health -= dmg;
            return target.Health;
        }
    }
}
