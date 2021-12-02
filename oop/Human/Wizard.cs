using System;

namespace Human
{
    
    class Wizard : Human
    {
        public Wizard(string name) : base(name,3,25,3,50)
        {
             
        }

        public override int Attack(Human enemy)
        {
            
            int damage = base.Attack(enemy,Intelligence * 5);
            health -= damage;
            this.health += Intelligence*5;
            Console.WriteLine($"{Name} attacked {enemy.Name} Damage: {damage} {Name} Healed:{health}");
            return damage;
        }
        
        public void Heal(Human enemy)
        {
            enemy.changeHealth(Intelligence*10);
        }

        



    }


}

