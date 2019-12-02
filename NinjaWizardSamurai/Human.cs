using System;
namespace NinjaWizardSamurai
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health {get;set;}

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

        public virtual int Attack(Human target)
        {
            target.Health -= 5 * Strength;
            Console.WriteLine($"{target.Name} loses {5 * Strength} Health!");
            return target.Health;
        }


    }
}