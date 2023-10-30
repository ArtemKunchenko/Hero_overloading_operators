using System;


namespace Hero_overloading_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon sword = new Weapon("Sword", 5);
            Magic flame = new Magic("Flame", 10, 20);
            Hero player = new Hero("Alex", 30, 30, flame, sword);
            player.ShowHero();
            Console.ReadKey();
        }
    }
}
