using System;

namespace Human
{
    class Samurai : Human
    {
        public Samurai(string name) : base(name,3,3,3,200)
        {
            
        }
        
        public override int Attack(Human enemy)
        {
           int Health = enemy.Health;
           if (Health < 50)
           {
               int amount = enemy.Health * -1;
               enemy.changeHealth(amount);
               Console.WriteLine($"{enemy.Name} health 0");
           }
           return enemy.Health;
        }
        

        public void Meditate()
        {
            health = 200;
        }
        
    }
    
}