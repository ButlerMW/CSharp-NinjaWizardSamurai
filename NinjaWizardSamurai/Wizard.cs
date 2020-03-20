using System;

namespace NinjaWizardSamurai
{
    public class Wizard : Human
    {
        
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            health = 50;
        }

        public override int Attack(Human target)
        {
            Console.WriteLine($"{ Name } is attacking { target.Name }!!");
            int Damage = 5 * Intelligence;
            Console.WriteLine($"{ target.Name } has { target.Health } left!!");
            target.health -= Damage;
            health += Damage; 
            if(health > 50)
            {
                health = 50;
            }
            Console.WriteLine($"{ Name } is healed back to { Health }!!!");
            return target.health;
        }

        public int Heal(Human target)
        {
            int Healing = 10 * Intelligence;
            Console.WriteLine($"{ Name} is healing { target.Name }!");
            target.health += Healing;
            return target.health;
        }
    }
}
