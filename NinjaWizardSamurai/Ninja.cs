using System;
namespace NinjaWizardSamurai
{
    public class Ninja : Human
    {

        public Ninja(string name) : base(name)
        {
        //     Name = name;
        //     Strength = 3;
        //     Intelligence = 25;
            Dexterity = 175;
        }

        public override int Attack(Human target)
        {
            target.Health -= 5 * Dexterity;
            Random rand = new Random();
            int x = rand.Next(1,6);
            Console.WriteLine(x);
            if (x == 1)
            {
                target.Health -= 10;
                Console.WriteLine("Critical Hit!");
            }
            return target.Health;
        }

        public int Steal(Human target)
        {
            target.Health -= 5;
            Health += 5;
            return target.Health;
        }

    }
}