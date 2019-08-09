using System;

namespace _01_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(integerArray[0]);

            // TYPE name = VALUE
            int a = 34;
            int b = 6;
            int result = a + b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(result);
            Console.WriteLine(a + b);
            b++;
            Console.WriteLine(b);




            // INTERPOLATION DE CHAINE GRACE AU $ {}

            string name = "jeremie";
            string lastname = "pichot";


            Console.WriteLine($"Bonjour {name}");

            Console.WriteLine($"sait tu que ton nom : {lastname} contient {lastname.Length} caractères.");

            Console.WriteLine("Bonjour" + name);

            Console.WriteLine ("help");
            Console.ReadKey();

        }


    }
}

