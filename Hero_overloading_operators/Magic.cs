using System;


namespace Hero_overloading_operators
{
    public class Magic
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }
        public Magic(string name, int damage, int level)
        {
            Name = name;
            Damage = damage;
            Level = level;
        }
        public void SetName(string name) { Name = name; }
        public void SetDamage(int damage) { Damage = damage; }
        public void SetLevel(int level) { Level = level; }

    }
}
