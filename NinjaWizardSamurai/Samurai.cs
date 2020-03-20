using System;
namespace NinjaWizardSamurai
{
    public class Samurai : Human
    {

        public Samurai(string name) : base(name)
        {
            Health = 200;
        }

        public override int Attack(Human target)
        {
            Console.WriteLine($"{ Name } is attacking { target.Name }!");
            if (target.Health < 50)
            {
                Console.WriteLine($"Instant Kill!!!");
                target.Health = 0;
            }
            else
            {
                base.Attack(target); // calls the base attack 
            }
            return target.Health;
        }

        public int Meditate() 
        {
            Console.WriteLine($"{ Name } is meditating and back to full health!");
            Health = 200;
            return Health;
        }
    }
}
