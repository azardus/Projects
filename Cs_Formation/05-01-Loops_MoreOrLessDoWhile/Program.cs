using System;
using System.Collections.Generic;

namespace _05_01_Loops_MoreOrLessDoWhile
{
    class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Veuillez entrer un nombre entier.");

            int secretValue = new Random(DateTime.UtcNow.Millisecond).Next(0, 10);
            int userValue = 0; // Récupération d'un nombre depuis le clavier.
            int count = 0;
            // TODO: Faire algorithme avec une boucle do...while

            do
            {
                userValue = GetIntegerFromUserInput();
                count = count + 1;
                if (userValue < secretValue)
                {
                    Console.WriteLine($"Vôtre valeur {userValue} est trop petite, chercher encore ...");
                }
                else if (userValue > secretValue)
                {
                    Console.WriteLine($"Vôtre valeur {userValue} est trop grande, chercher encore ...");
                }
            }
            while (userValue != secretValue);

            string attempts = (count != 1 ? "s" : "");

            Console.WriteLine($"Bravo vous avez trouvé la valeur secrète {secretValue} en {count} tantative{attempts}");

            //FIN
            List<ConsoleKey> keys = new List<ConsoleKey>();
            keys.Add(ConsoleKey.Y);
            keys.Add(ConsoleKey.N);

            ConsoleKey result = Question("Voulez-vous rejouer ? [y/n]", keys);

            //todo : if rejouer = oui relancer sinon quitter
            Console.ReadLine();

        }

        /// <summary>
        /// Gets an integer from the user input.
        /// </summary>
        /// <returns>User input text as an integer value.</returns>
        static int GetIntegerFromUserInput()
        {
            int userInputAsInteger = 0;

            while (!int.TryParse(Console.ReadLine(), out userInputAsInteger))
            {
                Console.WriteLine("Veuillez entrer un nombre entier.");
            }

            return userInputAsInteger;
        }


        static ConsoleKey Question(string question, List<ConsoleKey> keys)
        {
            Console.WriteLine(question);
            Console.WriteLine(keys);

            return ConsoleKey.A;
        }


    }
}