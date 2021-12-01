using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human a = new Human("Tim", 75,95,82,100);
            // Console.WriteLine(a.Name);
            a.ShowStats();
        }
    }
}
