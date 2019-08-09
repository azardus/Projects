using System;

namespace _05_02_Loops_MoreOrLessFor
{
    class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Veuillez entrer un nombre entier.");

            int secretValue = new Random(DateTime.UtcNow.Millisecond).Next(0, 2);
            int userValue = GetIntegerFromUserInput(); // Récupération d'un nombre depuis le clavier.
            int count = 1;
            // TODO: Faire algorithme avec une boucle for

            for (; userValue != secretValue; count += 1)
            {
                if (userValue < secretValue)
                {
                    Console.WriteLine($" Votre valeur {userValue} est trop petite, chercher encore :-)");
                    userValue = GetIntegerFromUserInput();
                }
                else if (userValue > secretValue)
                {
                    Console.WriteLine($" Votre valeur {userValue} trop grande, chercher encore :-)");
                    userValue = GetIntegerFromUserInput();
                }

            }

            if (count != 1)
            {
                Console.WriteLine($" Bravo!!! Votre valeur :{userValue} est bien la valeur secret :{secretValue}. Vous avez trouvez la bonne valeur en {count} tentatives ");
            }
            else
                Console.WriteLine($" Bravo!!! Votre valeur :{userValue} est bien la valeur secret :{secretValue}. Vous avez trouvez la valeur secrète du premier coup. ");

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
    }
}