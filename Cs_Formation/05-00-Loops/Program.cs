using System;

namespace _05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Syntaxe:

            // 1)
            // while (CONDITION)
            // {
            //   ...
            // }

            // 2)
            // do
            // {
            //   ...
            // } while (CONDITION);

            // 3)
            // for (INITIALIZE_VARS; CONDITION; INCREMENT)
            // {
            //   ...
            // }

            int limitAge = 18;
            int currentAge = 5;

            Console.WriteLine("############# WHILE ... ############");

            while (currentAge < limitAge)
            {
                Console.WriteLine($"J'ai {currentAge} ans. La limite est {limitAge}.");
                currentAge = currentAge + 1; // currentAge += 1 OU currentAge++
            }

            Console.WriteLine("############# DO...WHILE ############");

            currentAge = 5;

            do
            {
                Console.WriteLine($"J'ai {currentAge} ans. La limite est {limitAge}.");
                currentAge = currentAge + 1; // currentAge += 1 OU currentAge++
            } while (currentAge < limitAge);

            Console.WriteLine("######### FOR #########");

            for (currentAge = 5; currentAge < limitAge; currentAge++)
            {
                Console.WriteLine($"J'ai {currentAge} ans. La limite est {limitAge}.");
            }

            Console.ReadKey();
        }
    }
}
