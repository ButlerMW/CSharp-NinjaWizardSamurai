using System;
namespace NinjaWizardSamurai
{
    public class Wizard : Human
    {
        
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            Health = 50;
        }

        public override int Attack(Human target) //fix this!!!
        {
            target.Health -= 5 * Intelligence;
            // if (Health < 50)
            // {
                Health += 5 * Intelligence; 
            // }
            // else
            // {
            //     Health = 50;
            // }
            // ^^^function heal?????????????????
            return target.Health;
        }

        public int Heal(Human target)
        {
            target.Health += 10 * Intelligence;
            return target.Health;
        }
    }
}