using System;

namespace Human
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        
        public int Health
        {
            get {return health;}
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            heatlh = 100;
        }
        public Human(string name, int str, int intell, int dex, int hel)
        {
            Name = name;
            Strength = str;
            Intelligence = intell;
            Dexterity = dex;
            health = hel;
        }
        public int Attack(Human enemy)
        {
            int damage = Strength * 3;
            enemy.health -= damage;
            Console.WriteLine($"{Name} attacked {enemy.Name} Damage: {damage}");
            return enemy.health;
        }
        
        
    }
}