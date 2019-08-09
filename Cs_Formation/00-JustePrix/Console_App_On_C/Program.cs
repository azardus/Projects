using System;

namespace Console_App_On_C
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            /*
             *                     1- Les conditions :
             *                      
             *      EXO 1: Le juste prix en utilisant les conditions : 
             * 
             * 
             * */

            Console.WriteLine("Exercice du juste prix en utilisant les conditions :");

            int secretNumber = 42;
            int inputNumber = 52;


            if (inputNumber < secretNumber)
            {
                Console.WriteLine("le nombre secret est plus grand");
            }
            else if (inputNumber > secretNumber)
            {
                Console.WriteLine("le nombre secret est plus petit");
            }
            else
            {
                Console.WriteLine("Vous avez trouvez le bon prix");
            }



                // EXO 2: Afficher le mois par rapport a son numero x :

            Console.WriteLine("Afficher le mois par rapport a sa variable x");

            int x = -1;


            if (x == 1) { Console.WriteLine("Janvier"); }
            else if (x == 2) { Console.WriteLine("Février"); }
            else if (x == 3) { Console.WriteLine("Mars"); }
            else if (x == 4) { Console.WriteLine("Avril"); }
            else if (x == 5) { Console.WriteLine("Mai"); }
            else if (x == 6) { Console.WriteLine("Juin"); }
            else if (x == 7) { Console.WriteLine("Juillet"); }
            else if (x == 8) { Console.WriteLine("Aout"); }
            else if (x == 9) { Console.WriteLine("Septembre"); }
            else if (x == 10) { Console.WriteLine("Octobre"); }
            else if (x == 11) { Console.WriteLine("Novembre"); }
            else if (x == 12) { Console.WriteLine("Decembre"); }
            else { Console.WriteLine("Le nombre x n'est pas un moi"); }



            // INTERPOLATION DE CHAINE GRACE AU $ {}

            string name = "jeremie";
            string lastname = "pichot";


            Console.WriteLine($"Bonjour {name}");

            Console.WriteLine($"sait tu que ton nom : {lastname} contient {lastname.Length} caractères.");

            Console.WriteLine("Bonjour" + name);

            Console.WriteLine("Hello World!");
            Console.ReadKey();


        }
    }
}
