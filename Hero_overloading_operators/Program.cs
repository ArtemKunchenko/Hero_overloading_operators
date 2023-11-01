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
            Hero support = new Hero("Bob", 10, 10, flame, sword);
            Hero enemy = new Hero("Ron", 10, 10, flame, sword);
            player.ShowHero();
            Console.WriteLine();
            //Hero sum = player + support;
            //Hero sub = player - enemy;
            //Hero mul = player * 2;
            Hero dev = player / 10;
            dev.ShowHero();
            Console.ReadKey();
        }
    }
}
