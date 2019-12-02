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
            base.Attack(target); // calling the base attack
            if (target.Health < 50)
            {
                target.Health = 0;
            }
            return target.Health;
        }

        public int Meditate() //heal self?
        {
            Health = 200;
            return Health;
        }
    }
}