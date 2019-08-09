using System;
using System.Timers;


namespace BrancheAndLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Structure conditionnelle 'if' :");
            Console.WriteLine("-------------------------------");
            int a = 5;
            int b = 6;
            b = 3; 
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
            else
                Console.WriteLine("The answer is not greater than 10.");


            Console.WriteLine("la boocle While :");
            Console.WriteLine("-----------------");

            Console.WriteLine("Faire un compte a rebour :");

            int count = 10;
            while (count <= 10 && count > 0)
            {
                Console.WriteLine($"il ne vous reste que {count}");
                count--;
                
                
            };

            Console.ReadKey();
        }
    }
}
