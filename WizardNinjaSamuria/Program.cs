using System;

namespace WizardNinjaSamuria
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Po = new Human("Po");
            Samurai Angel = new Samurai("Angel");
            Ninja Sandra = new Ninja("Sandra");
            Wizard Omar = new Wizard("Omar");

            while(Po.Health > 50)
            {
                Sandra.Attack(Po);
            }
            System.Console.WriteLine($"Po's health is {Po.Health}");
            Omar.Heal(Po);
        }
    }
}
