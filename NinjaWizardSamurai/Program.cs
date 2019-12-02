using System;

namespace NinjaWizardSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human Joe = new Human("Joe");
            Wizard Merlin = new Wizard("Merlin");
            Ninja Koga = new Ninja("Koga");
            Samurai Jack = new Samurai("Jack");
            // Joe.Attack(Merlin);
            // Console.WriteLine($"Joe HP: {Joe.Health}"); 
            // Console.WriteLine($"Merlin Int: {Merlin.Intelligence}");
            // Merlin.Attack(Koga);
            Koga.Attack(Merlin);
            Console.WriteLine($"Koga HP: {Koga.Health}");
            Console.WriteLine($"Jack HP: {Jack.Health}");
            Console.WriteLine($"Merlin HP: {Merlin.Health}");
            Jack.Attack(Merlin);
            Console.WriteLine($"Merlin HP: {Merlin.Health}");
            Merlin.Heal(Merlin);
            Console.WriteLine($"Merlin HP: {Merlin.Health}");
            Merlin.Attack(Jack);
            Console.WriteLine($"Jack HP: {Jack.Health}");
            Jack.Meditate();
            Console.WriteLine($"Jack HP: {Jack.Health}");
            Koga.Steal(Jack);
            Console.WriteLine($"Jack HP: {Jack.Health}");
            Console.WriteLine($"Koga HP: {Koga.Health}");





        }
    }
}
