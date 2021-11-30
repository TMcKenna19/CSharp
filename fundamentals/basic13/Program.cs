using System;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintNumbers();
        }
        //print all of the intergers from 1 to 255
        public static void PrintNumbers(){
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    
}
