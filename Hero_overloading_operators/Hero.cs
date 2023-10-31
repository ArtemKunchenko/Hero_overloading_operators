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
        public Hero()
        {
            Name = "";
            Health = 0;
            Energy = 0;
            Magic = new Magic();   
            Weapon = new Weapon();

        }
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
            Console.Write($"Magic level ({Magic.Level}):\t");
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
        
        public static Hero operator +(Hero a, Hero b)
        {
            return new Hero(a.Name, a.Health + b.Health, a.Energy + b.Energy, a.Magic, a.Weapon);
        }
        //This method accepts two operands (type Hero) and creates a new object of class Hero using internal standart constructor with next parrametrs:
        //Name (name from the first operand)
        //Health (sum of helth levels from first and second operands)
        //Energy (sum of energy levels from first and second operands)
        //Magic and Weapon (values from first operand)
        public static Hero operator -(Hero a, Hero b)
        {
            Hero hero = new Hero();
            hero.Name = a.Name;
            if (a.Health > b.Health) { hero.Health = a.Health - b.Health; }
            else { hero.Health = 0; }
            if (a.Energy > b.Energy) { hero.Energy = a.Energy - b.Energy; }
            else { hero.Energy = 0; }
            hero.Magic = a.Magic;
            hero.Weapon = a.Weapon;
            return hero;
        }
        //This method accepts two operands (type Hero) and creates a new object of class Hero using internal standart constructor without parrametrs. Then acordin to conditon fields in object accepts next values:
        //Name (name from the first operand)
        //Health (if health level of first operand more then second, health level of new object is subtraction  of helth levels from first and second operands, else helth level of new object assigns value 0)
        //Energy (if energy level of first operand more then second, energy level of new object is subtraction  of helth levels from first and second operands, else energy level of new object assigns value 0)
        //Magic and Weapon (values from first operand)
        public static Hero operator *(Hero a, int b)
        {
            return new Hero(a.Name, a.Health * b, a.Energy * b, a.Magic, a.Weapon);
        }
        //This method accepts two operands (type Hero and type int) and creates a new object of class Hero using internal standart constructor with next parrametrs:
        //Name (name from the first operand)
        //Health (multiplication of helth level from first operands and particular value)
        //Energy (multiplication of helth level from first operands and particular value)
        //Magic and Weapon (values from first operand)

    }
}
