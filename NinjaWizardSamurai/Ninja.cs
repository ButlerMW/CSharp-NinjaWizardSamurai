using System;

namespace NinjaWizardSamurai
{
    public class Ninja : Human
    {

        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }

         public override int Attack(Human target)
        {
            Console.WriteLine($"{ Name } is attacking { target.Name }");
            int Damage = 5 * Dexterity;
            Random rand = new Random();
            int x = rand.Next(1,6);
            // Console.WriteLine(x);
            if (x == 1)
            {
                Damage += 10;
                target.Health -= Damage;
                Console.WriteLine("Critical Hit!");
            }
            else
            {
                target.Health -= Damage;
            }
            Console.WriteLine($"{target.Name} has {target.Health} health left!!");
            return target.Health;
        }

        public int Steal(Human target)
        {
            Console.WriteLine($"{ Name } is stealing health from { target.Name }");
            int StolenHP = 5;
            target.Health -= StolenHP;
            Health += StolenHP;
            return target.Health;
        }
    }
}
