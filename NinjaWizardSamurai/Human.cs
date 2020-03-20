using System;

namespace NinjaWizardSamurai
{
    // Create a Human class with four public feilds: Name, Strength, Intelligence, Dexterity
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        // Add an additional private field for health, and a public property to access or "get" health
        public int Health {get;set;}

        
        
        // Add a constructor method that takes a string to initialize Name - and that will initialize Strength, Intelligence, and Dexterity to a default value, 3 and health to default value of 100
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }

        // Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }
        
        // Now add a method called Attack, which when invoked, should reduce the health of a Human object that is passed as a parameter. The damage done should be 5 * strength. This method should return the remaining health of the target object.
        public virtual int Attack(Human target)
        {
            int Damage = 5 * Strength;
            target.Health -= Damage;
            Console.WriteLine($"{target.Name} loses {Damage} Health!");
            Console.WriteLine($"{target.Name} has {target.Health} Health left!");
            return target.Health;
        }
    }
}
