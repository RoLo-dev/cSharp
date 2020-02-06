using System;

namespace WizardNinjaSamuria
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health;

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
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.Health -= dmg;
            System.Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        public virtual string GetInfo()
        {
            return $"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}, Health: {Health}.";
        }

    }
}