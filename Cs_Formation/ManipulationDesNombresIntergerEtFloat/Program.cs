using System;

namespace ManipulationDesNombresIntergerEtDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 7;
            //int b = 4;
            //int c = 3;

            //int d = (a + b) / c;
            //int e = (a + b) % c;

            Console.WriteLine("Le type int :");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");

            //Console.WriteLine($"quotient: {d}");
            //Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"La plage de valeur du type 'int' est de {min} à {max}.");

            int valueOutOfInt = max + 5;
            Console.WriteLine(valueOutOfInt);
            Console.WriteLine("");


            Console.WriteLine("Le type double :");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");

            double a = 19;
            double b = 23;
            double c = 8;
            double d = (a + b) / c;
            Console.WriteLine(d);
            
            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            Console.WriteLine($"The range of double is {minDouble} to {maxDouble}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);
            Console.WriteLine();


            Console.WriteLine("Le type décimal :");
            Console.WriteLine("-----------------");

            Console.WriteLine("Le type decimal a une plage plus petite, mais une précision supérieure à celle du type double.");

            decimal minDecimal = decimal.MinValue;
            decimal maxDecimal = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {minDecimal} to {maxDecimal}");

            double aDouble = 1.0;
            double bDouble = 3.0;
            Console.WriteLine(aDouble / bDouble);

            decimal cDecimal = 1.0M;
            decimal dDecimal = 3.0M;
            Console.WriteLine(cDecimal / dDecimal);

            Console.WriteLine();


            Console.WriteLine("Exercie de calcul d'une surface de cercle :");
            Console.WriteLine("--------------------------------------------");


             void CalculDeAirDuCercle(double rayon)
            {
                double r = rayon;
                double air = System.Math.PI * r * r;
                Console.WriteLine(air);
            }
            CalculDeAirDuCercle(2.5);

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);

            int a2 = default(int);
            Console.WriteLine(a2);

            byte a3 = 13;
            Console.WriteLine(a3);
            byte a4 = 255;
            Console.WriteLine(a4);




            Console.ReadKey();
        }
    }
}
