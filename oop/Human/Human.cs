using System;

namespace Human
{
   public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;
        
        public int Health
        {
            get {return health;}
            set{}
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        
        public Human(string name, int str, int intell, int dex, int hel)
        {
            Name = name;
            Strength = str;
            Intelligence = intell;
            Dexterity = dex;
            health = hel;
        }


        public virtual int Attack(Human enemy)
        {
            int damage = Strength * 3;
            enemy.health -= damage;
            Console.WriteLine($"{Name} attacked {enemy.Name} Damage: {damage}");
            return enemy.health;
        }
        
        public virtual int Attack(Human enemy, int damage)
        {
            enemy.health -= damage;
            return enemy.health;
        }

        public void changeHealth(int amount)
        {
            health = health + amount;
        }

        
        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Dexterity: {Dexterity}");
            Console.WriteLine($"Health: {health}");
            
        }
        
        
    }
}