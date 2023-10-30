using System;


namespace Hero_overloading_operators
{
    public class Hero
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Energy { get; set; }
        public Magic Magic { get; set; }
        public Weapon Weapon { get; set; }
        public Hero(string name, int health, int energy, Magic magic, Weapon weapon)
        {
            Name = name;
            Health = health;
            Energy = energy;
            Magic = magic;
            Weapon = weapon;

        }
        public void AtackUseMagic(Hero enemy)
        {
            Console.WriteLine($"{Name} is using magic ");
            enemy.Health -= Magic.Damage;
            Magic.Level -= Magic.Damage;
        }

        public void AtackUseWeapon(Hero enemy)
        {
            Console.WriteLine($"{Name} is using weapon ");
            enemy.Health -= Weapon.Damage;
            Energy -= Weapon.Damage;
        }

        public void ShowHero()
        {
            Console.WriteLine($"Name: {Name} ");

            Console.WriteLine($"Magic type: {Magic.Name} ");
            Console.WriteLine($"Weapon type: {Weapon.Name} ");
            Console.Write($"Health ({Health}):\t\t");
            Console.BackgroundColor = ConsoleColor.Red;
            for (int i = 0; i < Health; i++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.Write($"Energy ({Energy}):\t\t");
            Console.BackgroundColor = ConsoleColor.Green;
            for (int i = 0; i < Energy; i++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.Write($"Magic lavel ({Magic.Level}):\t");
            Console.BackgroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Magic.Level; i++)
            {
                Console.Write(" ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();


        }
        public void Speak()
        {
            Console.WriteLine($"{Name} is speaking ");
        }
    }
}
