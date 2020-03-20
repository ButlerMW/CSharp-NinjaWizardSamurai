using System;

namespace NinjaWizardSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fight!");
            Human Joe = new Human("Joe");
            Wizard Merlin = new Wizard("Merlin");
            Ninja Koga = new Ninja("Koga");
            Samurai Jack = new Samurai("Jack");
            Koga.Attack(Merlin);
            Console.WriteLine($"Koga HP: {Koga.health}");
            Console.WriteLine($"Jack HP: {Jack.health}");
            Console.WriteLine($"Merlin HP: {Merlin.health}");
            Jack.Attack(Merlin);
            Console.WriteLine($"Merlin HP: {Merlin.health}");
            Merlin.Heal(Merlin);
            Console.WriteLine($"Merlin HP: {Merlin.health}");
            Merlin.Attack(Jack);
            Console.WriteLine($"Jack HP: {Jack.health}");
            Jack.Meditate();
            Console.WriteLine($"Jack HP: {Jack.health}");
            Koga.Steal(Jack);
            Console.WriteLine($"Jack HP: {Jack.health}");
            Console.WriteLine($"Koga HP: {Koga.health}");
        }
    }
}
