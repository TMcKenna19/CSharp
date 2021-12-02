using System;

namespace Human
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name,3,3,175,100)
        {

        }
        
        public override int Attack(Human enemy)
        {
            Random r = new Random();
            int damage = 5 * Dexterity;
            if(r.Next(100) <= 20)
                damage += 10;
            return base.Attack(enemy, damage);
        }

        // public override int Steal(Human enemy)
        // {
        //     health += base.Attack(enemy, 10);
        // }
        //no suitable method found to override 
    }
}