using System;

namespace Hero_overloading_operators
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public Weapon() 
        {
            Name = "";
            Damage = 0;
        }
        public Weapon(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
        public void SetName(string name) { Name = name; }
        public void SetDamage(int damage) { Damage = damage; }

    }
}
