using System;

namespace _05_03_Lopps_MoreOrLessWhile
{


    class Program
    {
        /// <summary>
        /// Gets an integer from the user input.
        /// </summary>
        /// <returns>User input text as an integer value.</returns>
        public static int GetIntegerFromUserInput()
        {
            int userInputAsInteger;

            while (!int.TryParse(Console.ReadLine(), out userInputAsInteger))
            {
                Console.WriteLine("Veuillez entrer un nombre entier.");
            }

            return userInputAsInteger;
        }



        /// <summary>
        /// Program entry point.
        /// </summary>
        /// 
        public static void Main()
        {

            Console.WriteLine("Veuillez entrer un nombre entier.");

            int secretValue = new Random(DateTime.UtcNow.Millisecond).Next(0, 10);
            int userValue = GetIntegerFromUserInput(); // Récupération d'un nombre depuis le clavier.
            //int userValue = 2;
            int count = 1;

            // TODO: Faire algorithme avec une boucle while


            while (userValue != secretValue)
            {
                count += 1;

                if (userValue < secretValue)
                {
                    Console.WriteLine($" Votre votre {userValue} est trop petite, chercher encore :-)");
                    userValue = GetIntegerFromUserInput();
                    //userValue = 2;

                }
                else if (userValue > secretValue)
                {
                    Console.WriteLine($" Votre votre {userValue} est trop grande, chercher encore :-)");
                    userValue = GetIntegerFromUserInput();
                    //userValue = 2;

                }

            }
            if (count != 1)
            {
                Console.WriteLine($" Bravo!!! votre valeur: {userValue} est bien la valeur secret {secretValue}. Vous avez trouvez la valeur en {count} tantatives.");
            }
            else
                Console.WriteLine($" Bravo!!! votre valeur: {userValue} est bien la valeur secret {secretValue}. Vous avez trouvez la valeur du premier coup.");

            Console.ReadLine();
        }


    }
}