using System;
namespace NinjaWizardSamurai
{
    public class Samurai : Human
    {

        public Samurai(string name) : base(name)
        {
            health = 200;
        }

        public override int Attack(Human target)
        {
            Console.WriteLine($"{ Name } is attacking { target.Name }!");
            if (target.health < 50)
            {
                Console.WriteLine($"Instant Kill!!!");
                target.health = 0;
            }
            else
            {
                base.Attack(target); // calls the base attack 
            }
            return target.health;
        }

        public int Meditate() 
        {
            Console.WriteLine($"{ Name } is meditating and back to full health!");
            health = 200;
            return health;
        }
    }
}
