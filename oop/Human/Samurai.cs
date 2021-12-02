using System;

namespace Human
{
    class Samurai : Human
    {
        public Samurai(string name) : base(name,3,3,3,200)
        {
            
        }
        
        // public override int Attack(Human enemy)
        // {
        //    int Health = Attack(enemy);
        //    if (Health < 50)
        //    {
        //        enemy.Health = 0;
        //        Console.WriteLine($"{enemy.Name} health 0");
        //    }
        //    return Health;
        // }
        // casues stack overflow 

        public void Meditate()
        {
            health = 200;
        }
        
    }
    
}