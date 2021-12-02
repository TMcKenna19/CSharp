using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Tim = new Human("Tim", 75,95,82,100); 
            // Tim.ShowStats();
            // Console.WriteLine("*************");

            Wizard Gandalf = new Wizard("Gandalf");

            // Gandalf.Attack(Tim);
            // Tim.ShowStats();
            // Console.WriteLine("*************");
            // Gandalf.ShowStats();

            // Tim.ShowStats();    
            // Gandalf.Heal(Tim);
            // Tim.ShowStats();
            // Gandalf.ShowStats();
            // Console.WriteLine("*************");

            Ninja Hattori = new Ninja ("Hattori");
            // Hattori.Attack(Tim);
            // Tim.ShowStats();
            // Console.WriteLine("*************");
            // Hattori.ShowStats();
            
            // Hattori.Steal(Tim);
            // Hattori.ShowStats();
            // Tim.ShowStats();
            

            Samurai Miyamoto = new Samurai("Miyamoto");
            Miyamoto.Attack(Tim);
            Tim.ShowStats();
            // Miyamoto.ShowStats();
            // Miyamoto.Meditate();
            // Miyamoto.ShowStats();
            
            
        }

    }
}
